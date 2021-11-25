using IMDB;
using IMDB.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IMDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly ApplicationDBContext _dbContext;
        public LocationController(ApplicationDBContext dBContext)
        {
            _dbContext = dBContext;
        }
        // GET: api/<MovieController>
        [HttpGet]
        public IActionResult Get()
        {
            var movies = _dbContext.Location.ToList();
            return Ok(movies);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var locations = _dbContext.Location.ToList();
            var idLocation = locations[0];
            foreach (var l in locations)
            {
                if (l.LocationID == id)
                {
                    idLocation = l;
                }
            }
            return Ok(idLocation);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Location location)
        {
            _dbContext.Location.Add(location);
            _dbContext.SaveChanges();
            return Ok();
        }

        // PUT api/<MovieController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Location location)
        {
            var locations = _dbContext.Location.ToList();
            var idLocation = locations[0];
            foreach (var l in locations)
            {
                if (l.LocationID == id)
                {
                    idLocation = l;
                }
            }
            idLocation.LocationName = location.LocationName;
            idLocation.MovieLocations = location.MovieLocations;
            _dbContext.SaveChanges();
            return Ok();
        }

        // DELETE api/<MovieController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var locations = _dbContext.Location.ToList();
            var idLocation = locations[0];
            foreach (var l in locations)
            {
                if (l.LocationID == id)
                {
                    idLocation = l;
                    _dbContext.Location.Remove(idLocation);
                    _dbContext.SaveChanges();
                }
            }
            return Ok();
        }
    }
}
