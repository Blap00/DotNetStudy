using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetMvCApp.Models
{
    public class LoginModel
    {
        public String Username { get; set; }

        public String Password { get; set; }



        // Getters & Setters

        //Username
        public String getUsername()
        {
            return this.Username;
        }
        public String setUsername(String username)
        {
            return this.Username = username;
        }

        //Password
        public String getPassword()
        {
            return this.Password;
        }
        public String setPassword(String password)
        {
            return this.Password = password;
        }



    }
}
