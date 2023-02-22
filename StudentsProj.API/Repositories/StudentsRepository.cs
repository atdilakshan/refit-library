using Microsoft.EntityFrameworkCore;
using StudentsProj.API.Data;
using StudentsProj.API.Models;

namespace StudentsProj.API.Repositories
{
    public class StudentsRepository : IStudentsRepository
    {
        private readonly StudentsDbContext studentsDbContext;

        public StudentsRepository(StudentsDbContext studentsDbContext)
        {
            this.studentsDbContext = studentsDbContext;
        }

        public async Task<IEnumerable<Students>> GetAllAsync()
        {
            return await studentsDbContext.Students.ToListAsync();
        }
    }
}
