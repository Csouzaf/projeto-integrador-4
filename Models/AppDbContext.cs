using Microsoft.EntityFrameworkCore;
namespace pi_4.Models;

public class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<Usuario> usuario { get; set; }

    public DbSet<UsuarioAdm> usuarioAdm { get; set; }
}
