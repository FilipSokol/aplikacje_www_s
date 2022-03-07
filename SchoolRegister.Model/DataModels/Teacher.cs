using System;
using System.Collections.Generic;

namespace SchoolRegister.Model.DataModels
{
    class Teacher
    {
        public IList<Subject> Subjects { get; set; }
        public string Title { get; set; }
        public Teacher() { }
    }
}