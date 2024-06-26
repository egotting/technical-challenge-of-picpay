using Microsoft.EntityFrameworkCore;

namespace Models;

class ModelContext : DbContext
{
  public ModelContext(DbContextOptions<ModelContext> options) : base(options)
  {
  }

  public DbSet<Usuario> Usuarios { get; set; }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<Usuario>(usuario =>
    {
      usuario.HasKey(k => k.Id);

      usuario.HasIndex(k => k.Cpf_Cnpj)
       .IsUnique();

      usuario.HasIndex(k => k.Email)
       .IsUnique();


    });

    OnModelCreatingPartial(modelBuilder);
  }

  private void OnModelCreatingPartial(ModelBuilder modelBuilder)
  {

  }
}
