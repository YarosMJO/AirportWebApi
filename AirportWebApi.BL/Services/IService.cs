using System.Collections.Generic;

namespace AirportWebApi.BL
{
    public interface IService<TEntity> where TEntity : class
    {
        List<TEntity> GetAll();
        TEntity GetById(int id);
        TEntity Add(TEntity entity);
        TEntity Remove(int id);
        TEntity Update(TEntity entity);
        void RemoveAll();
    }
}
