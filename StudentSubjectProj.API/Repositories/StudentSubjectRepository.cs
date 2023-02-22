using StudentSubjectProj.API.Clients;
using StudentSubjectProj.API.Models;

namespace StudentSubjectProj.API.Repositories
{
    public class StudentSubjectRepository : IStudentSubjectRepository
    {
        private readonly IStudentsApiClient studentsApiClient;
        private readonly ISubjectsApiClient subjectsApiClient;

        public StudentSubjectRepository(IStudentsApiClient studentsApiClient, ISubjectsApiClient subjectsApiClient)
        {
            this.studentsApiClient = studentsApiClient;
            this.subjectsApiClient = subjectsApiClient;
        }
        public Task<IEnumerable<Students>> GetAllStudentsAsync()
        {
            return studentsApiClient.GetAllStudents();
        }
        public Task<IEnumerable<Subjects>> GetAllSubjectsAsync()
        {
            return subjectsApiClient.GetAllSubjects();
        }
    }
}
