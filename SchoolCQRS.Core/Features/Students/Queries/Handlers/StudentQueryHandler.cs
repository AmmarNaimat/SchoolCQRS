using AutoMapper;
using MediatR;
using SchoolCQRS.Core.Bases;
using SchoolCQRS.Core.Features.Students.Queries.Models;
using SchoolCQRS.Core.Features.Students.Queries.Responses;
using SchoolCQRS.Data.Entities;
using SchoolCQRS.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCQRS.Core.Features.Students.Queries.Handlers
{
    public class StudentQueryHandler :ResponseHandler, IRequestHandler<GetStudentsQuery,Response<List<GetStudentsResponse>>>
    {
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;
        public StudentQueryHandler(IStudentService studentService, IMapper mapper)
        {
            _studentService = studentService;
            _mapper = mapper;
        }
        public async Task<Response<List<GetStudentsResponse>>> Handle(GetStudentsQuery request, CancellationToken cancellationToken)
        {
            List<Student> students = await _studentService.GetStudentsAsync();
            List<GetStudentsResponse> studentMapper = _mapper.Map<List<GetStudentsResponse>>(students);
            return Success(studentMapper);
        }
    }
}
