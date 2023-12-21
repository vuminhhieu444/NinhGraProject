using GraduateSolution.Models;

namespace GraduateSolution
{
    public class DoiThiDauRepository : Repository<DoiThiDau>, IDoiThiDauRepository
    {
        public DoiThiDauRepository(foot_ball_sourceContext context) : base(context)
        {
        }
    }
}
