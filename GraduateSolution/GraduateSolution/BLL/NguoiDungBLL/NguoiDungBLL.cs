using GraduateSolution.Models;

namespace GraduateSolution.BLL.NguoiDungBLL
{
    public class NguoiDungBLL : ServiceBLL<NguoiDung>, INguoiDungBLL
    {
        public NguoiDungBLL(IRepository<NguoiDung> repository) : base(repository)
        {
        }
    }
}
