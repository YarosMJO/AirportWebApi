using AirportWebApi.BL;
using Microsoft.AspNetCore.Mvc;
using Shared.Dtos;

namespace AirportWebApi.Controllers
{
    [Produces("application/json")]
    [Route("/api/v1/planes/")]
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
            var items = service.GetAll();
            if (items != null) return Ok(items);
            return NoContent();
        }

        // GET: /api/v1/planes/5
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

        // POST: /api/v1/planes/
        [HttpPost]
        public IActionResult Post([FromBody]PlaneDto value)
        {
            if (ModelState.IsValid)
            {
                var item = service.Add(value);
                if (item != null) return Ok(item);
            }
            return BadRequest();
        }

        // PUT: /api/v1/planes/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]PlaneDto value)
        {
            if (ModelState.IsValid)
            {
                var item = service.Update(value);
                if (item != null) return Ok(item);
            }
            return BadRequest();
        }

        // DELETE: /api/v1/planes/5
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

        // DELETE: /api/v1/planes/
        [HttpDelete]
        public IActionResult Delete()
        {
            service.RemoveAll();
            return Ok("All clean");
        }
    }
}