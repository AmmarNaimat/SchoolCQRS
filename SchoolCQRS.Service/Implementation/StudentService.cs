using Microsoft.EntityFrameworkCore;
using SchoolCQRS.Data.Entities;
using SchoolCQRS.Infrastructure.Interfaces;
using SchoolCQRS.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCQRS.Service.Implementation
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<Student> GetStudentByIdAsync(int id)
        {
            //var student = await _studentRepository.GetByIdAsync(id);
            var student = await _studentRepository.GetTableNoTracking().Include(std => std.Department).Where(std => std.Id == id).FirstOrDefaultAsync();
            return student;
        }

        public async Task<List<Student>> GetStudentsAsync()
        {
            return await _studentRepository.GetStudentsAsync();
        }
    }
}
