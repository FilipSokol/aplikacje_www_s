using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolRegister.Model.DataModels
{
    class Student : User
    {
        public Group Group { get; set; }
        public int? GroupId { get; set; }
        public IList<Grade> Grades { get; set; }
        public Parent Parent { get; set; }
        public int? ParentId { get; set; }
        public double AverageGrade => Grades.Average(item => (int)item.GradeValue);
        public IDictionary<string, double> AverageGradePerSubject => Grades.GroupBy(name => name.Subject.Name).
        public IDictionary<string, List<GradeScale>> GradesPerSubject { get; }
        public Student() { }
    }
}