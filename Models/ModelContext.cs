using Microsoft.EntityFrameworkCore;

namespace Models;

public class ModelContext : DbContext
{
    public ModelContext(DbContextOptions<ModelContext> options) : base(options)
    {
    }

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Logista> Logistas { get; set; }
    public DbSet<Transacao> Transacoes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Usuario>(usuario =>
        {
            usuario.HasKey(k => k.Id);

            usuario.HasIndex(k => k.Cpf)
                .IsUnique();

            usuario.HasIndex(k => k.Email)
                .IsUnique();
        });

        modelBuilder.Entity<Logista>(logista =>
        {
            logista.HasKey(k => k.Id);

            logista.HasIndex(k => k.Cnpj)
                .IsUnique();

            logista.HasIndex(k => k.Email)
                .IsUnique();
        });
        
        modelBuilder.Entity<Transacao>(transacao =>
        {
            transacao.HasKey(k => k.Id);
        });
    }
}