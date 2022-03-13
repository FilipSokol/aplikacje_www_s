using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRegister.Model.DataModels
{
    public class Student
    {
        public Group group { get; set; }
        public int? groupId { get; set; }
        public IList<Grade> grades { get; set; }
        public Parent parent { get; set; }
        public int? parentId { get; set; }
        public double avarageGrade {
            get {
                return grades.Average(x=>(double)x.gradeValue);
            }
        }

        public IDictionary<string, double> avarageGradePerSubject
        {
            get
            {
                IDictionary<string, double> avarage = new Dictionary<string, double>();

                var group = grades.GroupBy(x => x.subject.name);

                foreach (var i in group)
                {
                    avarage.Add(i.Key, grades.Where(x => x.subject.name == i.Key).Average(y => (double)y.gradeValue));
                }
                return avarage;
            }
        }

        public IDictionary<string, IList<GradeScale>> gradesPerSubject
        {
            get
            {
                IDictionary<string, IList<GradeScale>> grPerSubject = new Dictionary<string, IList<GradeScale>>();

                var group = grades.GroupBy(x => x.subject.name);

                foreach(var i in group)
                {
                    grPerSubject.Add(i.Key, grades.Where(x => x.subject.name == i.Key).Select(y => y.gradeValue).ToList());
                }

                return grPerSubject;
            }
        }
        public Student() { }
    }
}
