using AutoMapper;
using MediatR;
using Microsoft.Extensions.Localization;
using SchoolSystem.Data.Entities;
using SchoolSystem.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemSchool.Core.Bases;
using SystemSchool.Core.Features.Students.Queries.Models;
using SystemSchool.Core.Features.Students.Queries.Results;
using SystemSchool.Core.Resources;
using SystemSchool.Core.SharedResources;

namespace SystemSchool.Core.Features.Students.Queries.Handlers
{
    public class StudentQueryHandler : ResponseHandler,IRequestHandler<GetStudentListQuery,Response< List<GetStudentListResponse>>>
    {
        #region Fields

        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;
        //private readonly IStringLocalizer<Core.Resources.SharedResources> _stringLocalizer;



        #endregion

        #region Constructors s
        public StudentQueryHandler(  IStudentService studentService,
                                IMapper mapper
                           
            )
        {
            _studentService = studentService;
            _mapper = mapper;
            //_stringLocalizer = stringLocalizer;
        }

        #endregion

        #region HandleFunctions

        public async Task<Response<List<GetStudentListResponse>>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
            var studentlist =  await _studentService.GetStudentsListAsync();

            var studentlistMapper = _mapper.Map<List<GetStudentListResponse>>(studentlist);
            return Success(studentlistMapper);
        }

        //public object localization()
        //{
           
        //    return Success(_stringLocalizer[SharedResourcesKeys.success]);
        //}




        #endregion

    }
}
