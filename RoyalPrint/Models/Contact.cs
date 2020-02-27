using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RoyalPrint.Models
{
    public class Contact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ContactUsID { get; set; }
        [Required(ErrorMessage = "First Name is required")]
        [Display(Name = "Full Name")]
        [StringLength(50, MinimumLength = 3)]
        public string FullName { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Phone Number Required!")]
        /*[RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",ErrorMessage = "Entered phone format is not valid.")]*/
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        [Required]
        public string Message { get; set; }
        public DateTime Time { get; set; }
        public byte IsRead { get; set; }

    }
}