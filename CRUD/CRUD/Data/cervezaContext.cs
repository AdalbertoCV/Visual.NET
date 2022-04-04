using Microsoft.EntityFrameworkCore;

namespace CRUD{
    public class CervezaContext: DbContext{
        public DbSet<cerveza> cervezas{get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlServer(@"Server=(LocalDB)\PVE;Database=Cervezas;Trusted_Connection=True;");
        }
    }
}