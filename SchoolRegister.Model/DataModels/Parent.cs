using System.Collections.Generic;

namespace SchoolRegister.Model.DataModels
{
    public class Parent
    {
        public Parent() {}
        public IList<Student> Student {get; set;}
    }
}