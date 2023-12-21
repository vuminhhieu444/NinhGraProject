using GraduateSolution.Models;

namespace GraduateSolution
{
    public class XepHangBLL : ServiceBLL<XepHang>, IXepHangBLL
    {
        public XepHangBLL(IRepository<XepHang> repository) : base(repository)
        {
        }
    }
}
