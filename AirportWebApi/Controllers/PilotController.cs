using AirportApi.Models;
using AirportWebApi.BL;
using Microsoft.AspNetCore.Mvc;

namespace AirportWebAPI.Controllers
{
    [Produces("application/json")]
    [Route("/api/v1/crews/Pilots")]
    public class PilosController : Controller
    {
        private readonly IService<PilotDto> service;

        public PilosController(IService<PilotDto> service)
        {
            this.service = service;
        }

        // GET: /api/v1/crews/pilots/
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(service.GetAll());
        }

        // GET: /api/v1/pilots/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var item = service.GetById(id);
            return Ok(item);
        }

        // POST: /api/v1/crews/pilots/
        [HttpPost]
        public IActionResult Post([FromBody]PilotDto value)
        {
            var item = service.Add(value);
            if (item == null || !this.ModelState.IsValid)
            {
                return this.BadRequest();
            }
            else
            {
                return Ok(item);
            }
        }

        // PUT: /api/v1/pilots/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]PilotDto value)
        {
            var item = service.Update(value);
            if (item == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(item);
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var item = service.Remove(id);
            if (item == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(id);
            }
        }
    }
}
