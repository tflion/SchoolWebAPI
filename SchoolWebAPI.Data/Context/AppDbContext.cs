using Microsoft.EntityFrameworkCore;
using SchoolWebAPI.Models;

namespace SchoolWebAPI.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<Aluno> Aluno { get; set; }

    }
}
