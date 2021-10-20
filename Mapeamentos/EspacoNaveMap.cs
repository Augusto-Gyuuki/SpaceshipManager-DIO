using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SpaceshipManager.Models;

namespace SpaceshipManager.Mapeamentos
{
    public class EspacoNaveMap : IEntityTypeConfiguration<EspacoNave>
    {
        public void Configure(EntityTypeBuilder<EspacoNave> builder)
        {
            builder.ToTable("espaco_naves");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Id)
                .HasColumnName("id");

            builder.Property(a => a.Nome)
                .HasColumnName("nome")
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(a => a.Modelo)
                .HasColumnName("modelo")
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(a => a.Classe)
                .HasColumnName("classe")
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(a => a.Carga)
                .HasColumnName("carga")
                .IsRequired()
                .HasColumnType("DECIMAL(18,4)");

            builder.Property(a => a.Passageiros)
                .IsRequired()
                .HasColumnName("passageiros");


            builder.HasIndex(a => a.Nome).HasPrefixLength(4);

            builder.HasMany(a => a.ListaEspacoNavePiloto).WithOne(x => x.EspacoNave).HasForeignKey(x => x.IdEspacoNave).OnDelete(DeleteBehavior.Cascade);
        }
    }
}