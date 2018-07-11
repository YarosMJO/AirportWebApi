using System.Collections.Generic;

namespace AirportWebApi.BL
{
    public interface IService<TEntity> where TEntity : class
    {
        List<TEntity> GetAll();
        TEntity GetById(int id);
        TEntity AddEntry(TEntity entity);
        TEntity RemoveEntry(int id);
        TEntity UpdateEntry(TEntity entity);
    }
}
