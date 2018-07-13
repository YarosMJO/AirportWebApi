using AirportWebApi.DAL.Models;
using AirportWebApi.DAL.Repositories;
using AutoMapper;
using Shared.Dtos;
using System.Collections.Generic;
using System.Linq;


namespace AirportWebApi.BL.Services
{
    public class FlightService : IService<FlightDto>
    {
        private readonly IRepository<Flight> repository;
        private readonly IMapper mapper;

        public FlightService(IRepository<Flight> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public FlightDto Add(FlightDto Flight)
        {
            var item = repository.Add(mapper.Map<FlightDto, Flight>(Flight));
            if (item != null)
            {
                return mapper.Map<Flight, FlightDto>(item);
            }
            else return null;
        }

        public FlightDto GetById(int id)
        {
            var item = repository.GetById(id);
            return mapper.Map<Flight, FlightDto>(item);
        }

        public List<FlightDto> GetAll()
        {
            var item = repository.GetAll();
            return item.Select(mapper.Map<Flight, FlightDto>).ToList();
        }

        public FlightDto Remove(int id)
        {
            return mapper.Map<Flight, FlightDto>(repository.Remove(id));
        }

        public FlightDto Update(FlightDto Flight)
        {
            var item = repository.Update(mapper.Map<FlightDto, Flight>(Flight));
            if (item != null)
            {
                return mapper.Map<Flight, FlightDto>(item);
            }
            else return null;
        }

        public void RemoveAll()
        {
            repository.RemoveAll();
        }
    }
}
