using AirportWebApi.DAL.Models;

namespace AirportWebApi.DAL.Repositories
{
    public class TicketRepository : BaseRepository<Ticket>
    {
        public TicketRepository()
        {
            SetAll(seeder.Tickets);
        }
    }
}
