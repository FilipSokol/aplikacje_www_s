using Microsoft.AspNetCore.Identity;
using System;
using System.Collections;
namespace SchoolRegister.Model.DataModels
{
    public class Teacher : User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IList<SubjectGroup> SubjectGroup { get; set; }
        public Teacher Teacher { get; set; }
        public int? TeacherId { get; set; }
        public IList<Grade> Grades { get; set; }

    }
}