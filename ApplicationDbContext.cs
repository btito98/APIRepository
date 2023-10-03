using EstudoCRUDAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EstudoCRUDAPI
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<ECV> ECVs{ get; set;}
        public DbSet<Vistoria> Vistorias { get; set;}


    }
}
