using Refit;
using StudentSubjectProj.API.Models;

namespace StudentSubjectProj.API.Clients
{
    public interface ISubjectsApiClient
    {
        [Get("/subjects")]
        Task<IEnumerable<Subjects>> GetAllSubjects();
    }
}
