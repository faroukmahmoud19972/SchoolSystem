using AutoMapper;
using SchoolSystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemSchool.Core.Features.Students.Queries.Results;

namespace SystemSchool.Core.Mapping.StudentMapper
{
    public partial class StudentProfile : Profile
    {

        public StudentProfile()
        {
           GetStudentListMapping();



        }

    }
}
