using SchoolSystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemSchool.Core.Features.Students.Queries.Results;
using AutoMapper;


namespace SystemSchool.Core.Mapping.StudentMapper
{
    public partial class StudentProfile 
    {
        public void GetStudentListMapping()

        {
            CreateMap<Student, GetStudentListResponse>()
              .ForMember(dist => dist.DepartmentName, opt => opt.MapFrom(source => source.Department.DName));
        }

    }
}
