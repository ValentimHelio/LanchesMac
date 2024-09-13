using LanchesMac.Models;
using Microsoft.EntityFrameworkCore;

namespace LanchesMac.Context
{
    public class AppDBbContext : DbContext
    {
        public AppDBbContext(DbContextOptions<AppDBbContext> options) : base(options) { }
        
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Lanche> Lanches { get; set; }
            
       
    }
}
