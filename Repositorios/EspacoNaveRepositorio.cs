using SpaceshipManager.Database;
using SpaceshipManager.Interfaces;
using SpaceshipManager.Models;

namespace SpaceshipManager.Repositorios
{
    public class EspacoNaveRepositorio : RepositorioGenerico<EspacoNave>, IEspacoNaveRepositorio
    {
        private readonly ManagerContext _ManagerContext;

        public EspacoNaveRepositorio(ManagerContext managerContext) : base(managerContext)
        {
            _ManagerContext = managerContext;
        }
    }
}
