using Microsoft.EntityFrameworkCore;
using SpaceshipManager.Database;
using SpaceshipManager.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SpaceshipManager.Repositorios
{
    public class RepositorioGenerico<TEntity> : IRepositorioGenerico<TEntity> where TEntity : class
    {
        private readonly ManagerContext _ManagerContext;

        public RepositorioGenerico(ManagerContext managerContext)
        {
            _ManagerContext = managerContext;
        }

        public async Task Atualizar(TEntity entity)
        {
            _ManagerContext.Set<TEntity>().Update(entity);
            await _ManagerContext.SaveChangesAsync();
        }

        public async Task Excluir(TEntity entity)
        {
            _ManagerContext.Set<TEntity>().Remove(entity);
            await _ManagerContext.SaveChangesAsync();
        }

        public async Task Inserir(TEntity entity)
        {
            await _ManagerContext.AddAsync(entity);
            await _ManagerContext.SaveChangesAsync();
        }

        public async Task<TEntity> RecuperarPorCodigo(int id)
        {
            return await _ManagerContext.Set<TEntity>().FindAsync(id);
        }

        public async Task<List<TEntity>> RecuperarTodos()
        {
            return await _ManagerContext.Set<TEntity>().ToListAsync();
        }
    }
}
