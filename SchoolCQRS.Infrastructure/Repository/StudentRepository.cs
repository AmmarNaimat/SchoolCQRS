using Microsoft.EntityFrameworkCore;
using SchoolCQRS.Data.Entities;
using SchoolCQRS.Infrastructure.Context;
using SchoolCQRS.Infrastructure.InfrastructureBases;
using SchoolCQRS.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCQRS.Infrastructure.Repository
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        private readonly DbSet<Student> _students;

        public StudentRepository(AppDBContext appDBContext): base(appDBContext)
        {
            _students = appDBContext.Set<Student>();
        }
        public async Task<List<Student>> GetStudentsAsync()
        {
            return await _students.Include(std => std.Department).ToListAsync();
        }
    }
}
