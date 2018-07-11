using AirportWebApi.BL;
using Microsoft.AspNetCore.Mvc;
using Shared.Dtos;

namespace AirportWebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Pilots")]
    public class PilosController : Controller
    {
        private readonly IService<HouseDto> service;

        public PilosController(IService<HouseDto> service)
        {
            this.service = service;
        }

        // GET: api/Pilots
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(service.GetAll());
        }

        // GET: api/Pilots/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var temp = service.GetById(id);
            if (temp == null) return NotFound("Pilot with this ID not found");
            return Ok(temp);
        }

        // POST: api/Pilots
        [HttpPost]
        public IActionResult Post([FromBody]HouseDto value)
        {
            var temp = service.AddEntry(value);
            if (temp == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(temp);
            }
        }

        // PUT: api/Pilots/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]HouseDto value)
        {
            var temp = service.UpdateEntry(value);
            if (temp == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(temp);
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var temp = service.RemoveEntry(id);
            if (temp == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(string.Format("Pilot with ID {0} was successfuly deleted", temp.Id));
            }
        }
    }
}
