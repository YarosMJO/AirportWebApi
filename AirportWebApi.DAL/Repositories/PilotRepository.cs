using AirportWebApi.DAL.Models;
using AirportWebApi.DAL.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace AirportWebAPI.DataAccessLayer.Repositories
{
    public class PilotRepository : IRepository<HouseModel>
    {
        private List<HouseModel> pilots;
        public PilotRepository()
        {
            CreateSeeds();
        }

        public HouseModel AddEntry(HouseModel entity)
        {
            if (entity != null)
            {
                pilots.Add(entity);
                return entity;
            }
            else return null;
        }

        public IEnumerable<HouseModel> GetAll()
        {
            return pilots;
        }

        public HouseModel GetById(int id)
        {
            return pilots.Where(x => x.Id == id).FirstOrDefault();
        }

        public HouseModel RemoveEntity(int id)
        {
            var temp = pilots.Where(x => x.Id == id).FirstOrDefault();
            if (temp != null)
            {
                pilots.Remove(temp);
                return temp;
            }
            else
            {
                return null;
            }
        }

        public HouseModel UpdateEntity(HouseModel entity)
        {
            var temp = pilots.Where(x => x.Id == entity.Id).FirstOrDefault();
            if (temp != null)
            {
                pilots.Remove(temp);
                pilots.Add(entity);
                return entity;
            }
            else
            {
                return null;
            }
        }

        private void CreateSeeds()
        {
            pilots = new List<HouseModel>
            {
                //new HouseModel { Id = 1, FirstName = "Donald", SecondName = "Trump", BirthDate = "11.01.1960", Experience = 10},
                //new HouseModel { Id = 2, FirstName = "George", SecondName = "Bush" , BirthDate = "29.06.1975", Experience = 5}
            };
        }
    }
}
