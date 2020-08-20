﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
    public static class TournamentLogic
    {
        
        // Order our list of teams randomly
        // Check if its big enough, if its not then add in "BYES" (automatic win, no of byes = no of people with automatic win)
        // For TOurnament to work the teams should be in 2^n where n >= 1
        // Create our first round of matchups
        // Create every round after that (dividing it by 2, ex: 16 People = 8 teams/matchups --> 4 teams/matchups --> 2 teams/matchups --> 1 team/matchup --> 1 winner)

        public static void  CreateRounds(TournamentModel model)
        {
            List<TeamModel> randomizedTeams = RandomizeTeamOrder(model.EntreredTeams);
            int rounds = FindNumberOfRounds(randomizedTeams.Count);
            int byes = NumberOfByes(rounds, randomizedTeams.Count);

            model.Rounds.Add(CreateFirstRound( byes, randomizedTeams));

            CreateOtherRounds(model, rounds);

            UpdateTournamentResults(model);
        }

        public static void UpdateTournamentResults(TournamentModel model)
        {
            int startingRound = model.CheckCurrentRound();
            List<MatchupModel> toScore = new List<MatchupModel>();

            foreach (List<MatchupModel> round in model.Rounds)
            {
                foreach (MatchupModel rm in round)
                {
                    if(rm.Winner == null && (rm.Entries.Any(x=> x.Score != 0) || rm.Entries.Count ==1))
                    {
                        toScore.Add(rm);
                    }
                }
            }

            MarkWinnerInMatchups(toScore);

            AdvanceWinners(toScore,model);

            // instead of doing foreach. short way.
            toScore.ForEach(x => GlobalConfig.Connection.UpdateMatchup(x));
            int endingRound = model.CheckCurrentRound();

            if(endingRound > startingRound)
            {
                // Alert Users

                AlertUsersToNewRound(model);
            }
        }


        private static void AlertUsersToNewRound(this TournamentModel model)
        {
            int currentRoundNumber = model.CheckCurrentRound();
            List<MatchupModel> currentRound = model.Rounds.Where(x => x.First().MatchupRound == currentRoundNumber).First();

            foreach (MatchupModel matchup in currentRound)
            {
                foreach (MatchupEntryModel me in matchup.Entries)
                {
                    foreach(PersonModel p in me.TeamCompeting.TeamMembers)
                    {
                        AlertPersonToNewRound(p, me.TeamCompeting.TeamName, matchup.Entries.Where(x => x.TeamCompeting != me.TeamCompeting).FirstOrDefault());
                    }
                }
            }
        }

        private static void AlertPersonToNewRound(PersonModel p, string teamName, MatchupEntryModel competitor)
        {
            if(p.EmailAddress.Length == 0)
            {
                if (!IsValidEmail(p.EmailAddress))
                {
                    
                    return;
                }

            }

            string to = "";
            string subject = "";
            StringBuilder body = new StringBuilder();

            if(competitor != null)
            {
                subject = $"You have a new matchup with {competitor.TeamCompeting.TeamName}";

                body.AppendLine("<h1>You have a new matchup</h1>");
                body.Append("<strong>Competitor: </strong>"); // Similar to appending a new line = sb.AppendLine
                body.Append(competitor.TeamCompeting.TeamName);
                body.AppendLine();
                body.AppendLine();
                body.AppendLine("Have a great time!");
                body.AppendLine("~Tournament Tracker");

            }
            else
            {
                subject = $"You have a bye week this round";

                body.AppendLine("Enjoy your round off!");
                body.AppendLine("~Tournament Tracker");

            }
            to = p.EmailAddress;

            EmailLogic.SendEmail(to, subject, body.ToString());
        }

        private static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        private static int CheckCurrentRound(this TournamentModel model)
        {
            int output = 1;
            foreach (List<MatchupModel> round in model.Rounds)
            {
                if (round.All(x => x.Winner != null))
                {
                    output += 1;
                }
            }
            return output;
        }

        private static void AdvanceWinners(List<MatchupModel> models,TournamentModel tournament)
        {
            foreach (MatchupModel m in models)
            {
                foreach (List<MatchupModel> round in tournament.Rounds)
                {
                    foreach (MatchupModel rm in round)
                    {
                        foreach (MatchupEntryModel me in rm.Entries)
                        {
                            if (me.ParentMatchup != null)
                            {
                                if (me.ParentMatchup.Id == m.Id)
                                {
                                    me.TeamCompeting = m.Winner;
                                    GlobalConfig.Connection.UpdateMatchup(rm);
                                }
                            }
                        }
                    }
                }
            }

        }

        private static void MarkWinnerInMatchups(List<MatchupModel> models)
        {
            // if greater score is winner or lesser score.
            // Stored in App.Config file
            string greaterWins = ConfigurationManager.AppSettings["greaterWins"];

            foreach (MatchupModel m in models)
            {
                // Checks for bye wwk entry
                if(m.Entries.Count == 1)
                {
                    m.Winner = m.Entries[0].TeamCompeting;
                    continue;
                }
                
                // 0 means false, or low score wins
                if (greaterWins == "0")
                {
                    if (m.Entries[0].Score < m.Entries[1].Score)
                    {
                        m.Winner = m.Entries[0].TeamCompeting;
                    }
                    else if(m.Entries[1].Score < m.Entries[0].Score)
                    {
                        m.Winner = m.Entries[1].TeamCompeting;
                    }
                    else
                    {
                        throw new Exception("We do not allow ties in this application.");
                    }
                }
                else
                {
                    // 1 means true, or high score wins
                    if (m.Entries[0].Score > m.Entries[1].Score)
                    {
                        m.Winner = m.Entries[0].TeamCompeting;
                    }
                    else if (m.Entries[1].Score > m.Entries[0].Score)
                    {
                        m.Winner = m.Entries[1].TeamCompeting;
                    }
                    else
                    {
                        throw new Exception("We do not allow ties in this application.");
                    }
                } 
            }

        }

        private static void CreateOtherRounds(TournamentModel model, int rounds)
        {
            // 2 becuase we already took care of 1st round matchup
            int round = 2;
            
            //Return matchups from our first round
            List<MatchupModel> previousRound = model.Rounds[0];

            List<MatchupModel> currRound = new List<MatchupModel>();
            MatchupModel currMatchup = new MatchupModel();

            while(round <= rounds)
            {
                foreach (MatchupModel match in previousRound)
                {
                    currMatchup.Entries.Add(new MatchupEntryModel { ParentMatchup = match });

                    if (currMatchup.Entries.Count > 1)
                    {
                        currMatchup.MatchupRound = round;
                        currRound.Add(currMatchup);
                        currMatchup = new MatchupModel();
                    }
                }
                model.Rounds.Add(currRound);
                previousRound = currRound;

                currRound = new List<MatchupModel>();
                round += 1;
            }
        }

        private static List<MatchupModel> CreateFirstRound(int byes, List<TeamModel> teams)
        {
            List<MatchupModel> output = new List<MatchupModel>();
            MatchupModel curr = new MatchupModel();

            foreach (TeamModel team in teams)
            {
                curr.Entries.Add(new MatchupEntryModel { TeamCompeting = team });

                // assign all the bye at the beginning instead of at the end to simplify the logic
                if (byes > 0 || curr.Entries.Count > 1)
                {
                    curr.MatchupRound = 1;
                    output.Add(curr);
                    curr = new MatchupModel();
                    
                    //if byes are still left subtract 1
                    if (byes > 0)
                    {
                        byes -= 1; 
                    }
                }
            }
            return output;
        }

        private static int NumberOfByes(int rounds, int numberOfTeams)
        {
            int output = 0;
            int totalTeams = 1;
            
            for(int i = 1; i <= rounds; i++)
            {
                totalTeams *= 2;
            }
            output = totalTeams - numberOfTeams;

            return output;
        }

        private static int FindNumberOfRounds(int teamCount) 
        {
            int output = 1;
            int val = 2;

            while (val < teamCount)
            {
                // increase number of rounds by 1
                output += 1;

                val *= 2;
            }

            return output;
        }

        private static List<TeamModel> RandomizeTeamOrder(List<TeamModel> teams)
        {
            // Obtained this from StackOverflow. Thanks https://stackoverflow.com/questions/273313/randomize-a-listt
            return teams.OrderBy(a => Guid.NewGuid()).ToList();
            
        }
    }
}
