using System;
using System.Collections.Generic;

namespace SchoolRegister.Model.DataModels
{
    class Parent : User
    {
        public IList<Student> Students { get; set; }
        public Parent() { }
    }
}