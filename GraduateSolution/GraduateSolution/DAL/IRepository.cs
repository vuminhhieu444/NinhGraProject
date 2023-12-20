namespace GraduateSolution
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAll();
        Task<T> FindByIdAsync(string id);
        Task<int> DeleteByIdAsync(string id);
        Task<int> UpdateByIdAsync(T entity);
        Task<int> AddEntityAsync(T entity);
        Task<bool> IsExist(string id);
    }
}
