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
        public virtual Group Group { get; set; }
        [ForeignKey("Group")]
        public int? GroupId { get; set; }
        public virtual IList<Grade> Grades { get; set;}
        public virtual Parent Parent { get; set; }

        [ForeignKey("Parent")]
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
        public IDictionary<string, List<GradeScale>> GradesPerSubject 
        {
            get
            {
                Dictionary<string, List<GradeScale>> _gradePerSubject = new Dictionary<string, List<GradeScale>>();

                //foreach (Grade grades in Grades)
                    //_gradePerSubject.Add(grades.Subject.Name, );

                return _gradePerSubject;
            }           
        }

    }
}
// Where(t => t.SubjectId == grades.SubjectId)