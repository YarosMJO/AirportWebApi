using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AirportWebApi.DAL.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity GetById(int id);

        IEnumerable<TEntity> GetAll();

        TEntity Add(TEntity entity);

        TEntity Update(TEntity entity);

        TEntity Remove(int id);

        TEntity GetItemByPredicate(Func<TEntity, bool> predicate);

        void RemoveAll();
    }
    public abstract class EntityBase
    {
        [Required]
        public int Id { get; set; }
    }
}