using GraduateSolution.Models;

namespace GraduateSolution
{
    public class LogUserRepository : Repository<LogUser>, ILogUserRepository
    {
        public LogUserRepository(foot_ball_sourceContext context) : base(context)
        {
        }
    }
}
