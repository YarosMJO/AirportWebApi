using AirportWebApi.BL;
using Microsoft.AspNetCore.Mvc;
using Shared.Dtos;

namespace AirportWebApi.Controllers
{
    [Produces("application/json")]
    [Route("/api/v1/departures/id/planes/")]
    public class PlaneController : Controller
    {
        private readonly IService<PlaneDto> service;

        public PlaneController(IService<PlaneDto> service)
        {
            this.service = service;
        }

        // GET: /api/v1/planes/
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(service.GetAll());
        }
        [Route("/api/v1/planes/")]
        // GET: /api/v1/planes/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var item = service.GetById(id);
            if (item == null) return NotFound();
            return Ok(item);
        }

        // POST: /api/v1/planes/
        [HttpPost]
        public IActionResult Post([FromBody]PlaneDto value)
        {
            var item = service.Add(value);
            if (item == null || !this.ModelState.IsValid)
            {
                return BadRequest("");
            }
            else return Ok(item);
        }

        // PUT: /api/v1/planes/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]PlaneDto value)
        {
            var item = service.Update(value);
            if (item != null) return Ok(item);
            else return BadRequest();
        }

        // DELETE: /api/v1/planes/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var item = service.Remove(id);
            if (item != null) return Ok(id);
            else return NotFound();
        }
    }
}