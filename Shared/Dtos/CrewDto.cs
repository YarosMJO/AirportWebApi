using System.Collections.Generic;

namespace Shared.Dtos
{
    public class CrewDto
    {
        public PilotDto Pilot { get; set; }
        public List<FlightAttendantDto> FlightAttendants { get; set; }

    }
}
