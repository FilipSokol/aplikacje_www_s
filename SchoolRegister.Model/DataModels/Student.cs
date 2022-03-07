using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolRegister.Model.DataModels
{
    public class Student : User
    {
        public Group Group {get;set;}
        public int? GroupId {get;set;}
        public IList<Grade> Grades {get;set;}
        public Parent Parent {get;set;}
        public int? ParentId {get;set;}
        public Student(){}
        public double AverageGrade =>
                Grades.Average(e => (int)e.GradeValue);
        
        public IDictionary<string,double> AverageGradePerSubject =>
                Grades.GroupBy(grade => grade.Subject.Name)
                .Select(e => new {subjname = e.Key, Avg = e.Average(g => (int)g.GradeValue)})
                .ToDictionary(e => e.subjname, e => e.Avg);
        public IDictionary<string,List<GradeScale>> GradesPerSubject =>
                Grades.GroupBy(grade => grade.Subject.Name)
                .Select(e => new {subjname = e.Key, lista = e.Select(g => g.GradeValue).ToList()})
                .ToDictionary(e => e.subjname, e => e.lista);
    }
}