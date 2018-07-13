using AirportWebApi.DAL.Models;
using System;
using System.Collections.Generic;

namespace Repositories.Seeder
{
    public class Seeder
    {
        public readonly List<Pilot> Pilots = new List<Pilot>()
      {
           new Pilot(){ Id=1,Name="Nikolas", Surname="Morreti",Birthday=new DateTime(2015, 7, 19),Experience=1},
                new Pilot(){ Id=2,Name="Alessio", Surname="Rossi",Birthday=new DateTime(2004, 6, 21),Experience=3},
                new Pilot(){ Id=3,Name="Gennaro", Surname="Calabresi",Birthday=new DateTime(2014, 3, 17),Experience=4},
                new Pilot(){ Id=4,Name="Beppe", Surname="Mancini",Birthday=new DateTime(2006, 1, 20),Experience=7},
                new Pilot(){ Id=5,Name="Adelaide", Surname="Giordano",Birthday=new DateTime(1998, 8, 14),Experience=2}
      };

        public readonly List<FlightAttendant> FlightAttendants = new List<FlightAttendant>()
      {
           new FlightAttendant(){ Id=1,Name="Natali", Surname="Smith",Birthday=new DateTime(2015, 7, 19)},
                new FlightAttendant(){ Id=2,Name="Maria", Surname="Johnson",Birthday=new DateTime(2004, 6, 21)},
                new FlightAttendant(){ Id=3,Name="Kate", Surname="	Williams",Birthday=new DateTime(2014, 3, 17)},
                new FlightAttendant(){ Id=4,Name="Mila", Surname="Jones",Birthday=new DateTime(2006, 1, 20)},
                new FlightAttendant(){ Id=5,Name="Olia", Surname="Howard",Birthday=new DateTime(1998, 8, 14)}
      };

        public readonly List<Crew> Crews = new List<Crew>()
        {
            new Crew(){Id=1,Pilot=1,FlightAttendants = new List<int>(){1,3,5}},
            new Crew(){Id=2,Pilot=5,FlightAttendants = new List<int>(){1,2,4}},
            new Crew(){Id=3,Pilot=4,FlightAttendants = new List<int>(){5,1,3}}
        };

        static DateTime now = DateTime.Now;
        static TimeSpan span = now.AddYears(1) - now;
        public readonly List<Plane> Planes = new List<Plane>()
        {
            new Plane(){ Id = 1,Name="Ан-1",Type = 1,LifeTime = span,ReleaseDate = now},
            new Plane(){ Id = 2,Name="Ан-2",Type = 2,LifeTime = span,ReleaseDate = now},
            new Plane(){ Id = 3,Name="Ан-3",Type = 3,LifeTime = span,ReleaseDate = now},
            new Plane(){ Id = 4,Name="Ан-1",Type = 1,LifeTime = span,ReleaseDate = now},
            new Plane(){ Id = 5,Name="Ан-2",Type = 2,LifeTime = span,ReleaseDate = now}
        };

        public readonly List<PlaneType> PlaneTypes = new List<PlaneType>()
        {
            new PlaneType(){Id = 1,Carrying = 100, LifeTime = span,Model="Model1",SeatsCapacity = 120},
            new PlaneType(){Id = 2,Carrying = 95, LifeTime = span,Model="Model2",SeatsCapacity = 100},
            new PlaneType(){Id = 3,Carrying = 87, LifeTime = span,Model="Model3",SeatsCapacity = 80},

        };
        public readonly List<Flight> Flights = new List<Flight>()
        {
            new Flight(){Id=1,ArrivalTime=now,DeparturePoint = "Adelaida",DepartureTime = now, Destination="Boston",
                Tickets = new List<int>(){1,2,3} },
            new Flight(){Id=2,ArrivalTime=now,DeparturePoint = "Oslo",DepartureTime = now, Destination="Alabama",
                Tickets = new List<int>(){4,5,6} },
            new Flight(){Id=3,ArrivalTime=now,DeparturePoint = "Pitsburg",DepartureTime = now, Destination="NewYork",
                Tickets = new List<int>(){7,8,9} },
            new Flight(){Id=4,ArrivalTime=now,DeparturePoint = "Pitsburg",DepartureTime = now, Destination="NewYork",
                Tickets = new List<int>(){10,11,12} },
            new Flight(){Id=5,ArrivalTime=now,DeparturePoint = "Pitsburg",DepartureTime = now, Destination="NewYork",
                Tickets = new List<int>(){13,14,15,16} }
        };
        public readonly List<Ticket> Tickets = new List<Ticket>() {
            new Ticket() {Id = 1,Price = 50,FlightNumber = 1},
            new Ticket() {Id = 2,Price = 60,FlightNumber = 1},
            new Ticket() {Id = 3,Price = 70,FlightNumber = 1},
            new Ticket() {Id = 4,Price = 80,FlightNumber = 2},
            new Ticket() {Id = 5,Price = 90,FlightNumber = 2},
            new Ticket() {Id = 6,Price = 50,FlightNumber = 2},
            new Ticket() {Id = 7,Price = 50,FlightNumber = 3},
            new Ticket() {Id = 8,Price = 40,FlightNumber = 3},
            new Ticket() {Id = 9,Price = 20,FlightNumber = 3},
            new Ticket() {Id = 10,Price = 50,FlightNumber = 4},
            new Ticket() {Id = 11,Price = 50,FlightNumber = 4},
            new Ticket() {Id = 12,Price = 70,FlightNumber = 4},
            new Ticket() {Id = 13,Price = 70,FlightNumber = 5},
            new Ticket() {Id = 14,Price = 10,FlightNumber = 5},
            new Ticket() {Id = 15,Price = 20,FlightNumber = 5},
            new Ticket() {Id = 16,Price = 100,FlightNumber = 5}
        };

        public readonly List<Departure> departures = new List<Departure>()
        {
            new Departure(){Id = 1,Crew=1,DepartureDate= now,FlightNumber=1,Plane=1},
            new Departure(){Id = 2,Crew=2,DepartureDate= now,FlightNumber=1,Plane=2},
            new Departure(){Id = 3,Crew=3,DepartureDate= now,FlightNumber=1,Plane=3},
            new Departure(){Id = 4,Crew=1,DepartureDate= now,FlightNumber=1,Plane=4},
            new Departure(){Id = 5,Crew=2,DepartureDate= now,FlightNumber=1,Plane=5}
        };

    }
}
