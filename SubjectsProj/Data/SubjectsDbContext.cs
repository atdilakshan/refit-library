using Microsoft.EntityFrameworkCore;
using SubjectsProj.API.Models;

namespace SubjectsProj.API.Data
{
    public class SubjectsDbContext : DbContext
    {
        public SubjectsDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Subjects> Subjects { get; set; }
    }
}
