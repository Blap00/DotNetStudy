using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetMvCApp.Models
{
    public class LoginModel
    {
        public string Name { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword{ get; set; }
        public string Contact { get; set; }

        public bool Terms { get; set; }

    }
}
