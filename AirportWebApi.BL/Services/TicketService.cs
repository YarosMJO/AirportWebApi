using AirportWebApi.DAL.Models;
using AirportWebApi.DAL.Repositories;
using AutoMapper;
using Shared.Dtos;
using System.Collections.Generic;
using System.Linq;

namespace AirportWebApi.BL.Services
{

    public class TicketService : IService<TicketDto>
    {
        private readonly IRepository<Ticket> repository;
        private readonly IMapper mapper;

        public TicketService(IRepository<Ticket> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public TicketDto Add(TicketDto Ticket)
        {
            var item = repository.Add(mapper.Map<TicketDto, Ticket>(Ticket));
            if (item != null)
            {
                return mapper.Map<Ticket, TicketDto>(item);
            }
            else return null;
        }

        public TicketDto GetById(int id)
        {
            var item = repository.GetById(id);
            return mapper.Map<Ticket, TicketDto>(item);
        }

        public List<TicketDto> GetAll()
        {
            var item = repository.GetAll();
            return item.Select(mapper.Map<Ticket, TicketDto>).ToList();
        }

        public TicketDto Remove(int id)
        {
            return mapper.Map<Ticket, TicketDto>(repository.Remove(id));
        }

        public TicketDto Update(TicketDto Ticket)
        {
            var item = repository.Update(mapper.Map<TicketDto, Ticket>(Ticket));
            if (item != null)
            {
                return mapper.Map<Ticket, TicketDto>(item);
            }
            else return null;
        }

        public void RemoveAll()
        {
            repository.RemoveAll();
        }
    }
}
