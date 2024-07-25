using SchoolCQRS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCQRS.Service.Interfaces
{
    public interface IStudentService
    {
        public Task<List<Student>> GetStudentsAsync();
    }
}
