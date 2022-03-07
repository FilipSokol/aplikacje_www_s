using System;
using System.Collections.Generic;

namespace SchoolRegister.Model.DataModels
{
    class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        IList<SubjectGroup> SubjectGroups { get; set; }
        public Teacher Teacher { get; set; }
        public int? TeacherId { get; set; }
        public IList<Grade> Grades {get; set; }
        public Subject() { }
    }
}