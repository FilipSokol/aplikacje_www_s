using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;

namespace SchoolRegister.Model.DataModels {

    public class Teacher : User {
        public Teacher() { }
        public string Title { get; set; }
        public IList<Subject> Subjects { get; set; }

    }
}