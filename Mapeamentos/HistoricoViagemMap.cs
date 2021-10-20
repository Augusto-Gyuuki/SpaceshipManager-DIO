using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SpaceshipManager.Models;

namespace SpaceshipManager.Mapeamentos
{
    public class HistoricoViagemMap : IEntityTypeConfiguration<HistoricoViagem>
    {
        public void Configure(EntityTypeBuilder<HistoricoViagem> builder)
        {
            builder.ToTable("historico_viagens");

            builder.HasKey(a => new { a.IdPiloto, a.IdEspacoNave });

            builder.Property(a => a.IdPiloto)
                .HasColumnName("piloto")
                .IsRequired();

            builder.Property(a => a.IdEspacoNave)
                .HasColumnName("espaco_nave")
                .IsRequired();

            builder.Property(a => a.DataSaida)
                .HasColumnName("data_saida")
                .IsRequired();

            builder.Property(a => a.DataChegada)
                .HasColumnName("data_chegada");


            builder.HasOne(a => a.Piloto).WithMany(x => x.ListaHistoricoViagem).HasForeignKey(x => x.IdPiloto).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(a => a.EspacoNave).WithMany(x => x.ListaHistoricoViagem).HasForeignKey(x => x.IdEspacoNave).OnDelete(DeleteBehavior.Cascade);
        }
    }
}