using GraduateSolution.Models;

namespace GraduateSolution
{
    public class AnhBLL : ServiceBLL<Anh>, IAnhBLL
    {
        public AnhBLL(IRepository<Anh> repository) : base(repository)
        {
        }
    }
}
