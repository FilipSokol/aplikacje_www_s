using System;
using System.Collections.Generic;

namespace SchoolRegister.Model.DataModels

{
    public class Student:User
    
    {
        public double AverageGrade { get; }
        public Group Group { get; set; }
        public int? GroupId { get; set; }
        public IList<Grade> Grades { get; set; }
    }
}