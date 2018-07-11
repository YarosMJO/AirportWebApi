using System.Collections.Generic;

namespace AirportApi.Models
{
    public class CrewDto
    {
        public PilotDto Pilot { get; set; }
        public List<FlightAttendantDto> FlightAttendants { get; set; }

    }
}
