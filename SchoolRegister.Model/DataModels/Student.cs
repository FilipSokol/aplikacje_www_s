using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace SchoolRegister.Model.DataModels
{
    public class Student : User
    {
        public Group group {get; set; }
        public int? groupId {get; set; }
        public IList<Grade> grades { get; set; }
        public Parent parent {get; set; }
        public int? parentId {get; set; }
        public double AvarageGrade {get; set; }
        public IDictionary<string, double> averageGradePerSubject { get; }
        public IDictionary<string, List<GradeScale>> gradePerSubject { get; }


    }
}