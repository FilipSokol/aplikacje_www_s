using AutoMapper;
using SchoolRegister.Model.DataModels;
using SchoolRegister.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using SchoolRegister.Model.DtoModels;
using SchoolRegister.ViewModels.VM;

namespace SchoolRegister.Services.Configuration.AutoMapperProfiles
{
    public class MainProfile : Profile
    {
        public MainProfile()
        {
            CreateMap<Subject, SubjectVm>()
                .ForMember(dest => dest.TeacherName, x => x.MapFrom(src => $"{src.Teacher.FirstName} {src.Teacher.LastName}"))
                .ForMember(dest => dest.Groups, x => x.MapFrom(src => src.SubjectGroups.Select(y => y.Group)));

            CreateMap<AddOrUpdateSubjectVm, Subject>();

            CreateMap<Group, GroupVm>()
                .ForMember(dest => dest.Students, x => x.MapFrom(src => src.Students))
                .ForMember(dest => dest.Subjects, x => x.MapFrom(src => src.SubjectGroups.Select(s => s.Subject)));


            //Subject
            CreateMap<SubjectVm, AddOrUpdateSubjectVm>();
            CreateMap<AddOrUpdateSubjectVm, Subject>();

            //Grade
            CreateMap<AddGradeToStudentVm, Grade>()
                .ForMember(dest => dest.DateOfIssue, x => x.MapFrom(src => DateTime.Now));
            CreateMap<Grade, GradeVm>();

            //Teacher
            CreateMap<Teacher, TeacherVm>();

            //Student
            CreateMap<Student, StudentVm>();
            CreateMap<Student, GradesReportVm>()
                .ForMember(dest => dest.StudentFirstName, y => y.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.StudentLastName, y => y.MapFrom(src => src.LastName))
                .ForMember(dest => dest.GroupName, y => y.MapFrom(src => src.Group.Name))
                .ForMember(dest => dest.ParentName, y => y.MapFrom(src => $"{src.Parent.FirstName} {src.Parent.LastName}"))
                .ForMember(dest => dest.StudentGradesPerSubject, y => y.MapFrom(src => src.Grades
                    .GroupBy(g => g.Subject.Name)
                    .Select(g => new { SubjectName = g.Key, Grades = g.Select(gl => gl.GradeValue).ToList() })
                    .ToDictionary(x => x.SubjectName, x => x.Grades)));
        }
    }
}