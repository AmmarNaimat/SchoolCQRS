using MediatR;
using SchoolCQRS.Core.Features.Students.Queries.Models;
using SchoolCQRS.Data.Entities;
using SchoolCQRS.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCQRS.Core.Features.Students.Queries.Handlers
{
    public class StudentHandler : IRequestHandler<GetStudentsQuery, List<Student>>
    {
        private readonly IStudentService _studentService;

        public StudentHandler(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public async Task<List<Student>> Handle(GetStudentsQuery request, CancellationToken cancellationToken)
        {
            return await _studentService.GetStudentsAsync();
        }
    }
}
