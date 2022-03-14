using System.Collections.Generic;
using System.Linq;

namespace SchoolRegister.Model.DataModels
{
    public class Student
    {
        public Group Group{ get; set; }
        public int GroupId{ get; set; }
        public IList<Grade> Grades{ get; set; }
        public Parent Parent{ get; set; }
        public int ParentId{ get; set; }
        public double AverageGrade => Grades.Average(x => (int)x.GradeValue);
        public IDictionary<string, double> AverageGradePerSubject{
            get => Grades.GroupBy(x => x.Subject.Name, x =>
                (int)x.GradeValue, (name, val) =>
                new {Name = name, Avg = val.Average()}).ToDictionary(x => x.Name, x => x.Avg);
        }
        public IDictionary<string, double> AverageGradePerSubject1{
            get => Grades.GroupBy(x => x.Subject).
                Select(x => 
                new {SubName = x.Key.Name, Avg = x.Average(y => (int)y.GradeValue)}).
                ToDictionary(x => x.SubName, x => x.Avg); 
        }
        public IDictionary<string, List<GradeScale>> GradesPerSubject{
            get => Grades.GroupBy(x => x.Subject).
                Select(x => new 
                {SubName = x.Key.Name, Avg = x.Select(y => y.GradeValue).ToList()}).
                ToDictionary(x => x.SubName, x => x.Avg);
        }
        public IDictionary<string, List<GradeScale>> GradesPerSubject1{
            get => Grades.GroupBy(x => x.Subject.Name, x =>
                x.GradeValue, (name, val) =>
                new {Name = name, Avg = val.ToList()}).ToDictionary(x => x.Name, x => x.Avg);
        }
    }
}