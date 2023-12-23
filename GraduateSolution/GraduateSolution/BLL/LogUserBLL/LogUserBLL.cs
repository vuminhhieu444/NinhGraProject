using GraduateSolution.Models;

namespace GraduateSolution
{
    public class LogUserBLL : ServiceBLL<LogUser>, ILogUserBLL
    {
        public LogUserBLL(IRepository<LogUser> repository) : base(repository)
        {
        }
    }
}
