using Repositories.Seeder;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AirportWebApi.DAL.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : EntityBase
    {
        public Seeder seeder = null;
        public BaseRepository()
        {
            seeder = new Seeder();
        }

        private List<T> entities;
        public T Add(T entity)
        {
            if (entity != null)
            {
                entities.Add(entity);
                return entity;
            }
            else return null;
        }

        public IEnumerable<T> GetAll()
        {
            return entities;
        }
        public void SetAll(List<T> entities)
        {
            this.entities = entities;
        }

        public T GetById(int id)
        {
            return GetItemByPredicate(x => x?.Id == id);
        }

        public T Remove(int id)
        {
            var item = GetItemByPredicate(x => x?.Id == id);
            if (item != null)
            {
                entities.Remove(item);
                return item;
            }
            else return null;
        }

        public T Update(T entity)
        {
            var item = GetItemByPredicate(x => x?.Id == entity?.Id);
            if (item != null)
            {
                entities.Remove(item);
                entities.Add(entity);
                return entity;
            }
            else return null;
        }

        public T GetItemByPredicate(Func<T, bool> predicate)
        {
            return entities.Where(predicate).FirstOrDefault();
        }
    }
}
