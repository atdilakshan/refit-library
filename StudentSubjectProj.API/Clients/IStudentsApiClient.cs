using Refit;
using StudentSubjectProj.API.Models;

namespace StudentSubjectProj.API.Clients
{
    public interface IStudentsApiClient
    {
        [Get("/students")]
        Task<IEnumerable<Students>> GetAllStudents();
    }
}
