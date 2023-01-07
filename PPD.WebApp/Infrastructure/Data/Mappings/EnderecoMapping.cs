using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PPD.WebApp.Domain.Entidades;

namespace PPD.WebApp.Infrastructure.Data.Mappings
{
    internal class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Enderecos");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnType("bigint").UseIdentityColumn(1, 1).ValueGeneratedOnAdd();

            builder.Property(x => x.InformacaoEndereco).IsRequired();
            builder.Property(x => x.Bairro).IsRequired();
            builder.Property(x => x.CEP).IsRequired();
            builder.Property(x => x.Cidade).IsRequired();

            builder.Property(x => x.Complemento).HasColumnType("varchar(200)");
            builder.Property(x => x.Referencia).HasColumnType("varchar(200)");

            builder.HasOne(x => x.Usuario)
                .WithMany(x => x.Enderecos)
                .HasForeignKey(x=>x.UsuarioId)
                .OnDelete(DeleteBehavior.NoAction);

            //Sem número é obrigatório por referencia ou complemento
        }
    }
}
