namespace SchoolRegister.Model.DataModels
{
    public class SubjectGroups
    {
        public Subject Subject { get; set; }
        public int SubjectId { get; set; }

        public Group Group { get; set; }
        public int GroupId { get; set; }
        public SubjectGroups(){}
    }
}