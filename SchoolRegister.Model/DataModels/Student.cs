public class Student : User
{
    public Group group{ get; set;}
    public int? GroupId { get; set; }

    public IList<Grade> Grades {get; set; }
    public Parent parent { get; set; }
    public int? ParentId {get; set;}

    public Student(){}
}