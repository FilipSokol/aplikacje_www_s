﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRegister.Model.DataModels
{
    public class Teacher:User
    {
        public string title { get; set; }
        public IList<Subject> subjects { get; set; }
        public Teacher() { }
    }
}
