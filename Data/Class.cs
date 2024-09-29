using CasaCrianca.Models;
using Microsoft.EntityFrameworkCore;

namespace CasaCrianca.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Alunos> Alunos { get; set; }
        public DbSet<Funcionarios> Funcionarios { get; set; }
    } 
}
