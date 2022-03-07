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

        public IDictionary<string, double> AverageGradePerSubject 
        {
            get 
            { 
                var avarageGradePerSubject = new Dictionary<string, double>();

                var Grp = Grades.GroupBy(N =>N.Subject.Name).ToList();

                Grp.ForEach(x =>
                {
                    avarageGradePerSubject.Add(x.Key, Grades.Where(y => y.Subject.Name == x.Key).Average(G => (int)G.GradeValue));
                });
                return avarageGradePerSubject;
            }
        }

        public IDictionary<string, List<GradeScale>> GradesPerSubject { get;}

        public Student()
        {

        }

    }
}