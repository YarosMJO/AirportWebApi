using System.Collections.Generic;

namespace AirportWebApi.DAL.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity GetById(int id);

        IEnumerable<TEntity> GetAll();

        TEntity Add(TEntity entity);

        TEntity Update(TEntity entity);

        TEntity Remove(int id);
    }
}