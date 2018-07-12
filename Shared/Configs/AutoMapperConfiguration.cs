using AirportApi.Models;
using AutoMapper;

namespace Shared
{
    public class AutoMapperConfiguration
    {
        public MapperConfiguration Configure()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Ticket, TicketDto>();

                cfg.CreateMap<Flight, FlightDto>();
                cfg.CreateMap<Departure, DeparturesDto>();

                cfg.CreateMap<Crew, CrewDto>();
                cfg.CreateMap<Pilot, PilotDto>();
                cfg.CreateMap<FlightAttendant, FlightAttendantDto>();

                cfg.CreateMap<Plane, PlaneDto>();
                cfg.CreateMap<PlaneType, PlaneTypeDto>();

            });

            return config;
        }
    }
}
