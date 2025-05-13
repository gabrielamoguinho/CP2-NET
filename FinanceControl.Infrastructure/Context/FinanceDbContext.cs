using FinanceControl.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinanceControl.Infrastructure.Context
{
    public class FinanceDbContext : DbContext
    {
        public FinanceDbContext(DbContextOptions<FinanceDbContext> options)
            : base(options) { }

        public DbSet<Lancamento> Lancamentos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Lancamento>()
                .Property(l => l.Valor)
                .HasPrecision(10, 2); // Até 99999999.99

            modelBuilder.Entity<Usuario>()
                .HasIndex(u => u.Email)
                .IsUnique(); // Evita emails duplicados
        }

        

    }
}
