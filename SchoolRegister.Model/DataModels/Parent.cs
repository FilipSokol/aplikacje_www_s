using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic; 

namespace SchoolRegister.Model.DataModels{
    public class Parent{
        public List<Student> Students { get; set; } 

        public Parent() {}
    }
}