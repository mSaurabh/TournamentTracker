﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {
        /// <summary>
        /// Represents unique identifier for Team
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represents the Team Members 
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        /// <summary>
        /// Represents the Team Name
        /// </summary>
        public string TeamName { get; set; }
    }
}