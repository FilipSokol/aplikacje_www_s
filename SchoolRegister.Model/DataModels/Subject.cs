﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRegister.Model.DataModels
{
    public class Subject
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public IList<SubjectGroup> subjectGroups { get; set; }
        public Teacher teacher { get; set; }
        public int? teacherid { get; set; }
        public IList<Grade> grades { get; set; }
        public Subject() { }

        
        
    }
}
