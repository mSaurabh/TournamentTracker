using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Display(Name = "Given Name")]
        [StringLength(100,MinimumLength =2)]
        [Required]
        [RegularExpression(@"^([a-zA-Z0-9 \.\&\'\-]+)$", ErrorMessage = "Invalid Given Name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Represents the Last Name of the Person.
        /// </summary>
        [Display(Name = "Last Name")]
        [StringLength(100, MinimumLength = 2)]
        [Required]
        [RegularExpression(@"^([a-zA-Z0-9 \.\&\'\-]+)$", ErrorMessage = "Invalid Last Name")]
        public string LastName { get; set; }

        /// <summary>
        /// Represents the Primary Email Address of the Person.
        /// </summary>
        [Display(Name = "Email Address")]
        [StringLength(200, MinimumLength = 6)]
        [Required]
        [RegularExpression("^[a-z0-9_\\+-]+(\\.[a-z0-9_\\+-]+)*@[a-z0-9-]+(\\.[a-z0-9]+)*\\.([a-z]{2,4})$", ErrorMessage = "Invalid email format.")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Represents the Primary Cell Phone Number of the Person.
        /// </summary>
        [Display(Name = "Cellphone Number")]
        [StringLength(20, MinimumLength = 10)]
        [Required]
        [RegularExpression(@"([0-9 \-]+)$", ErrorMessage = "Invalid CellPhone Number")]
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
