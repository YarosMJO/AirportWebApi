using AirportWebApi.DAL.Models;
using AirportWebApi.DAL.Repositories;
using AutoMapper;
using Shared.Dtos;
using System.Collections.Generic;
using System.Linq;

namespace AirportWebApi.BL.Services
{
    public class CrewService : IService<CrewDto>
    {
        private readonly IRepository<Crew> repository;
        private readonly IMapper mapper;

        public CrewService(IRepository<Crew> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public CrewDto Add(CrewDto crew)
        {
            var item = repository.Add(mapper.Map<CrewDto, Crew>(crew));
            if (item != null)
            {
                return mapper.Map<Crew, CrewDto>(item);
            }
            else return null;
        }

        public CrewDto GetById(int id)
        {
            var item = repository.GetById(id);
            return mapper.Map<Crew, CrewDto>(item);
        }

        public List<CrewDto> GetAll()
        {
            var item = repository.GetAll();
            return item.Select(mapper.Map<Crew, CrewDto>).ToList();
        }

        public CrewDto Remove(int id)
        {
            return mapper.Map<Crew, CrewDto>(repository.Remove(id));
        }

        public CrewDto Update(CrewDto crew)
        {
            var item = repository.Update(mapper.Map<CrewDto, Crew>(crew));
            if (item != null)
            {
                return mapper.Map<Crew, CrewDto>(item);
            }
            else return null;
        }
    }
}
