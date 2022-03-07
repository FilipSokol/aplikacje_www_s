using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace SchoolRegister.Model.DataModels
{
    public class Subject
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public IList<SubjectGroup> SubjectGroups { get; set; }

        public Teacher Teacher { get; set; }
    }
}