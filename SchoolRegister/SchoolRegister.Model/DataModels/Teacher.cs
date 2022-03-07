using System.Collections.Generic;

namespace SchoolRegister.Model.DataModels
{
    public class Teacher : User
    {
        public string Title { get; set; }
        public IList<Subject> Subjects { get; set; }
        public Teacher()
        {
            
        }
    }
}