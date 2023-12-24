using GraduateSolution.Models;

namespace GraduateSolution
{
    public class BinhLuanBLL : ServiceBLL<BinhLuan>, IBinhLuanBLL
    {
        public BinhLuanBLL(IRepository<BinhLuan> repository) : base(repository)
        {
        }
    }
}
