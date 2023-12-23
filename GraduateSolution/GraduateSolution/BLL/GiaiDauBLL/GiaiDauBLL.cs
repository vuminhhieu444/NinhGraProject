using GraduateSolution.Models;

namespace GraduateSolution
{
    public class GiaiDauBLL : ServiceBLL<GiaiDau>, IGiaiDauBLL
    {
        public GiaiDauBLL(IRepository<GiaiDau> repository) : base(repository)
        {
        }
    }
}
