using SchoolCQRS.Core.Features.Students.Queries.Models;
using SchoolCQRS.Core.Features.Students.StudentFactoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCQRS.Core.Features.Students.StudentFactoryImplementation
{
    internal class StudentFactory : IStudentFactory
    {
        public GetStudentByIdQuery CreateGetStudentByIdQuery(int id)
        {
            return new GetStudentByIdQuery(id);
        }
    }
}
