using IMDB;
using IMDB.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace IMDB.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrewController : ControllerBase
    {
        private readonly ApplicationDBContext _dbContext;
        public CrewController(ApplicationDBContext dBContext)
        {
            _dbContext = dBContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var crews = _dbContext.Crew.ToList();
            return Ok(crews);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var crews = _dbContext.Crew.ToList();
            var idCrew = crews[0];
            foreach (var c in crews)
            {
                if (c.CrewID == id)
                {
                    idCrew = c;
                }
            }
            return Ok(idCrew);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Crew crew)
        {
            _dbContext.Crew.Add(crew);
            _dbContext.SaveChanges();
            return Ok();
        }

        // PUT api/<MovieController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Crew crew)
        {
            var crews = _dbContext.Crew.ToList();
            var idCrew = crews[0];
            foreach (var c in crews)
            {
                if (c.CrewID == id)
                {
                    idCrew = c;
                }
            }
            idCrew.CrewName = crew.CrewName;
            idCrew.CrewSurname = crew.CrewSurname;
            idCrew.CrewAge = crew.CrewAge;
            idCrew.CrewBio = crew.CrewBio;
            idCrew.MovieActors = crew.MovieActors;
            _dbContext.SaveChanges();
            return Ok();
        }

        // DELETE api/<MovieController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var crews = _dbContext.Crew.ToList();
            var idCrew = crews[0];
            foreach (var c in crews)
            {
                if (c.CrewID == id)
                {
                    idCrew = c;
                    _dbContext.Crew.Remove(idCrew);
                    _dbContext.SaveChanges();
                }
            }
            return Ok();
        }
    }
}
