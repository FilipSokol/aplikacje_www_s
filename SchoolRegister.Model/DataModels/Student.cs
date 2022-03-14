using System.Collections.Generic;
using System.Linq;

namespace SchoolRegister.Model.DataModels
{
    public class Student
    {
        public Group Group { get; set; }
        public int? GroupId { get; set; }

        public IList<Grade> Grades { get; set; }

        public Parent Parent { get; set; }
        public int? ParentId { get; set; }

        public double AverageGrade
        {
            get
            {
                return Grades.Average(grade => (double)grade.GradeValue);
            }
        }
        public IDictionary<string, double> AverageGradePerSubject
        {
            get
            {
                return Grades.GroupBy(grade => grade.Subject.Name)
                .Select(g => new
                {
                    SubName = g.Key,
                    AverageGrade = g.Average(grade => (double)grade.GradeValue)
                }
            )
            .ToDictionary(g => g.SubName, global => global.AverageGrade);
            }
        }
        public IDictionary<string, List<GradeScale>> GradesPerSubject 
        {
            get
            {
                return Grades.GroupBy(grade => grade.Subject.Name)
                .Select(g => new
                {
                    SubName = g.Key,
                    Grades = g.Select(gv => gv.GradeValue).ToList()
                }
            )
            .ToDictionary(g => g.SubName, g => g.Grades);
            }
        }

        public Student() { }
    }
}