using AirportWebApi.DAL.Models;
using AirportWebApi.DAL.Repositories;
using AutoMapper;
using Shared.Dtos;
using System.Collections.Generic;
using System.Linq;

namespace AirportWebApi.BL.Services
{

    public class FlightAttendantService : IService<FlightAttendantDto>
    {
        private readonly IRepository<FlightAttendant> repository;
        private readonly IMapper mapper;

        public FlightAttendantService(IRepository<FlightAttendant> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public FlightAttendantDto Add(FlightAttendantDto FlightAttendant)
        {
            var item = repository.Add(mapper.Map<FlightAttendantDto, FlightAttendant>(FlightAttendant));
            if (item != null)
            {
                return mapper.Map<FlightAttendant, FlightAttendantDto>(item);
            }
            else return null;
        }

        public FlightAttendantDto GetById(int id)
        {
            var item = repository.GetById(id);
            return mapper.Map<FlightAttendant, FlightAttendantDto>(item);
        }

        public List<FlightAttendantDto> GetAll()
        {
            var item = repository.GetAll();
            return item.Select(mapper.Map<FlightAttendant, FlightAttendantDto>).ToList();
        }

        public FlightAttendantDto Remove(int id)
        {
            return mapper.Map<FlightAttendant, FlightAttendantDto>(repository.Remove(id));
        }

        public FlightAttendantDto Update(FlightAttendantDto FlightAttendant)
        {
            var item = repository.Update(mapper.Map<FlightAttendantDto, FlightAttendant>(FlightAttendant));
            if (item != null)
            {
                return mapper.Map<FlightAttendant, FlightAttendantDto>(item);
            }
            else return null;
        }
    }
}
