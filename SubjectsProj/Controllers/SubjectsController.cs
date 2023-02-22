using Microsoft.AspNetCore.Mvc;
using SubjectsProj.API.Repositories;

namespace SubjectsProj.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SubjectsController : Controller
    {
        private readonly ISubjectRepository subjectRepository;

        public SubjectsController(ISubjectRepository subjectRepository)
        {
            this.subjectRepository = subjectRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSubjectsAsync()
        {
            var subject = await subjectRepository.GetAllAsync();
            return Ok(subject);
        }
    }
}
