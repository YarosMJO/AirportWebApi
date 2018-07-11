using AirportWebApi.BL;
using AirportWebApi.DAL.Models;
using AirportWebApi.DAL.Repositories;
using AutoMapper;
using Shared.Dtos;
using System.Collections.Generic;
using System.Linq;

namespace AirportWebAPI.BL
{
    public class PilotService : IService<HouseDto>
    {
        private readonly IRepository<HouseModel> repository;
        private readonly IMapper mapper;

        public PilotService(IRepository<HouseModel> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public HouseDto AddEntry(HouseDto pilot)
        {
            var temp = repository.AddEntry(mapper.Map<HouseDto, HouseModel>(pilot));
            if (temp == null)
            {
                return null;
            }
            else
            {
                return mapper.Map<HouseModel, HouseDto>(temp);
            }
        }

        public HouseDto GetById(int id)
        {
            var temp = repository.GetById(id);
            return mapper.Map<HouseModel, HouseDto>(temp);
        }

        public List<HouseDto> GetAll()
        {
            var temp = repository.GetAll();
            return temp.Select(mapper.Map<HouseModel, HouseDto>).ToList();
        }

        public HouseDto RemoveEntry(int id)
        {
            return mapper.Map<HouseModel, HouseDto>(repository.RemoveEntity(id));
        }

        public HouseDto UpdateEntry(HouseDto pilot)
        {
            var temp = repository.UpdateEntity(mapper.Map<HouseDto, HouseModel>(pilot));
            if (temp == null)
            {
                return null;
            }
            else
            {
                return mapper.Map<HouseModel, HouseDto>(temp);
            }
        }
    }
}
