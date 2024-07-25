using MediatR;
using SchoolCQRS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCQRS.Core.Features.Students.Queries.Models
{
    public class GetStudentsQuery : IRequest<List<Student>>
    {

    }
}
