namespace GraduateSolution
{
    public class ServiceBLL<T> : IServiceBLL<T> where T : class
    {
        private readonly IRepository<T> _repository;
        public ServiceBLL(IRepository<T> repository)
        {
            _repository = repository;
        }
        public async Task<int> AddAsync(T entity)
        {
            var res = await _repository.AddEntityAsync(entity);
            return res;
        }

        public async Task<int> DeleteByIdAsync(string id)
        {
            var res = await _repository.DeleteByIdAsync(id);
            return res;
        }

        public async Task<T> FindByIdAsync(string id)
        {
            try
            {
                var entity = await _repository.FindByIdAsync(id);
                if (entity == null)
                    throw new Exception();
                return entity;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public async Task<List<T>> GetListAsync()
        {
            try
            {
                return await _repository.GetAll();
            }
            catch (Exception)
            {
                return new List<T> { };
                throw;
            }
        }

        public Task<bool> IsExist(string id)
        {
            var res = _repository.IsExist(id);
            return res;
        }

        public async Task<int> Update(T entity)
        {
            var res = await _repository.UpdateByIdAsync(entity);
            return res;
        }
    }
}
