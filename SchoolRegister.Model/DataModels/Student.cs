using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolRegister.Model.DataModels
{
    class Student : User
    {
        public Group Group { get; set; }
        public int? GroupId { get; set; }
        public IList<Grade> Grades { get; set; }
        public Parent Parent { get; set; }
        public int? ParentId { get; set; }
        double AveragedGrade => Grades.Average(x => (int)x.GradeValue);

        public IDictionary<string, double> AverageGradePerSubject => Grades
            .GroupBy(z => z.Subject.Name)
            .Select(s => s)
            .ToDictionary(x => x.Key, x => x.Average(x => (int)x.GradeValue));
            
        public IDictionary<string, List<GradeScale>> GradesPerSubject => Grades
            .GroupBy(z => z.Subject.Name)
            .Select(s => s)
            .ToDictionary(x => x.Key, x => x.Select(x=>x.GradeValue).ToList());

        public Student() { }
    }

    
}
