using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FootballManagerApi.Data;
using FootballManagerApi.Entities;
using FootballManagerApi.ServiceImplementations;

namespace FootballManagerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FootballersController : ControllerBase
    {
        private readonly FootballerService _footballerService;

        public FootballersController(ApplicationDbContext context)
        {
            _footballerService = new FootballerService(context);
        }

        // GET: api/Footballers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Footballer>>> GetFootballers()
        {
            return Ok(await _footballerService.GetAllAsync());
        }

        // GET: api/Footballers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Footballer>> GetFootballer(int id)
        {
            return await _footballerService.GetAsync(id);
        }

        // PUT: api/Footballers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFootballer(int id, Footballer footballer)
        {
            await _footballerService.UpdateAsync(id, footballer);

            return NoContent();
        }

        // POST: api/Footballers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Footballer>> PostFootballer(Footballer footballer)
        {
            await _footballerService.CreateAsync(footballer);

            return CreatedAtAction("GetFootballer", new { id = footballer.Id }, footballer);
        }

        // DELETE: api/Footballers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFootballer(int id)
        {

            await _footballerService.DeleteAsync(id);
            return NoContent();
        }

  
    }
}
