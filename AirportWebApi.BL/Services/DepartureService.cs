using AirportWebApi.DAL.Models;
using AirportWebApi.DAL.Repositories;
using AutoMapper;
using Shared.Dtos;
using System.Collections.Generic;
using System.Linq;
namespace AirportWebApi.BL.Services
{
    public class DepartureService : IService<DeparturesDto>
    {
        private readonly IRepository<Departure> repository;
        private readonly IMapper mapper;

        public DepartureService(IRepository<Departure> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public DeparturesDto Add(DeparturesDto Departure)
        {
            var item = repository.Add(mapper.Map<DeparturesDto, Departure>(Departure));
            if (item != null)
            {
                return mapper.Map<Departure, DeparturesDto>(item);
            }
            else return null;
        }

        public DeparturesDto GetById(int id)
        {
            var item = repository.GetById(id);
            return mapper.Map<Departure, DeparturesDto>(item);
        }

        public List<DeparturesDto> GetAll()
        {
            var item = repository.GetAll();
            return item.Select(mapper.Map<Departure, DeparturesDto>).ToList();
        }

        public DeparturesDto Remove(int id)
        {
            return mapper.Map<Departure, DeparturesDto>(repository.Remove(id));
        }

        public DeparturesDto Update(DeparturesDto Departure)
        {
            var item = repository.Update(mapper.Map<DeparturesDto, Departure>(Departure));
            if (item != null)
            {
                return mapper.Map<Departure, DeparturesDto>(item);
            }
            else return null;
        }
        public void RemoveAll()
        {
            repository.RemoveAll();
        }
    }
}
