using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// The unique identifier for the prize.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represents the Place Number Ex: 1st,2nd,3rd as 1,2,3 and so on..
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Represents the PlaceNumber in description form Ex: Runner up, Champion and so on...
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Represents the Prize Amount for the PlaceNumber
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Represents the Price % for the PlaceNumber.
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount , string prizePercentage)
        {
            this.PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            this.PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            this.PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            this.PrizePercentage = prizePercentageValue;

        }
    }
}
