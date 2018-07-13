using AirportWebApi.BL;
using Microsoft.AspNetCore.Mvc;
using Shared.Dtos;

namespace AirportWebApi.Controllers
{
    [Produces("application/json")]
    [Route("/api/v1/tickets/")]
    public class TicketController : Controller
    {
        private readonly IService<TicketDto> service;

        public TicketController(IService<TicketDto> service)
        {
            this.service = service;
        }

        // GET: /api/v1/tickets/
        [HttpGet]
        public IActionResult Get()
        {
            var items = service.GetAll();
            if (items != null) return Ok(items);
            return NoContent();
        }

        // GET: /api/v1/tickets/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (ModelState.IsValid)
            {
                var item = service.GetById(id);
                if (item != null) return Ok(item);
            }
            return NotFound();
        }

        // POST: /api/v1/tickets/
        [HttpPost]
        public IActionResult Post([FromBody]TicketDto value)
        {
            if (ModelState.IsValid)
            {
                var item = service.Add(value);
                if (item != null) return Ok(item);
            }
            return BadRequest();
        }

        // PUT: /api/v1/tickets/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]TicketDto value)
        {
            if (ModelState.IsValid)
            {
                var item = service.Update(value);
                if (item != null) return Ok(item);
            }
            return BadRequest();
        }

        // DELETE: /api/v1/tickets/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                var item = service.Remove(id);
                if (item != null) return NoContent();
            }
            return NotFound();
        }
    }
}