using AirportWebApi.DAL.Repositories;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AirportWebApi.DAL.Models
{
    public class Crew : EntityBase
    {
        [Required]
        public int Pilot { get; set; }
        [Required]
        public List<int> FlightAttendants { get; set; }
    }
}
