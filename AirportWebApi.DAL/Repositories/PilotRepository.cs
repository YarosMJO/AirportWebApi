using AirportWebApi.DAL.Models;
using AirportWebApi.DAL.Repositories;

namespace AirportWebAPI.DataAccessLayer.Repositories
{
    public class PilotRepository : BaseRepository<Pilot>
    {
        public PilotRepository()
        {
            SetAll(seeder.Pilots);
        }
    }

}
