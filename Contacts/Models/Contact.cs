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
        
        public string Name { get; set; }

        [Required(ErrorMessage = "This is a required filed")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        
        public string PhoneNumber { get; set; }

    }
}