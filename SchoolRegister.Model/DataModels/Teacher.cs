using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace SchoolRegister.Model.DataModels
    {
    public class Teacher
    {
        public IList<Subject> Subject { get; set; } 
    }
}
