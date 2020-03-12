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
        public double PricePercentage { get; set; }

    }
}
