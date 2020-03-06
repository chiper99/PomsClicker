using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PC.Models
{
    public class RegisterUserModel
    {
        public string name;

        [Required]
        [DataType(DataType.Password)]
        public string password;

        [Required]
        [Display(Name = "Email")]
        public string email;
    }
}
