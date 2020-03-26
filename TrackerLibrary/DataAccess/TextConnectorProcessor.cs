using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

// * Load text file
// * Convert text to List<PrizeModels>
// Find max ID
// Add the new record with the new ID (max + 1)
// Convert the Prizes to a List<string>
// Save the List<string> to the text file

namespace TrackerLibrary.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor
    {
        //NOTE: "this string" declaration in the method signature makes FullFilePath an extension method
        public static string FullFilePath(this string fileName) // PrizeModels.csv
        {
            // \\ to have a backslash
            // {} read curly brace as the Dictory's key value is returned from App.Setting's key = Filepath
            // This will return as \\local.giftrapcorp.com\users\Saurabhm\Documents\GitHub\TournamentTrackerDB\Text Files DB\PrizeModel.csv
            return $"{ ConfigurationManager.AppSettings["filePath"] }\\{ fileName }";
        }

        public static List<string> LoadFile(this string file)
        {
            // If File doesn't exists, return an empty new List of String
            if (!File.Exists(file))
            {
                return new List<string>();
            }
            return File.ReadAllLines(file).ToList();
        }

        public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();

            foreach(string line in lines)
            {
                string[] cols = line.Split(',');
                PrizeModel p = new PrizeModel();
                p.Id = int.Parse(cols[0]);
                p.PlaceNumber= int.Parse(cols[1]);
                p.PlaceName = cols[2];
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.PrizePercentage = double.Parse(cols[4]);
                output.Add(p);
            }
            return output;
        }

        public static void SaveToPrizeFile(this List<PrizeModel> models, string fileName)
        {
            List<string> lines = new List<string>();
            foreach(PrizeModel p in models)
            {
                lines.Add($"{ p.Id },{p.PlaceNumber},{p.PlaceName},{p.PrizeAmount},{p.PrizePercentage}");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static List<PersonModel> ConvertToPersonModels(this List<string> lines)
        {
            List<PersonModel> output = new List<PersonModel>();

            foreach(string line in lines)
            {
                string[] cols = line.Split(',');
                PersonModel p = new PersonModel();
                p.Id = int.Parse(cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.EmailAddress = cols[3];
                p.CellphoneNumber = cols[4];
                output.Add(p);
            }
            return output;
        }

        public static void SaveToPeopleFile(this List<PersonModel> models, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (PersonModel model in models)
            {
                lines.Add($"{ model.Id },{model.FirstName },{model.LastName},{model.EmailAddress},{model.CellphoneNumber}");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveToTeamFile(this List<TeamModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (TeamModel t in models)
            {
                lines.Add($"{ t.Id },{t.TeamName },{ConvertPeopleListToString(t.TeamMembers)}");
                
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveToTournamentFile(this List<TournamentModel> models, string fileName)
        {
            // Id = 0
            // Tournament Name = 1
            // EntryFee = 2
            // TournamenetEntries = 3
            // TournamentPrizes = 4
            // Rounds = 5 
            // Rounds look like  id^id^id|id^id^id|id^id^id

            List<string> lines = new List<string>();

            foreach (TournamentModel tm in models)
            {
                // Observe the $@ that allows you to break code to new lines otherwise with just $ it will give error.
                lines.Add($@"{ tm.Id },
                        { tm.TournamentName },
                        { tm.EntryFee },
                        { ConvertTeamListToString(tm.EntreredTeams) },
                        { ConvertPrizeListToString(tm.Prizes) },
                        { ConvertRoundListToString(tm.Rounds) }");

            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        private static string ConvertRoundListToString(List<List<MatchupModel>> rounds)
        {
            string output = "";

            if (rounds.Count == 0)
            {
                return output;
            }

            // After each Id there is going to be a pipe
            foreach (List<MatchupModel> r in rounds)
            {
                output += $"{ConvertPrivateMatchupListToString(r)}|";
            }
            // Remove the trailing pipe

            output = output.Substring(0, output.Length - 1);

            return output;
        }

        private static string ConvertPrivateMatchupListToString(List<MatchupModel> matchups)
        {
            string output = "";

            if (matchups.Count == 0)
            {
                return output;
            }

            // After each Id there is going to be a pipe
            foreach (MatchupModel m in matchups)
            {
                output += $"{m.Id}^";
            }
            // Remove the trailing pipe

            output = output.Substring(0, output.Length - 1);

            return output;
        }

        private static string ConvertPrizeListToString(List<PrizeModel> prizes)
        {
            string output = "";
            if (prizes.Count == 0)
            {
                return output;
            }

            // After each Id there is going to be a pipe
            foreach (PrizeModel p in prizes)
            {
                output += $"{p.Id}|";
            }
            // Remove the trailing pipe

            output = output.Substring(0, output.Length - 1);

            return output;
        }

        private static string ConvertTeamListToString(List<TeamModel> teams)
        {
            string output = "";
            if (teams.Count == 0)
            {
                return output;
            }

            // After each Id there is going to be a pipe
            foreach (TeamModel t in teams)
            {
                output += $"{t.Id}|";
            }
            // Remove the trailing pipe

            output = output.Substring(0, output.Length - 1);

            return output;
        }

        private static string ConvertPeopleListToString(List<PersonModel> people)
        {
            string output ="";

            if(people.Count == 0)
            {
                return output;
            }
            // After each Id there is going to be a pipe
            foreach (PersonModel p in people)
            {
                output += $"{p.Id}|";
            }
            // Remove the trailing pipe

            output = output.Substring(0, output.Length - 1);

            return output;
        }

        public static List<TeamModel> ConvertToTeamModels(this List<string> lines,string PeopleFileName)
        {
            //Id,Team Name, list of ids separated by pipe
            //1,Saurabh's Team, 1|3|4
            List<TeamModel> output = new List<TeamModel>();
            List<PersonModel> people = PeopleFileName.FullFilePath().LoadFile().ConvertToPersonModels();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                TeamModel t = new TeamModel();
                t.Id = int.Parse(cols[0]);
                t.TeamName = cols[1];

                string[] personIds = cols[2].Split('|');

                foreach (string id in personIds)
                {
                    t.TeamMembers.Add(people.Where(x => x.Id == int.Parse(id)).First());
                }

                output.Add(t);
            }

            return output;
        }

        public static List<TournamentModel> ConvertToTournamentModels(this List<string> lines,string TeamFile,string PeopleFile,string PrizeFile)
        {
            // Tournament File will be saved as 
            // Id,TournamentName,EntryFee,(teamId1|teamId2|.. - Entered Teams),(prizeId1|prizeId2|... - Prizes),(Rounds(list of lists) - id^id^id(list1) | id^id^id(list2) | id^id^id(list3)|....)
            // Index position in the line
            // Id = 0
            // Tournament Name = 1
            // EntryFee = 2
            // TournamenetEntries = 3
            // TournamentPrizes = 4
            // Rounds = 5

            List<TournamentModel> output = new List<TournamentModel>();
            List<TeamModel> teams = TeamFile.FullFilePath().LoadFile().ConvertToTeamModels(PeopleFile);
            List<PrizeModel> prizes = PrizeFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                TournamentModel tm = new TournamentModel();
                tm.Id = int.Parse(cols[0]);
                tm.TournamentName = cols[1];
                tm.EntryFee = decimal.Parse(cols[2]);

                string[] teamIds = cols[3].Split('|');
                foreach (string id in teamIds)
                {
                    tm.EntreredTeams.Add(teams.Where(x => x.Id == int.Parse(id)).First());
                }

                string[] prizeIds = cols[4].Split('|');
                foreach (string id in prizeIds)
                {
                    tm.Prizes.Add(prizes.Where(x => x.Id == int.Parse(id)).First());
                }

                // TODO : Capture Rounds information

                output.Add(tm);
            }
            return output;

        }
    }
}
