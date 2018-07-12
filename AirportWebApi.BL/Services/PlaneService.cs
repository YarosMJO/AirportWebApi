using AirportWebApi.DAL.Models;
using AirportWebApi.DAL.Repositories;
using AutoMapper;
using Shared.Dtos;
using System.Collections.Generic;
using System.Linq;

namespace AirportWebApi.BL.Services
{
    public class PlaneService : IService<PlaneDto>
    {
        private readonly IRepository<Crew> repository;
        private readonly IMapper mapper;

        public PlaneService(IRepository<Crew> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public PlaneDto Add(PlaneDto crew)
        {
            var item = repository.Add(mapper.Map<PlaneDto, Crew>(crew));
            if (item != null)
            {
                return mapper.Map<Crew, PlaneDto>(item);
            }
            else return null;
        }

        public PlaneDto GetById(int id)
        {
            var item = repository.GetById(id);
            return mapper.Map<Crew, PlaneDto>(item);
        }

        public List<PlaneDto> GetAll()
        {
            var item = repository.GetAll();
            return item.Select(mapper.Map<Crew, PlaneDto>).ToList();
        }

        public PlaneDto Remove(int id)
        {
            return mapper.Map<Crew, PlaneDto>(repository.Remove(id));
        }

        public PlaneDto Update(PlaneDto crew)
        {
            var item = repository.Update(mapper.Map<PlaneDto, Crew>(crew));
            if (item != null)
            {
                return mapper.Map<Crew, PlaneDto>(item);
            }
            else return null;
        }
    }
}
