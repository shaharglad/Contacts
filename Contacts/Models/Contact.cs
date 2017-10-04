using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Contacts.Models
{
    public class Contact
    {
        public int ID { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "This is a required filed")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "Please enter a valid string")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$", ErrorMessage = "Please enter a valid name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "This is a required filed")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

    }
}