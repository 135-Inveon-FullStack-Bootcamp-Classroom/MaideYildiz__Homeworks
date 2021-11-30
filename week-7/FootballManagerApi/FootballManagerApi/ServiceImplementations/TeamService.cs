using FootballManagerApi.Data;
using FootballManagerApi.Entities;
using FootballManagerApi.ServiceAbstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballManagerApi.ServiceImplementations
{
    public class TeamService : ITeamService
    {
        private readonly ApplicationDbContext _context;
        public TeamService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Team> CreateAsync(Team team)
        {
            _context.Teams.Add(team);
            await _context.SaveChangesAsync();

            return team;
        }

        public async Task DeleteAsync(int id)
        {
            var team = await _context.Teams.FindAsync(id);
            if (team == null)
            {
                throw new Exception("team bulunamadı");
            }

            _context.Teams.Remove(team);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Team>> GetAllAsync()
        {
            return await _context.Teams.ToListAsync();
        }

        //public Task<IEnumerable<Team>> GetAllWithFootballersAsync()
        //{
        //    throw new System.NotImplementedException();
        //}

        public async Task<Team> GetAsync(int id)
        {
            var team = await _context.Teams.FindAsync(id);
            return team;
        }

        public async Task UpdateAsync(int id, Team team)
        {
            if (id != team.Id)
            {
                throw new Exception("id bulunamadı");
            }

            _context.Entry(team).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeamExists(id))
                {
                    throw new Exception("team bulunamadı");
                }
                else
                {
                    throw;
                }
            }
        }

        private bool TeamExists(int id)
        {
            return _context.Teams.Any(e => e.Id == id);
        }
    }
}
