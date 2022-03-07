using System;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace SchoolRegister.Model.DataModels
{
    public class Role : IdentityRole<int>
    {
        public RoleValue RoleValue { get;set;}
        public Role(){}
        public Role(string name, RoleValue roleValue)
        {
            RoleValue = roleValue;

        }
    }
}