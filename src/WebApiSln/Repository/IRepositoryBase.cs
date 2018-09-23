using System;
using System.Linq;

namespace Repository
{
	public interface IRepositoryBase<TEntity> where TEntity : class
	{
		TEntity BuscarPorId(int id);

		IQueryable<TEntity> BuscarTodos();

		void Adicionar(TEntity entity);

		void Atualizar(TEntity entity);
			
		void Deletar(int id);

		void Deletar(Func<TEntity, bool> predicate);

		void Commit();

		void Dispose();
	}
}