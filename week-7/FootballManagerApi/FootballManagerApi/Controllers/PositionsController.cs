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
    public class PositionsController : ControllerBase
    {
        private readonly PositionService _positionService;

        public PositionsController(ApplicationDbContext context)
        {
            _positionService = new PositionService(context);
        }

        // GET: api/Positions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Position>>> GetPositions()
        {
            return Ok(await _positionService.GetAllAsync());
        }

        // GET: api/Positions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Position>> GetPosition(int id)
        {
            return await _positionService.GetAsync(id);
        }

        // PUT: api/Positions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPosition(int id, Position position)
        {
            await _positionService.UpdateAsync(id, position);
            return NoContent();
        }

        // POST: api/Positions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Position>> PostPosition(Position position)
        {
            await _positionService.CreateAsync(position);
            return CreatedAtAction("GetPosition", new { id = position.Id }, position);
        }

        // DELETE: api/Positions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePosition(int id)
        {
            await _positionService.DeleteAsync(id);
            return NoContent();
        }


    }
}
