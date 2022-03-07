using System;
using System.Collections.Generic;

namespace SchoolRegister.Model.DataModels
{
    class Group
    {
        public int Id { get; set; }
        public string Name {get; set; }
        public IList<SubjectGroup> SubjectGroups { get; set; }
        public Group(){ }
    }
}