using AirportWebApi.DAL.Models;
using AirportWebApi.DAL.Repositories;
using AutoMapper;
using Shared.Dtos;
using System.Collections.Generic;
using System.Linq;

namespace AirportWebApi.BL.Services
{
    public class PlaneTypeService : IService<PlaneTypeDto>
    {
        private readonly IRepository<PlaneType> repository;
        private readonly IMapper mapper;

        public PlaneTypeService(IRepository<PlaneType> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public PlaneTypeDto Add(PlaneTypeDto PlaneType)
        {
            var item = repository.Add(mapper.Map<PlaneTypeDto, PlaneType>(PlaneType));
            if (item != null)
            {
                return mapper.Map<PlaneType, PlaneTypeDto>(item);
            }
            else return null;
        }

        public PlaneTypeDto GetById(int id)
        {
            var item = repository.GetById(id);
            return mapper.Map<PlaneType, PlaneTypeDto>(item);
        }

        public List<PlaneTypeDto> GetAll()
        {
            var item = repository.GetAll();
            return item.Select(mapper.Map<PlaneType, PlaneTypeDto>).ToList();
        }

        public PlaneTypeDto Remove(int id)
        {
            return mapper.Map<PlaneType, PlaneTypeDto>(repository.Remove(id));
        }

        public PlaneTypeDto Update(PlaneTypeDto PlaneType)
        {
            var item = repository.Update(mapper.Map<PlaneTypeDto, PlaneType>(PlaneType));
            if (item != null)
            {
                return mapper.Map<PlaneType, PlaneTypeDto>(item);
            }
            else return null;
        }

        public void RemoveAll()
        {
            repository.RemoveAll();
        }
    }
}
