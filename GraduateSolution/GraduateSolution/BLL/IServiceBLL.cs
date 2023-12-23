namespace GraduateSolution
{
    public interface IServiceBLL<T> where T : class
    {
        Task<T> FindByIdAsync(string id);
        Task<int> Update(T entity);
        Task<int> DeleteByIdAsync(string id);
        Task<int> AddAsync(T entity);
        Task<List<T>> GetListAsync();
        Task<bool> IsExist(string id);
        Task<PaginationModel<T>> Paginate(string page, string pageSize);
    }
}
