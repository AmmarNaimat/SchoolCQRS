using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolCQRS.Core.Features.Students.Queries.Models;

namespace SchoolCQRS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly GetStudentsQuery _getStudentsQuery;

        public StudentController(IMediator mediator, GetStudentsQuery getStudentsQuery)
        {
            _mediator = mediator;
            _getStudentsQuery = getStudentsQuery;
        }

        [HttpGet("/Student/GetStudent")]
        public async Task<IActionResult> GetStudent()
        {
            var response = await _mediator.Send(_getStudentsQuery);
            return Ok(response);
        }
    }
}
