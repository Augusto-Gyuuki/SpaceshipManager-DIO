using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SpaceshipManager.Models;

namespace SpaceshipManager.Mapeamentos
{
    public class PlanetaMap : IEntityTypeConfiguration<Planeta>
    {
        public void Configure(EntityTypeBuilder<Planeta> builder)
        {
            builder.ToTable("planetas");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Id)
                .HasColumnName("id");

            builder.Property(a => a.Nome)
                .HasColumnName("nome")
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(a => a.Rotacao)
                .HasColumnName("rotacao")
                .IsRequired()
                .HasColumnType("DECIMAL(18,4)");

            builder.Property(a => a.Orbita)
                .HasColumnName("orbita")
                .IsRequired()
                .HasColumnType("DECIMAL(18,4)");

            builder.Property(a => a.Diametro)
                .HasColumnName("diametro")
                .IsRequired()
                .HasColumnType("DECIMAL(18,4)");

            builder.Property(a => a.Clima)
                .HasColumnName("clima")
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(a => a.Populacao)
                .IsRequired()
                .HasColumnName("populacao");


            builder.HasIndex(a => a.Nome).HasPrefixLength(4);

            builder.HasMany(a => a.ListaPilotos).WithOne(x => x.Planeta).HasForeignKey(x => x.IdPlaneta).OnDelete(DeleteBehavior.Cascade);
        }
    }
}