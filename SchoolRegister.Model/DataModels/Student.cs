using SchoolRegister.Model.DataModels;
using System;
using System.Collections.Generic;

public class Student
{
	public Group Group { get; set; }
	public int? GroupId { get; set; }
	public IList<Grade> Grades { get; set; }
	public Parent Parent { get; set; }
	public int? ParentId { get; set; }
	public double AverageGrade { get; }
	public IDictionary<string, double> AverageGradePerSubject{ get;}
	public IDictionary<string, List<GradeScale>> GradesPerSubject { get; }
}

