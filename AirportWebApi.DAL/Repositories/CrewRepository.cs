using AirportWebApi.DAL.Models;

namespace AirportWebApi.DAL.Repositories
{
    public class CrewRepository : BaseRepository<Crew>
    {
        public CrewRepository()
        {
            SetAll(seeder.Crews);
        }
    }
}
