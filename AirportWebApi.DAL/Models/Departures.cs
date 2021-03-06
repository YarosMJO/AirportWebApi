﻿using AirportWebApi.DAL.Repositories;
using System;
using System.ComponentModel.DataAnnotations;

namespace AirportWebApi.DAL.Models
{
    public class Departure : EntityBase
    {
        [Required]
        public int FlightNumber { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DepartureDate { get; set; }
        [Required]
        public int Crew { get; set; }
        [Required]
        public int Plane { get; set; }
    }
}
