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
    public class NationalTeamsController : ControllerBase
    {
        private readonly NationalTeamService _nationalTeamService;

        public NationalTeamsController(ApplicationDbContext context)
        {
            _nationalTeamService = new NationalTeamService(context);    
        }

        // GET: api/NationalTeams
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NationalTeam>>> GetNationalTeams()
        {
            return Ok(await _nationalTeamService.GetAllAsync());
        }

        // GET: api/NationalTeams/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NationalTeam>> GetNationalTeam(int id)
        {
            return await _nationalTeamService.GetAsync(id);
        }

        // PUT: api/NationalTeams/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNationalTeam(int id, NationalTeam nationalTeam)
        {
            await _nationalTeamService.UpdateAsync(id,nationalTeam);
            return NoContent();
        }

        // POST: api/NationalTeams
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<NationalTeam>> PostNationalTeam(NationalTeam nationalTeam)
        {
            await _nationalTeamService.CreateAsync(nationalTeam);
            return CreatedAtAction("GetNationalTeam", new { id = nationalTeam.Id }, nationalTeam);
        }

        // DELETE: api/NationalTeams/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNationalTeam(int id)
        {
            await _nationalTeamService.DeleteAsync(id);
            return NoContent();
        }
    }
}
