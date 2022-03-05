using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
namespace SchoolRegister.Model.DataModels
{
    public class Student : User
    {
        public SubjectGroup Group { get; set; }
        public int? GroupId { get; set; }
        public List<Grade> Grades { get; set; }
        public Parent Parent { get; set; }
        public int? ParentId { get; set; }
        public double AverageGrade { get; }
        public Dictionary<string, double> AverageGradePerSubject { get; }
        public Dictionary<string, List<GradeScale>> GradePerSubject { get; }
    }

}