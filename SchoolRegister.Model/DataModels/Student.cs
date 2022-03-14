using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRegister.Model.DataModels
{
    public class Student : User
    {
        public Group Group { get; set; }
        public int? GroupId { get; set; }
        public IList<Grade> Grades { get; set; }
        public Parent Parent { get; set; }
        public int? ParentId { get; set; }
        public double AverageGrade => Grades.Average(x => (double)x.GradeValue);
        public IDictionary<string, double> AverageGradePerSubject { 
            get
            {
                IDictionary<string, double> averageGradePerSubject = new Dictionary<string, double>();

                var grouped = Grades.GroupBy(x => x.Subject.Name).ToList();

                grouped.ForEach(x =>
                {
                    averageGradePerSubject.Add(x.Key, Grades.Where(y => y.Subject.Name == x.Key).Average(z => (double)z.GradeValue));
                });

                return averageGradePerSubject;
            }
        }
        public IDictionary<string, List<GradeScale>> GradesPerSubject { 
            get
            {
                IDictionary<string, List<GradeScale>> gradePerSubject = new Dictionary<string, List<GradeScale>>();

                var grouped = Grades.GroupBy(x => x.Subject.Name).ToList();

                grouped.ForEach(x =>
                {
                    gradePerSubject.Add(x.Key, Grades.Where(y => y.Subject.Name == x.Key).Select(z => z.GradeValue).ToList());
                });

                return gradePerSubject;
            }
        }
        public Student() { }
    }
}
