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
    public abstract class BaseService<T> : IService<T> where T is IEntity
    {
        private readonly ApplicationDbContext _context;

        public BaseService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<T> CreateAsync(T entity)
        {
            _context.Set<T>.Add(entity);
            await _context.SaveChangesAsync();
            return (footballer);
        }

        public async Task DeleteAsync(int id)
        {
            var footballer = await _context.Footballers.FindAsync(id);
            if (footballer == null)
            {
                throw new Exception("Futbolcu bulunamadı...");
            }

            _context.Footballers.Remove(footballer);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Footballer>> GetAllAsync()
        {
            return await _context.Set<T>.ToListAsync();
        }

        public async Task<Footballer> GetAsync(int id)
        {
            var footballer = await _context.Footballers.FindAsync(id);

            if (footballer == null)
            {
                throw new Exception("Futbolcu bulunamadı...");
            }

            return footballer;
        }

        public async Task UpdateAsync(int id, Footballer footballer)
        {
            if (id != footballer.Id)
            {
                throw new Exception("Futbolcu bulunamadı...");
            }

            _context.Entry(footballer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FootballerExists(id))
                {
                    throw new Exception("Futbolcu bulunamadı...");
                }
                else
                {
                    throw;
                }
            }

        }
        private bool FootballerExists(int id)
        {
            return _context.Footballers.Any(e => e.Id == id);
        }
    }
}
diff --git a/week-7/FootballManagerApi/FootballManagerApi/ServiceImplementations/FootballerService.cs b/week-7/FootballManagerApi/FootballManagerApi/ServiceImplementations/FootballerService.cs
