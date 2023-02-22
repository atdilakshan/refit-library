using Microsoft.AspNetCore.Mvc;
using StudentSubjectProj.API.Repositories;

namespace StudentSubjectProj.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentSubjectController : Controller
    {
        private readonly IStudentSubjectRepository studentSubjectRepository;

        public StudentSubjectController(IStudentSubjectRepository studentSubjectRepository)
        {
            this.studentSubjectRepository = studentSubjectRepository;
        }

        [HttpGet("get-all-students")]
        public async Task<IActionResult> GetAllStudentsAsync()
        {
            try
            {
                var students = await studentSubjectRepository.GetAllStudentsAsync();
                return Ok(students);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet("get-all-subjects")]
        public async Task<IActionResult> GetAllSubjectsAsync()
        {
            try
            {
                var students = await studentSubjectRepository.GetAllSubjectsAsync();
                return Ok(students);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
