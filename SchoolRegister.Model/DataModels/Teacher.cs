using System;

namespace SchoolRegister.Model
{
    public class Teacher
    {
        public IList<Subject> Subjects { get; set; }
        public string Title { get; set; }

    }
}
