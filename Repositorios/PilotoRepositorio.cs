using SpaceshipManager.Database;
using SpaceshipManager.Interfaces;
using SpaceshipManager.Models;

namespace SpaceshipManager.Repositorios
{
    public class PilotoRepositorio : RepositorioGenerico<Piloto>, IPilotoRepositorio
    {
        private readonly ManagerContext _ManagerContext;

        public PilotoRepositorio(ManagerContext managerContext) : base(managerContext) 
        {
            _ManagerContext = managerContext;
        }
    }
}
