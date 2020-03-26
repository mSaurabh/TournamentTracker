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
    }
}
