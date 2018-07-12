using AirportWebApi.DAL.Repositories;
using System;

namespace AirportWebApi.DAL.Models
{
    public class PlaneType : EntityBase
    {
        public string Model { get; set; }
        public int SeatsCapacity { get; set; }
        public int Carrying { get; set; }
        public TimeSpan LifeTime { get; set; }
    }
}
