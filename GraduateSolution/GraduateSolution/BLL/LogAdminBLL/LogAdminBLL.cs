using GraduateSolution.Models;

namespace GraduateSolution
{
    public class LogAdminBLL : ServiceBLL<LogAdmin>, ILogAdminBLL
    {
        public LogAdminBLL(IRepository<LogAdmin> repository) : base(repository)
        {
        }
    }
}
