using Microsoft.AspNetCore.Identity;
using System;
using System.Collections;
using System.Collections.Generic;
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