using SpaceshipManager.Database;
using SpaceshipManager.Interfaces;
using SpaceshipManager.Models;

namespace SpaceshipManager.Repositorios
{
    public class PlanetaRepositorio : RepositorioGenerico<Planeta>, IPlanetaRepositorio
    {
        private readonly ManagerContext _ManagerContext;

        public PlanetaRepositorio(ManagerContext managerContext) : base(managerContext)
        {
            _ManagerContext = managerContext;
        }
    }
}
