using System.Collections.Generic;

namespace SchoolRegister.Model.DataModels
{
    public class Student
    {
        public Student() {}
        public Group Group {get; set;}
        public int? GroupId {get; set;}
        public IList<Grade> Grades {get; set;}
        public Parent Parent {get; set;}
        public int? ParentId {get; set;}
        public double AvergeGrade {get;}
        public IDictionary<string, double> AverageGradePerSubject {get;}
        public IDictionary<string, List<GradeScale>> GradesPerSubject {get;}
    }
}