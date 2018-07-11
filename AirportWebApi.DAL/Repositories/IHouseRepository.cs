using AirportWebApi.DAL.Models;
using System.Collections.Generic;

namespace AirportWebApi.DAL.Repositories
{
    public interface IHouseRepository
    {
        List<HouseModel> GetAll();
        HouseModel GetSingle(int id);
        HouseModel Add(HouseModel toAdd);
        HouseModel Update(HouseModel toUpdate);
        void Delete(int id);
    }
}
