using System.Collections.Generic;

namespace AirportWebApi.DAL.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();

        TEntity GetById(int id);

        TEntity AddEntry(TEntity entity);

        TEntity UpdateEntity(TEntity entity);

        TEntity RemoveEntity(int id);
    }
}