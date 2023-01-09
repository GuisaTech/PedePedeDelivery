using Microsoft.EntityFrameworkCore;
using PPD.WebApp.Domain.Entidades;


namespace PPD.Infrastructure.Data
{
    public class PedePedeContext : DbContext
    {
        public PedePedeContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<ChavePix> ChavesPix { get; set; }
        public DbSet<ContaBancaria> ContasBancarias { get; set; }
        public DbSet<RedeSocial> RedesSociais { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Arquivo> Arquivos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Ignore<ValidationResult>();

            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(
                e => e.GetProperties().Where(p => p.ClrType == typeof(string))))
                property.SetColumnType("varchar(100)");

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PedePedeContext).Assembly);
        }
    }
}
