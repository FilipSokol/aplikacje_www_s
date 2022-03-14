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

        public double AverageGrade => Grades.Average(G => (int)G.GradeValue);
        //public double AverageGrade 
        //{
        //    get
        //    {
        //        return Grades.Average(G=> (int)G.GradeValue);
        //    }

        //}

      
        public IDictionary<string, double> AverageGradePerSubject => Grades
                    .GroupBy(x => x.Subject.Name)
                    .Select(x => new { SubjectName = x.Key, SubjectAverage = x.Average(x => (int)x.GradeValue) })
                    .ToDictionary(x => x.SubjectName, x => x.SubjectAverage);

        public IDictionary<string, List<GradeScale>> GradesPerSubject => Grades
                    .GroupBy(x => x.Subject.Name)
                    .Select(x => new { SubjectName = x.Key, Grades = x.Select(x => x.GradeValue).ToList() })
                    .ToDictionary(x => x.SubjectName, x => x.Grades);

        public Student()
        {

        }

    }
}