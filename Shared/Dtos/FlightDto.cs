using System;

namespace Shared.Dtos
{
    public class FlightDto
    {
        public int Id { get; set; }
        public DateTime DepartureTime { get; set; }
        public string Destination { get; set; }
        public DateTime ArrivalTime { get; set; }
    }
}
