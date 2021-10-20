using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SpaceshipManager.Models;

namespace SpaceshipManager.Mapeamentos
{
    public class PilotoMap : IEntityTypeConfiguration<Piloto>
    {
        public void Configure(EntityTypeBuilder<Piloto> builder)
        {
            builder.ToTable("pilotos");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Id)
                .HasColumnName("id");

            builder.Property(a => a.Nome)
                .HasColumnName("nome")
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(a => a.IdPlaneta)
                .HasColumnName("planeta")
                .IsRequired();

            builder.Property(a => a.AnoNascimento)
                .HasColumnName("ano_nascimento")
                .IsRequired()
                .HasMaxLength(100);


            builder.HasIndex(a => a.Nome).HasPrefixLength(4);

            builder.HasMany(a => a.ListaHistoricoViagem).WithOne(x => x.Piloto).HasForeignKey(x => x.IdPiloto).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(a => a.Planeta).WithMany(x => x.ListaPilotos).HasForeignKey(x => x.IdPlaneta).OnDelete(DeleteBehavior.Cascade);
        }
    }
}