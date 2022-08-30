using Microsoft.EntityFrameworkCore;
using projetohotsite.Models;

namespace Hotsite.Models
{
    public class DatabaseContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;DataBase=Hotsite;Uid=root;Pwd=;");
        }

        public DbSet<Interesse> Interesses { get; set; }
        public DbSet<Usuarios> Usuario { get; set; }

    }
}