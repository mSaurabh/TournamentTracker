using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// Represents the Tournament Name
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Represents the Entry Fee for tournament
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// Represents the Teams as a part of this tournament
        /// </summary>
        public List<TeamModel> EntreredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// Represents the Prizes related to this Tournament.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// Represents the rounds for the tournament.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
