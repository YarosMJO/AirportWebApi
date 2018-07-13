using AirportWebApi.DAL.Models;

namespace AirportWebApi.DAL.Repositories
{
    public class PilotRepository : BaseRepository<Pilot>
    {
        public PilotRepository()
        {
            SetAll(seeder.Pilots);
        }
    }

}
