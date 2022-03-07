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
        public double AverageGrade => Grades.Average(x => (int)x.GradeValue);
        // { get 
        //     {
        //         return Grades.Average(x => (int)x.GradeValue);
        //     } 
        // }
        public IDictionary<string, double> AverageGradePerSubject 
        {
            get 
            { 
                IDictionary<string, double> oceny = new Dictionary<string, double>();
                var grouped = Grades.GroupBy(x => x.Subject.Name).ToList();
                grouped.ForEach(subject => 
                { 
                    oceny.Add(subject.Key, Grades.Where(y => y.Subject.Name == subject.Key).Average(z => (double)z.GradeValue)); 
                });
                return oceny;
            }
        }
        public IDictionary<string, List<GradeScale>> GradesPerSubject 
        {
            get
            {
                IDictionary<string, List<GradeScale>> oceny = new Dictionary<string, List<GradeScale>>();
                var grouped = Grades.GroupBy(x => x.Subject.Name).ToList();
                grouped.ForEach(x =>
                {
                    oceny.Add(x.Key, Grades.Where(y => y.Subject.Name == x.Key).Select(c => c.GradeValue).ToList());
                });
                return oceny;
            }
        }
        public Student()
        { }
    }
}
