using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Context
{
    public class PassagemDbContext : DbContext
    {

        public PassagemDbContext(DbContextOptions<PassagemDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Passagem> Passagens { get; set; }
    }
}
