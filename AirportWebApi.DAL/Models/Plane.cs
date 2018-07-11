using System;

namespace AirportApi.Models
{
    public class Plane
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PlaneType Type { get; set; }
        public DateTime ReleaseDate { get; set; }
        public TimeSpan LifeTime { get; set; }
    }
}
