using SchoolCQRS.Core.Features.Students.Queries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCQRS.Core.Features.Students.StudentFactoryInterfaces
{
    public interface IStudentFactory
    {
        GetStudentByIdQuery CreateGetStudentByIdQuery(int id);
    }
}
