using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TiendaCervezas.Models;

namespace CRUDWEB.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Estilo> Estilos {get;set;} 
    public DbSet<Cerveza> Cervezas {get;set;} 
}
