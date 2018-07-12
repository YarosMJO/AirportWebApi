using AirportWebApi.DAL.Repositories;

namespace AirportWebApi.DAL.Models
{
    public class Ticket : EntityBase
    {
        public int Price { get; set; }
        public int FlightNumber { get; set; }
    }
}