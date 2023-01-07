using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PPD.WebApp.Domain.Entidades;

namespace PPD.WebApp.Infrastructure.Data.Mappings
{
    public class EmpresaMapping : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.ToTable("Empresas");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnType("bigint").UseIdentityColumn(1, 1).ValueGeneratedOnAdd();

            builder.Property(x => x.NomeFantasia).IsRequired();
            builder.Property(x => x.RazaoSocial).IsRequired();
            builder.Property(x => x.Cnpj).IsRequired();
            builder.Property(x => x.Telefone).IsRequired();
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.InformacaoEndereco).IsRequired();
            builder.Property(x => x.Bairro).IsRequired();
            builder.Property(x => x.CEP).IsRequired();
            builder.Property(x => x.Cidade).IsRequired();

            builder.Property(x => x.Complemento).HasColumnType("varchar(200)");
            builder.Property(x => x.Referencia).HasColumnType("varchar(200)");

            builder.HasOne(x => x.Usuario)
                .WithOne(x => x.Empresa)
                .OnDelete(DeleteBehavior.NoAction);
        }
    
    }
}
