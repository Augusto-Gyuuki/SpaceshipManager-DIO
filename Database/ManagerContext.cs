using Microsoft.EntityFrameworkCore;
using SpaceshipManager.Mapeamentos;
using SpaceshipManager.Models;

namespace SpaceshipManager.Database
{
    public class ManagerContext : DbContext
    {
        public ManagerContext(DbContextOptions<ManagerContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new HistoricoViagemMap());
            builder.ApplyConfiguration(new EspacoNaveMap());
            builder.ApplyConfiguration(new PlanetaMap());
            builder.ApplyConfiguration(new PilotoMap());
        }

        public DbSet<Piloto> Pilotos { get; set; }
        public DbSet<Planeta> Planetas { get; set; }
        public DbSet<EspacoNave> EspacoNaves { get; set; }
        public DbSet<HistoricoViagem> HistoricoViagens { get; set; }
    }
}
