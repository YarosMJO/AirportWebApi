using AirportWebApi.DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace AirportWebApi.DAL.Repositories
{
    public class HouseRepository : IHouseRepository
    {
        readonly Dictionary<int, HouseModel> _houses = new Dictionary<int, HouseModel>();

        public HouseRepository()
        {
            _houses.Add(1, new HouseModel() { City = "Town1", Id = 1, Street = "Street1", ZipCode = 1234 });
            _houses.Add(2, new HouseModel() { City = "Town2", Id = 2, Street = "Street2", ZipCode = 1234 });
            _houses.Add(3, new HouseModel() { City = "Town3", Id = 3, Street = "Street3", ZipCode = 1234 });
            _houses.Add(4, new HouseModel() { City = "Town4", Id = 4, Street = "Street4", ZipCode = 1234 });
        }

        public List<HouseModel> GetAll()
        {
            return _houses.Select(x => x.Value).ToList();
        }

        public HouseModel GetSingle(int id)
        {
            return _houses.FirstOrDefault(x => x.Key == id).Value;
        }

        public HouseModel Add(HouseModel toAdd)
        {
            int newId = !GetAll().Any() ? 1 : GetAll().Max(x => x.Id) + 1;
            toAdd.Id = newId;
            _houses.Add(newId, toAdd);
            return toAdd;
        }

        public HouseModel Update(HouseModel toUpdate)
        {
            HouseModel single = GetSingle(toUpdate.Id);

            if (single == null)
            {
                return null;
            }

            _houses[single.Id] = toUpdate;
            return toUpdate;
        }

        public void Delete(int id)
        {
            _houses.Remove(id);
        }
    }
}
