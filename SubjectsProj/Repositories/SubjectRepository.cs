using Microsoft.EntityFrameworkCore;
using SubjectsProj.API.Data;
using SubjectsProj.API.Models;

namespace SubjectsProj.API.Repositories
{
    public class SubjectRepository : ISubjectRepository
    {
        private readonly SubjectsDbContext subjectsDbContext;

        public SubjectRepository(SubjectsDbContext subjectsDbContext)
        {
            this.subjectsDbContext = subjectsDbContext;
        }
        public async Task<IEnumerable<Subjects>> GetAllAsync()
        {
            return await subjectsDbContext.Subjects.ToListAsync();
        }
    }
}
