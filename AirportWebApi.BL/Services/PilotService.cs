using AirportWebApi.DAL.Models;
using AirportWebApi.DAL.Repositories;
using AutoMapper;
using Shared.Dtos;
using System.Collections.Generic;
using System.Linq;

namespace AirportWebApi.BL.Services
{
    public class PilotService : IService<PilotDto>
    {
        private readonly IRepository<Pilot> repository;
        private readonly IMapper mapper;

        public PilotService(IRepository<Pilot> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public PilotDto Add(PilotDto pilot)
        {
            var item = repository.Add(mapper.Map<PilotDto, Pilot>(pilot));
            if (item != null)
            {
                return mapper.Map<Pilot, PilotDto>(item);
            }
            else return null;
        }

        public PilotDto GetById(int id)
        {
            var item = repository.GetById(id);
            return mapper.Map<Pilot, PilotDto>(item);
        }

        public List<PilotDto> GetAll()
        {
            var item = repository.GetAll();
            return item.Select(mapper.Map<Pilot, PilotDto>).ToList();
        }

        public PilotDto Remove(int id)
        {
            return mapper.Map<Pilot, PilotDto>(repository.Remove(id));
        }

        public PilotDto Update(PilotDto pilot)
        {
            var item = repository.Update(mapper.Map<PilotDto, Pilot>(pilot));
            if (item != null)
            {
                return mapper.Map<Pilot, PilotDto>(item);
            }
            else return null;
        }

        public void RemoveAll()
        {
            repository.RemoveAll();
        }
    }
}
