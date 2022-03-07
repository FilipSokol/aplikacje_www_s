using System;
using System.Collections.Generic;

namespace SchoolRegister.Model.DataModels
{
    public class Subject
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description {get; set; }
        public IList<SubjectGroup> SubjectGroups { get; set; }
        public Teacher Teacher { get; set; }
        public int? TeacherId { get; set; }
        public IList<Grade> Grades { get; set; }
        public Subject() {}
    }
}