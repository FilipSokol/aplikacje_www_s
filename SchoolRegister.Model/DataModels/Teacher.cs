using System;
using System.Collections.ICollection;

namespace SchoolRegister.Model.DataModels
{
    public class Teacher : User
    {
        public IList<Subject> Subjects {get;set;}
        public string Title{get;set;}
        public Teacher(){}

    }
}