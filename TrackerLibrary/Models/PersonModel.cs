﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents one person.
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// The unique identifier for the person.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represents the First Name of the Person.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Represents the Last Name of the Person.
        /// </summary>
        public string LastName { get; set; }
        
        /// <summary>
        /// Represents the Primary Email Address of the Person.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Represents the Primary Cell Phone Number of the Person.
        /// </summary>
        public string CellphoneNumber { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
