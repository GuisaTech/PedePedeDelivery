using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PPD.WebApp.Domain.Entidades;

namespace PPD.WebApp.Infrastructure.Data.Mappings
{
    public class RedeSocialMapping : IEntityTypeConfiguration<RedeSocial>
    {
        public void Configure(EntityTypeBuilder<RedeSocial> builder)
        {
            builder.ToTable("RedesSociais");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnType("bigint").UseIdentityColumn(1, 1).ValueGeneratedOnAdd();

            builder.HasOne(x => x.Usuario)
                .WithOne(x => x.RedeSocial)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
