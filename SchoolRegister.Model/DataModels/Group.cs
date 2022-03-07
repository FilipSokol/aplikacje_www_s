using System;
using System.Collections.Generic;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Group
{
	public int Id { get; set; }
	public string Name { get; set; }
	public IList<Student> Students {get; set; }
	public IList<SubjectGroup> SubjectGroups { get; set; }
}
