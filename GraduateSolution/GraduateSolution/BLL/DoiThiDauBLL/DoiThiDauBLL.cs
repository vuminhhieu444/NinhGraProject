using GraduateSolution.Models;

namespace GraduateSolution
{
    public class DoiThiDauBLL : ServiceBLL<DoiThiDau>, IDoiThiDauBLL
    {
        public DoiThiDauBLL(IRepository<DoiThiDau> repository) : base(repository)
        {
        }
    }
}
