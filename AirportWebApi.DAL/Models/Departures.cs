using AirportWebApi.DAL.Repositories;
using System;

namespace AirportWebApi.DAL.Models
{
    public class Departure : EntityBase
    {
        public int FlightNumber { get; set; }
        public DateTime DepartureDate { get; set; }
        public int Crew { get; set; }
        public int Plane { get; set; }

    }
}
