using crudtestdev.Models;
using Microsoft.EntityFrameworkCore;

namespace crudtestdev.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> Options): base(Options) 
        {
        }
        public DbSet<Produto> Produtos { get; set; }
    }
}
