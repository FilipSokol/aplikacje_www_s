using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace SchoolRegister.Model.DataModels
{
    public class Subject
    {
        public int id {get; set; }
        public string name {get; set; }
        public string Description {get; set; }
        public IList<SubjectGroup> subjectGroups { get; set; }
        public Teacher teacher {get; set; }
        public int? teacherId {get; set; }
        public IList<Grade> grades { get; set; }


    } 

}