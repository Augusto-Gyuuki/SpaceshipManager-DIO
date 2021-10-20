using SpaceshipManager.Database;
using SpaceshipManager.Interfaces;
using SpaceshipManager.Models;

namespace SpaceshipManager.Repositorios
{
    public class HistoricoViagemRepositorio : RepositorioGenerico<HistoricoViagem>, IHistoricoViagemRepositorio
    {
        private readonly ManagerContext _ManagerContext;

        public HistoricoViagemRepositorio(ManagerContext managerContext) : base(managerContext)
        {
            _ManagerContext = managerContext;
        }
    }
}
