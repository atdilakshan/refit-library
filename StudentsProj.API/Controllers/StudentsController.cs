using Microsoft.AspNetCore.Mvc;
using StudentsProj.API.Repositories;
using System.Data;

namespace StudentsProj.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : Controller
    {
        private readonly IStudentsRepository studentsRepository;

        public StudentsController(IStudentsRepository studentsRepository)
        {
            this.studentsRepository = studentsRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStudentsAsync()
        {
            var students = await studentsRepository.GetAllAsync();
            return Ok(students);
        }
    }
}
