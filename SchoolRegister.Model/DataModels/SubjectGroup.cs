using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRegister.Model.DataModels
{
    public class SubjectGroup
    {
        public Subject subject { get; set; }
        public int subjectId { get; set; }
        public int groupId { get; set; }

    }
}
