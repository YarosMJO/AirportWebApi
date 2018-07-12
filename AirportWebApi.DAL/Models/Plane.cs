using AirportWebApi.DAL.Repositories;
using System;

namespace AirportWebApi.DAL.Models
{
    public class Plane : EntityBase
    {
        public string Name { get; set; }
        public int Type { get; set; }
        public DateTime ReleaseDate { get; set; }
        public TimeSpan LifeTime { get; set; }
    }
}
