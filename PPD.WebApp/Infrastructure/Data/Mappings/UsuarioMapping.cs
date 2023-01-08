using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PPD.WebApp.Domain.Entidades;
using System.Linq;


namespace PPD.WebApp.Infrastructure.Data.Mappings
{
    public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuarios");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnType("bigint").UseIdentityColumn(1,1).ValueGeneratedOnAdd();

            builder.Property(x => x.Cpf)
                .IsRequired()
                .HasColumnType("varchar(11)");

            builder.HasIndex(x => x.Cpf, "UQ_Usuario_Cpf").IsUnique();

            builder.Property(x => x.Email)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(x => x.Senha)
                .IsRequired()
                .HasColumnType("varchar(40)");

            builder.Property(x => x.Telefone)
                .IsRequired(false)
                .HasColumnType("varchar(11)");

            builder.HasMany(x => x.Enderecos)
                .WithOne(x => x.Usuario)
                .HasForeignKey(x => x.UsuarioId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.RedeSocial)
                .WithOne(x => x.Usuario)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.Empresa)
                .WithOne(x => x.Usuario)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x => x.ChavesPix)
                .WithOne(x => x.Usuario)
                .HasForeignKey(x => x.UsuarioId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x => x.ContasBancarias)
                .WithOne(x => x.Usuario)
                .HasForeignKey(x => x.UsuarioId)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
