using GraduateSolution.Models;
using Microsoft.EntityFrameworkCore;

namespace GraduateSolution
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly foot_ball_sourceContext _repository;

        public Repository(foot_ball_sourceContext context)
        {
            _repository = context;
        }

        public async Task<int> AddEntityAsync(T entity)
        {
            try
            {
                _repository.Add(entity);
                await _repository.SaveChangesAsync();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public async Task<int> DeleteByIdAsync(string id)
        {
            try
            {
                var data = _repository.Set<T>().Find(id);
                _repository.Remove(data);
                await _repository.SaveChangesAsync();
                return 1;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public async Task<T> FindByIdAsync(string id)
        {
            var data = await _repository.Set<T>().FindAsync(id);
            return data;
        }

        public async Task<List<T>> GetAll()
        {
            var listData = await _repository.Set<T>().ToListAsync();
            return listData;
        }

        public async Task<bool> IsExist(string id)
        {
            var data = await _repository.Set<T>().FindAsync(id);
            return data != null ? true : false;
        }

        public async Task<int> UpdateByIdAsync(T entity)
        {
            try
            {
                _repository.Update(entity);
                await _repository.SaveChangesAsync();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
