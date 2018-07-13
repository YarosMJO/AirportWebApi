using System.Collections.Generic;

namespace Shared.Dtos
{
    public class CrewDto
    {
        public int Id { get; set; }
        public int Pilot { get; set; }
        public List<int> FlightAttendants { get; set; }
    }
}
