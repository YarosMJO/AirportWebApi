using AirportWebApi.DAL.Models;

namespace AirportWebApi.DAL.Repositories
{
    public class PlaneTypeRepository : BaseRepository<PlaneType>
    {
        public PlaneTypeRepository()
        {
            SetAll(seeder.PlaneTypes);
        }
    }
}
