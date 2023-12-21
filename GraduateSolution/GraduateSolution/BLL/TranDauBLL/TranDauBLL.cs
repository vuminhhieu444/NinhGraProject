using GraduateSolution.Models;

namespace GraduateSolution
{
    public class TranDauBLL : ServiceBLL<TranDau>, ITranDauBLL
    {
        public TranDauBLL(IRepository<TranDau> repository) : base(repository)
        {
        }
    }
}
