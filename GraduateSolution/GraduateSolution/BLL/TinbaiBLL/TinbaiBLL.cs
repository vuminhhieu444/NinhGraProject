using GraduateSolution.Models;

namespace GraduateSolution.BLL.TinbaiBLL
{
    public class TinbaiBLL : ServiceBLL<TinBai>, ITinBaiBLL
    {
        public TinbaiBLL(IRepository<TinBai> repository) : base(repository)
        {
        }
    }
}
