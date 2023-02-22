using StudentSubjectProj.API.Models;

namespace StudentSubjectProj.API.Repositories
{
    public interface IStudentSubjectRepository
    {
        Task<IEnumerable<Students>> GetAllStudentsAsync();
        Task<IEnumerable<Subjects>> GetAllSubjectsAsync();
    }
}
