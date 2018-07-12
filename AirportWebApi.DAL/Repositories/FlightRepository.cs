using AirportWebApi.DAL.Models;

namespace AirportWebApi.DAL.Repositories
{
    public class FlightRepository : BaseRepository<Flight>
    {
        public FlightRepository()
        {
            SetAll(seeder.Flights);
        }
    }
}
