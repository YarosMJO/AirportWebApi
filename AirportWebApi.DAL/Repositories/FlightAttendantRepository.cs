using AirportWebApi.DAL.Models;

namespace AirportWebApi.DAL.Repositories
{
    public class FlightAttendantRepository : BaseRepository<FlightAttendant>
    {
        public FlightAttendantRepository()
        {
            SetAll(seeder.FlightAttendants);
        }
    }
}
