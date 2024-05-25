using Microsoft.EntityFrameworkCore;

namespace Models;

class ModelContext : DbContext
{
  public ModelContext(DbContextOptions<ModelContext> options) : base(options)
  {
  }

  public DbSet<Usuario> Usuarios { get; set; }
}
