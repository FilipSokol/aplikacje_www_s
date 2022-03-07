using Microsoft.AspNetCore.Identity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace SchoolRegister.Model.DataModels
{
    public class Student : User
    {
        public Group Group { get; set; }
        public int? GroupId { get; set; }
        public IList<Grade> Grades { get; set;}
        public Parent Parent { get; set; }
        public int? ParentId { get; set; }

        [NotMapped]
        public double AverageGrade { 
            get
            {
                double _averageGrade = 0;
                
                foreach (Grade grade in Grades)
                    _averageGrade += (double)grade.GradeValue;

                _averageGrade /= Grades.Count;

                return _averageGrade;
            }
        }
        [NotMapped]
        public IDictionary<string, double> AverageGradePerSubject 
        { 
            get
            {
                Dictionary<string, double> _averageGradePerSubject = new Dictionary<string, double>();

                foreach (KeyValuePair<string, List<GradeScale>> grades in GradesPerSubject)
                    _averageGradePerSubject.Add(grades.Key, grades.Value.Cast<int>().Average());
                    

                return _averageGradePerSubject;
            }
        }

        [NotMapped]
        public IDictionary<string, List<GradeScale>> GradesPerSubject => Grades == null ? new Dictionary<string, List<GradeScale>>() :
            Grades.GroupBy(g => g.Subject.Name)
            .Select(g => new { SubjectName = g.Key, GradeList = g.Select(x => x.GradeValue).ToList() })
            .ToDictionary(x => x.SubjectName, x => x.GradeList);
        
    }
}
