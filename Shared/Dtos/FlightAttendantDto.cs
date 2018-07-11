using System;

namespace AirportApi.Models
{
    public class FlightAttendantDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }

    }
}
