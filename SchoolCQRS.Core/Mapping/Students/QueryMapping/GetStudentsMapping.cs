using AutoMapper;
using SchoolCQRS.Core.Features.Students.Queries.Responses;
using SchoolCQRS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCQRS.Core.Mapping.Students
{
    public partial class StudentProfile:Profile
    {
        public void GetStudentsMapping()
        {
            CreateMap<Student, GetStudentsResponse>()
                .ForMember(des => des.DepartmentName, opt => opt.MapFrom(src => src.Department.DName));
        }
    }
}
