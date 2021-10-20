using System.Collections.Generic;
using System.Threading.Tasks;

namespace SpaceshipManager.Interfaces
{
    public interface IRepositorioGenerico<TEntity> where TEntity : class
    {
        Task<List<TEntity>> RecuperarTodos();
        Task<TEntity> RecuperarPorCodigo(int id);
        Task Inserir(TEntity entity);
        Task Atualizar(TEntity entity);
        Task Excluir(TEntity entity);
    }
}
