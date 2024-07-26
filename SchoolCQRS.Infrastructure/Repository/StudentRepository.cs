using Microsoft.EntityFrameworkCore;
using SchoolCQRS.Data.Entities;
using SchoolCQRS.Infrastructure.Context;
using SchoolCQRS.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCQRS.Infrastructure.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDBContext _appDBContext;

        public StudentRepository(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        public async Task<List<Student>> GetStudentsAsync()
        {
            return await _appDBContext.students.Include(std => std.Department).ToListAsync();
        }
    }
}
