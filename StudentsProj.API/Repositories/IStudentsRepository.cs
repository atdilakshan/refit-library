using StudentsProj.API.Models;

namespace StudentsProj.API.Repositories
{
    public interface IStudentsRepository
    {
        Task<IEnumerable<Students>> GetAllAsync();
    }
}
