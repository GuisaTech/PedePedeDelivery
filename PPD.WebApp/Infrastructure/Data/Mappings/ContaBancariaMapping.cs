using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PPD.WebApp.Domain.Entidades;

namespace PPD.WebApp.Infrastructure.Data.Mappings
{
    public class ContaBancariaMapping : IEntityTypeConfiguration<ContaBancaria>
    {
        public void Configure(EntityTypeBuilder<ContaBancaria> builder)
        {
            builder.ToTable("ContasBancarias");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnType("bigint").UseIdentityColumn(1, 1).ValueGeneratedOnAdd();

            builder.HasOne(x => x.Usuario)
                .WithMany(x => x.ContasBancarias)
                .HasForeignKey(x=> x.UsuarioId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    
    }
}
