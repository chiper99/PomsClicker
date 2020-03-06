using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PC.Models
{
    public class RegisterUserModel
    {
        public string name { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string email { get; set; }
    }
}
