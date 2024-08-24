using Microsoft.EntityFrameworkCore;
namespace pi_4.Models;

public class AppContext : DbContext
{
    public AppContext(DbContextOptions<AppContext> options) : base(options)
    {

    }

    public DbSet<Usuario> usuario { get; set; }
}
