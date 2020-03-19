using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";
        private const string PeopleFile = "PersonModels.csv";
        public PersonModel CreatePerson(PersonModel model)
        {
            // Load the file if one exists
            // Convert the data in file to Person Models .. so each line represents a person and the info is comma separated
            List<PersonModel> people = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

            // Find MAX Id based on the file read, if file is empty then assign id = 1
            int currentId = 1;

            if(people.Count > 0)
            {
                // Read this as Order the list of People Model by id in desc. order 
                // and grab the id of the first model.
                currentId = people.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            // Add the new Person data to model 
            people.Add(model);

            // Convert the List of Person Models to a List<string>
            // Save the List<string> to the text file
            people.SaveToPeopleFile(PeopleFile);

            return model;

        }

        /// <summary>
        /// Saves a new prize to the database
        /// </summary>
        /// <param name="model">The prize information.</param>
        /// <returns>The prize information, including the unique identifier.</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            // Load the file if one exists
            // Convert the data in file to Person Model's List -> so each line represents a person and the info is comma separated
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            // Find MAX Id based on the file read, if file is empty then assign id = 1
            int currentId = 1;

            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            // Add the new record with the new ID (max + 1)
            prizes.Add(model);

            // Convert the Prizes to a List<string>
            // Save the List<string> to the text file
            prizes.SaveToPrizeFile(PrizesFile);

            return model;
            
        }
    }
}
