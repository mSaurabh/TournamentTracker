using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrackerLibrary.Models;

namespace MVCUI.Models
{
    public class TeamMVCModel
    {
        [Display(Name = "Team Name")]
        [StringLength(100, MinimumLength = 3)]
        [Required]
        [RegularExpression(@"^([a-zA-Z0-9 \.\&\'\-]+)$", ErrorMessage = "Invalid Given Name")]
        /// <summary>
        /// Represents the Team Name
        /// </summary>
        public string TeamName { get; set; }

        [Display(Name = "Team Member List")]
        [Required]
        /// <summary>
        /// Represents the Team Members 
        /// </summary>
        public List<SelectListItem> TeamMembers { get; set; } = new List<SelectListItem>();

        public List<String> SelectedTeamMembers { get; set; } = new List<string>();
        
    }
}