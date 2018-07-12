using AirportWebApi.DAL.Repositories;
using System;
using System.Collections.Generic;

namespace AirportWebApi.DAL.Models
{
    public class Flight : EntityBase
    {
        public DateTime DepartureTime { get; set; }
        public string DeparturePoint { get; set; }
        public string Destination { get; set; }
        public DateTime ArrivalTime { get; set; }
        public List<int> Tickets { get; set; }
    }
}
