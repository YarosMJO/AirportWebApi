using AirportApi.Models;
using AirportWebApi.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AirportWebAPI.DataAccessLayer.Repositories
{
    public class PilotRepository : IRepository<Pilot>
    {
        private List<Pilot> pilots;
        public PilotRepository()
        {
            pilots = new List<Pilot>
            {
                new Pilot(){ Id=1,Name="Nikolas", Surname="Morreti",Birthday=new DateTime(2015, 7, 19)},
                new Pilot(){ Id=2,Name="Alessio", Surname="Rossi",Birthday=new DateTime(2004, 6, 21)},
                new Pilot(){ Id=3,Name="Gennaro", Surname="Calabresi",Birthday=new DateTime(2014, 3, 17)},
                new Pilot(){ Id=4,Name="Beppe", Surname="Mancini",Birthday=new DateTime(2006, 1, 20)},
                new Pilot(){ Id=5,Name="Adelaide", Surname="Giordano",Birthday=new DateTime(1998, 8, 14)}
            };
        }

        public Pilot GetById(int id)
        {
            return pilots.Where(x => x?.Id == id).FirstOrDefault();
        }

        public IEnumerable<Pilot> GetAll()
        {
            return pilots;
        }

        public Pilot Add(Pilot pilot)
        {
            if (pilot != null)
            {
                pilots.Add(pilot);
                return pilot;
            }
            else return null;
        }

        public Pilot Update(Pilot item)
        {
            var pilot = pilots.Where(x => x?.Id == item?.Id).FirstOrDefault();
            if (pilot != null)
            {
                pilots.Remove(pilot);
                pilots.Add(item);
                return item;
            }
            else return null;
        }

        public Pilot Remove(int id)
        {
            var pilot = pilots.Where(x => x?.Id == id).FirstOrDefault();
            if (pilot != null)
            {
                pilots.Remove(pilot);
                return pilot;
            }
            else return null;
        }
    }
}
