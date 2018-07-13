using AirportWebApi.BL;
using Microsoft.AspNetCore.Mvc;
using Shared.Dtos;

namespace AirportWebApi.Controllers
{
    [Produces("application/json")]
    [Route("/api/v1/Departures/")]
    public class DepartureController : Controller
    {
        private readonly IService<DeparturesDto> service;

        public DepartureController(IService<DeparturesDto> service)
        {
            this.service = service;
        }

        // GET: /api/v1/crews/id/Departures/
        //[Route("/api/v1/crews/{id}/Departures/")]
        //[HttpGet("{id}")]
        //public IActionResult GetAllOf(int id)
        //{
        //    //service.
        //    //return Ok(service.GetAllOf(id));
        //}

        // GET: /api/v1/Departures/
        [HttpGet]
        public IActionResult GetTotal()
        {
            return Ok(service.GetAll());
        }

        // GET: /api/v1/Departures/5
        [Route("/api/v1/Departures/{id}")]
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var item = service.GetById(id);
            if (item == null) return NotFound();
            return Ok(item);
        }

        // POST: /api/v1/Departures/
        [HttpPost]
        public IActionResult Post([FromBody]DeparturesDto value)
        {
            var item = service.Add(value);
            if (item == null || !this.ModelState.IsValid)
            {
                return BadRequest("");
            }
            else return Ok(item);
        }

        // PUT: /api/v1/Departures/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]DeparturesDto value)
        {
            var item = service.Update(value);
            if (item != null) return Ok(item);
            else return BadRequest();
        }

        // DELETE: /api/v1/Departures/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var item = service.Remove(id);
            if (item != null) return Ok(item);
            else return NotFound();
        }
    }
}