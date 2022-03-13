using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRegister.Model.DataModels
{
    public class Group
    {
        public int id { get; set; }
        public string name { get; set; }
        public IList<Student> students { get; set; }
        public IList<SubjectGroup> subjectGroups { get; set; }
        public Group() { }
    }
}
