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
        public int ParentId { get; set; }
        public double AverageGrade
        {
            get 
            { 
                return Grades.Average(x=>(double)x.GradeValue); 
            }
        }
        
        public IDictionary<string,double> AverageGradePerSubject
        {
            get
            {
                IDictionary<string,double> avgGradePerSubject = new Dictionary<string,double>();

                //var namesOfSubjects = Grades.Select(x => x.Subject.Name).Distinct().ToList();

                //foreach (var subName in namesOfSubjects)
                //{
                //    avgGradePerSubject.Add(subName, Grades.Where(x => x.Subject.Name == subName).Average(x =>(double)x.GradeValue));
                //}

                var grouped = Grades.GroupBy(x => x.Subject.Name).ToList();

                grouped.ForEach(x =>
                {
                    avgGradePerSubject.Add(x.Key, Grades.Where(y => y.Subject.Name == x.Key).Average(z => (double)z.GradeValue));
                });
                
                return avgGradePerSubject;
            }
        }

        public IDictionary<string,List<GradeScale>> GradesPerSubject
        {
            get
            {
                IDictionary<string,List<GradeScale>> gradesPerSubject = new Dictionary<string,List<GradeScale>>();

                //var namesOfSubjects = Grades.Select(x => x.Subject.Name).Distinct().ToList();

                //foreach (var subName in namesOfSubjects)
                //{
                //    var listOfGrades = Grades.Where(x=>x.Subject.Name == subName).Select(x=>x.GradeValue).ToList();
                //    gradesPerSubject.Add(subName,listOfGrades);
                //}

                var grouped = Grades.GroupBy(x => x.Subject.Name).ToList();

                grouped.ForEach(x =>
                {
                    gradesPerSubject.Add(x.Key, Grades.Where(y => y.Subject.Name == x.Key).Select(c => c.GradeValue).ToList());
                });

                return gradesPerSubject;
            }
        }

        public Student()
        {
            
        }
    }
}