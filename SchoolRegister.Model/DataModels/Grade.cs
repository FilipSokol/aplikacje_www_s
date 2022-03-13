using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRegister.Model.DataModels
{
    public class Grade
    {
        public DateTime DateOfIssue { get; set; }
        public GradeScale gradeValue { get; set; }
        public Subject subject { get; set; }
        public int subjectId { get; set; }
        public int studentID { get; set; }
        public Student student { get; set; }
        public Grade() { }
    }
}
