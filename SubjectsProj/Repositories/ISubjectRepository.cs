using SubjectsProj.API.Models;

namespace SubjectsProj.API.Repositories
{
    public interface ISubjectRepository
    {
        Task<IEnumerable<Subjects>> GetAllAsync();
    }
}
