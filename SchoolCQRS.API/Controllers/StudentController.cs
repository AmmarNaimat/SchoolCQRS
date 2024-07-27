using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolCQRS.Core.Features.Students.Queries.Models;
using SchoolCQRS.Core.Features.Students.StudentFactoryInterfaces;

namespace SchoolCQRS.API.Controllers
{
    [Route("api/[controller]")]
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

        [HttpGet("/Student/GetStudents")]
        public async Task<IActionResult> GetStudents()
        {
            var response = await _mediator.Send(_getStudentsQuery);
            return Ok(response);
        }

        [HttpGet("/Student/{id}")]
        public async Task<IActionResult> GetStudentById([FromRoute] int id)
        {
            var query = _studentFactory.CreateGetStudentByIdQuery(id);
            var response = await _mediator.Send(query);
            return Ok(response);
        }
    }
}
