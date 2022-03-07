using Microsoft.AspNetCore.Identity;
using System;
using System.Collections;
namespace SchoolRegister.Model.DataModels
{
    public class RoleValue
    {
        enum role
        {
            User = 0,
            Student = 1,
            Parent = 2,
            Teacher = 3,
            Admin = 4
        }
    }
}