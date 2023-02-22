using Microsoft.EntityFrameworkCore;
using StudentsProj.API.Models;

namespace StudentsProj.API.Data
{
    public class StudentsDbContext : DbContext
    {
        public StudentsDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Students> Students { get; set; }
    }
}
