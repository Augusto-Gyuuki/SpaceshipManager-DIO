using SpaceshipManager.Database;
using SpaceshipManager.Interfaces;
using SpaceshipManager.Models;

namespace SpaceshipManager.Repositorios
{
    public class EspacoNavePilotoRepositorio : RepositorioGenerico<EspacoNavePiloto>, IEspacoNavePilotoRepositorio
    {
        private readonly ManagerContext _ManagerContext;

        public EspacoNavePilotoRepositorio(ManagerContext managerContext) : base(managerContext)
        {
            _ManagerContext = managerContext;
        }
    }
}
