using System.Collections.Generic;

namespace SchoolRegister.Model.DataModels
{
    public class Group
    {
        public int Id{ get; set; }
        public string Name{ get; set; }
        public IList<Student> Students { get; set; }
        public IList<Subject> Subjects { get; set; }
    }
}