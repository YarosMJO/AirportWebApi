using System.Collections.Generic;

namespace AirportApi.Models
{
    public class Crew
    {
        public Pilot Pilot { get; set; }
        public List<FlightAttendant> FlightAttendants { get; set; }

    }
}
