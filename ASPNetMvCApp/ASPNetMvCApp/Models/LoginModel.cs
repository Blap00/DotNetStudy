using ASPNetMvCApp.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetMvCApp.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Please, enter a Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please, enter an Username")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Please, enter a Password")]
        public string Password { get; set; }
        [Compare("Password",ErrorMessage = "Please, Password must match")]
        public string ConfirmPassword{ get; set; }
        [Required(ErrorMessage = "Please, enter a contact number")]
        [RegularExpression("^[2,56]\\d{9}$", ErrorMessage = "Please, enter a correct number")]
        public string Contact { get; set; }
        [ValidateCheckbox(ErrorMessage = "Please, accept terms and services")]
        public bool Terms { get; set; }

    }
}
