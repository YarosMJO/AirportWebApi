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
        private readonly IRepository<Plane> repository;
        private readonly IMapper mapper;

        public PlaneService(IRepository<Plane> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public PlaneDto Add(PlaneDto Plane)
        {
            var item = repository.Add(mapper.Map<PlaneDto, Plane>(Plane));
            if (item != null)
            {
                return mapper.Map<Plane, PlaneDto>(item);
            }
            else return null;
        }

        public PlaneDto GetById(int id)
        {
            var item = repository.GetById(id);
            return mapper.Map<Plane, PlaneDto>(item);
        }

        public List<PlaneDto> GetAll()
        {
            var item = repository.GetAll();
            return item.Select(mapper.Map<Plane, PlaneDto>).ToList();
        }

        public PlaneDto Remove(int id)
        {
            return mapper.Map<Plane, PlaneDto>(repository.Remove(id));
        }

        public PlaneDto Update(PlaneDto Plane)
        {
            var item = repository.Update(mapper.Map<PlaneDto, Plane>(Plane));
            if (item != null)
            {
                return mapper.Map<Plane, PlaneDto>(item);
            }
            else return null;
        }

        public void RemoveAll()
        {
            repository.RemoveAll();
        }
    }
}
