using Microsoft.AspNetCore.Identity;
using System;

namespace SchoolRegister.Model.DataModels
{
    public class User : IdentityUser<int>
    {
        public string firstName {get; set; }
        public string lastName {get; set; }

        public DateTime registrationName {get; set; }

        void user()
        {

        }
    }
}