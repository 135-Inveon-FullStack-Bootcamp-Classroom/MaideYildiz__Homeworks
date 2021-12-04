using FootballManagerApi.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FootballManagerApi.ServiceAbstracts
{
    public interface IService<T> : where T is IEntity
    {
        public Task<IEnumerable<T>> GetAllAsync();
        public Task<T> GetAsync(int id);
        public Task UpdateAsync(int id, T footballer);
        public Task<T> CreateAsync(T footballer);
        public Task DeleteAsync(int id);
    }
}