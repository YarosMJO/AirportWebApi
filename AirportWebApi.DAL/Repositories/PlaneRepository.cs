using AirportWebApi.DAL.Models;

namespace AirportWebApi.DAL.Repositories
{
    public class PlaneRepository : BaseRepository<Plane>
    {
        public PlaneRepository()
        {
            SetAll(seeder.Planes);
        }
    }
}
