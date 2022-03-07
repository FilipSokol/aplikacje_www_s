using System;

namespace SchoolRegister.Model.DataModels
{
    public class Grade{
        
        public int SubjectId { get; set; }
        public int StudentId { get; set; }
        public DateTime DateOfIssue { get; set; }
        public GradeScale GradeValue { get; set; }
    }    
}