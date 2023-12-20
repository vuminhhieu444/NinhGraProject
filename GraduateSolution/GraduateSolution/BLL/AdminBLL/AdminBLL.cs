using GraduateSolution.Models;

namespace GraduateSolution
{
    public class AdminBLL : ServiceBLL<Admin>, IAdminBLL
    {
        public AdminBLL(IRepository<Admin> repository) : base(repository)
        {
        }
    }
}
