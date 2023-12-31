using Azure;
using MediatR;
using SchoolSystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemSchool.Core.Bases;
using SystemSchool.Core.Features.Students.Queries.Results;

namespace SystemSchool.Core.Features.Students.Queries.Models
{
    public class GetStudentListQuery : IRequest<Bases.Response<List<GetStudentListResponse>>>
    {

    }
}
