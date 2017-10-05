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
        public string Name { get; set; }

        [Required(ErrorMessage = "This is a required filed")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        [RegularExpression("[0-9]", ErrorMessage = "Please enter a valid phone number")]
        public string PhoneNumber { get; set; }

    }
}