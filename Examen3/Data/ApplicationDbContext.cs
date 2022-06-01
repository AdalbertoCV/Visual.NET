using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Examen3.Models;

namespace Examen3.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<Platillo> Platillos {get;set;}
    public DbSet<Postre> Postres {get;set;}
    public DbSet<Bebida> Bebidas {get;set;}
}
