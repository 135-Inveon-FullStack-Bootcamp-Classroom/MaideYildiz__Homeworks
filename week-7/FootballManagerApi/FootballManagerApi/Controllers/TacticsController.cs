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
    public class TacticsController : ControllerBase
    {
        private readonly TacticService _tacticService;

        public TacticsController(ApplicationDbContext context)
        {
            _tacticService = new TacticService(context);
        }

        // GET: api/Tactics
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tactic>>> GetTactics()
        {
            return Ok(await _tacticService.GetAllAsync());
        }

        // GET: api/Tactics/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tactic>> GetTactic(int id)
        {
            return await _tacticService.GetAsync(id);
        }

        // PUT: api/Tactics/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTactic(int id, Tactic tactic)
        {
            await _tacticService.UpdateAsync(id,tactic);
            return NoContent();
        }

        // POST: api/Tactics
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Tactic>> PostTactic(Tactic tactic)
        {
            await _tacticService.CreateAsync(tactic);
            return CreatedAtAction("GetTactic", new { id = tactic.Id }, tactic);
        }

        // DELETE: api/Tactics/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTactic(int id)
        {
            await _tacticService.DeleteAsync(id);
            return NoContent();
        }

        
    }
}
