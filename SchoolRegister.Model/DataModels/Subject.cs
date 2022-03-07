public class Subject
{
    public int id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public IList<SubjectGroup> SubjectGroups { get; set; }
    public Teacher Teacher { get; set; }
    public int? TeacherId { get; set; }
    public IList<Grade> Grades { get; set; }

    public Subject() { }
}