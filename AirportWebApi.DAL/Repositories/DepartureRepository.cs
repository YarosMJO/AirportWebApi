using AirportWebApi.DAL.Models;

namespace AirportWebApi.DAL.Repositories
{
    public class DepartureRepository : BaseRepository<Departure>
    {
        public DepartureRepository()
        {
            SetAll(seeder.departures);
        }
    }
}
