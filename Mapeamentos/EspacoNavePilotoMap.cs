using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SpaceshipManager.Models;

namespace SpaceshipManager.Mapeamentos
{
    public class EspacoNavePilotoMap : IEntityTypeConfiguration<EspacoNavePiloto>
    {
        public void Configure(EntityTypeBuilder<EspacoNavePiloto> builder)
        {
            builder.ToTable("espaco_nave_piloto");

            builder.HasKey(a => new { a.IdPiloto, a.IdEspacoNave });

            builder.Property(a => a.IdEspacoNave)
                .HasColumnName("espaco_nave")
                .IsRequired();

            builder.Property(a => a.IdPiloto)
                .HasColumnName("piloto")
                .IsRequired();

            builder.HasOne(a => a.Piloto).WithMany(x => x.ListaEspacoNavePiloto).HasForeignKey(x => x.IdPiloto).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(a => a.EspacoNave).WithMany(x => x.ListaEspacoNavePiloto).HasForeignKey(x => x.IdEspacoNave).OnDelete(DeleteBehavior.Cascade);
        }
    }
}