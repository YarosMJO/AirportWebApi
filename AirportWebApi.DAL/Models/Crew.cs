using AirportWebApi.DAL.Repositories;
using System.Collections.Generic;

namespace AirportWebApi.DAL.Models
{
    public class Crew : EntityBase
    {
        public int Pilot { get; set; }
        public List<int> FlightAttendants { get; set; }

    }
}
