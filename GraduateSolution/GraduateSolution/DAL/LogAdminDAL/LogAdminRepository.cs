using GraduateSolution.Models;

namespace GraduateSolution
{
    public class LogAdminRepository : Repository<LogAdmin>, ILogAdminRepositry
    {
        public LogAdminRepository(foot_ball_sourceContext context) : base(context)
        {
        }
    }
}
