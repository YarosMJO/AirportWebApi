using System;

namespace Shared.Dtos
{
    public class DeparturesDto
    {
        public int Id { get; set; }
        public int FlightNumber { get; set; }
        public DateTime DepartureDate { get; set; }
        public int Crew { get; set; }
        public int Plane { get; set; }

    }
}
