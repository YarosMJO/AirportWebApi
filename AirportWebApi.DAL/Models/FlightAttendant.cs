using AirportWebApi.DAL.Repositories;
using System;

namespace AirportWebApi.DAL.Models
{
    public class FlightAttendant : EntityBase
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }

    }
}
