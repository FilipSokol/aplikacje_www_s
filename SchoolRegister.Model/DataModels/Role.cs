using System;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRegister.Model.DataModels
{
    public class Role : IdentityRole<int>
    {
        public RoleValue roleValue { get; set; }
        public Role() { }
        public Role(string name, RoleValue roleValue)
        {
            this.roleValue = roleValue;
        }

    }
}
