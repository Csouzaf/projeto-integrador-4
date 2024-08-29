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

    public DbSet<UsuarioProduto> usuarioProduto { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UsuarioAdm>()
            .HasMany(m => m.produtos)
            .WithOne(m => m.usuarioAdm)
            .HasForeignKey(m => m.usuarioAdmId);

    }
}
