using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SystemSchool.Core.Features.Students.Queries.Models;
using SystemSchool.InfraStructure.Abstracts;

namespace SchoolSystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        #region Fields
        private readonly IStudentRepository _studentRepository;
        private readonly IMediator _mediator;



        #endregion

        #region Ctor
        public StudentController(IMediator mediator)
        {
            _mediator = mediator;
        }


        #endregion
      


        [HttpGet("/Student/list")]

        public async Task<IActionResult> GetAllStudentsAsync()
        {
            var response =await _mediator.Send(new GetStudentListQuery());
            return Ok(response);
        }

    }
}
