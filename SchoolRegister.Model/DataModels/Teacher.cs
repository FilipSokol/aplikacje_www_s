using System.Collections.Generic;

namespace SchoolRegister.Model.DataModels
{
    public class Teacher : User
    {
        public Teacher(){}
        public IList<Subject> Subjects {get; set;}
        public string Title {get; set;}

    }
}