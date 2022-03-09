using System.Collections.Generic;
using System.Linq;

namespace SchoolRegister.Model.DataModels
{
    public class Student : User
    {
        public Group Group { get; set; }
        public int? GroupId { get; set; }
        public IList<Grade> Grades { get; set; }
        public Parent Parent { get; set; }
        public int? ParentId { get; set; }
        public double AverageGrade => Grades.Average(x => (int)x.GradeValue);
        public IDictionary<string, double> AverageGradePerSubject =>
            Grades.GroupBy(x => x.Subject.Name)
            .Select(y => new { SubjectName = y.Key, SubjectAverage = Grades.Average(x => (int)x.GradeValue) })
            .ToDictionary(z => z.SubjectName, v => v.SubjectAverage);
        public IDictionary<string, List<GradeScale>> GradesPerSubject =>
            Grades.GroupBy(x => x.Subject.Name)
            .Select(y => new { SubjectName = y.Key, Grades = y.Select(z => z.GradeValue).ToList() })
            .ToDictionary(v => v.SubjectName, b => b.Grades);
        public Student()
        {

        }
    }
       
    
}
