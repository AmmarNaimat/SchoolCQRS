using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolCQRS.Core.Features.Students.Queries.Models;
using SchoolCQRS.Core.Features.Students.StudentFactoryInterfaces;
using SchoolCQRS.Data.AppMetaData;

namespace SchoolCQRS.API.Controllers
{
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly GetStudentsQuery _getStudentsQuery;
        private readonly IStudentFactory _studentFactory;

        public StudentController(IMediator mediator, GetStudentsQuery getStudentsQuery, IStudentFactory studentFactory)
        {
            _mediator = mediator;
            _getStudentsQuery = getStudentsQuery;
            _studentFactory = studentFactory;
        }

        [HttpGet(Router.StudentRouting.List)]
        public async Task<IActionResult> GetStudents()
        {
            var response = await _mediator.Send(_getStudentsQuery);
            return Ok(response);
        }

        [HttpGet(Router.StudentRouting.GetById)]
        public async Task<IActionResult> GetStudentById([FromRoute] int id)
        {
            var query = _studentFactory.CreateGetStudentByIdQuery(id);
            var response = await _mediator.Send(query);
            return Ok(response);
        }
    }
}
