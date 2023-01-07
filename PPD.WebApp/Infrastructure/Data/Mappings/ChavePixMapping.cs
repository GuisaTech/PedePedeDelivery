using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PPD.WebApp.Domain.Entidades;

namespace PPD.WebApp.Infrastructure.Data.Mappings
{
    public class ChavePixMapping : IEntityTypeConfiguration<ChavePix>
    {
        public void Configure(EntityTypeBuilder<ChavePix> builder)
        {
            builder.ToTable("ChavesPix");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnType("bigint").UseIdentityColumn(1, 1).ValueGeneratedOnAdd();

            builder.Property(x => x.Tipo).IsRequired();
            builder.Property(x => x.Valor).IsRequired();
            builder.Property(x => x.Titular).IsRequired();

            builder.HasOne(x => x.Usuario)
                .WithMany(x => x.ChavesPix)
                .HasForeignKey(x=> x.UsuarioId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
