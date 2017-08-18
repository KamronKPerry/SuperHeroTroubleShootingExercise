using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuperHeroInc.UI.Models
{
    public class ContactViewModel
    {
        [Required(ErrorMessage = "*Required")]
        [Display(Name = "Your Name")]
        [StringLength(20, ErrorMessage ="*Max length 20 characters")]
        public string Name { get; set; }
        [Required(ErrorMessage = "*Required")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Enter a valid Email")]
        [Display(Name = "Your Email")]
        public string Email { get; set; }
        [StringLength(50, ErrorMessage ="*Max length 50 characters")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "*Required")]
        [Display(Name = "Comment Here")]
        public string Comment { get; set; }
    }
}