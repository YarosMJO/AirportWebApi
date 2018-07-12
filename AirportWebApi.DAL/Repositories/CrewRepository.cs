using AirportWebApi.DAL.Models;

namespace AirportWebApi.DAL.Repositories
{
    public class CrewRepository : BaseRepository<Crew>
    {
        private CrewRepository()
        {
            SetAll(seeder.Crews);
        }
    }
}
