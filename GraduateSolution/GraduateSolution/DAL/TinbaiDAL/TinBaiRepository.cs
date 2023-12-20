using GraduateSolution.Models;

namespace GraduateSolution
{
    public class TinBaiRepository : Repository<TinBai>, ITinbaiRepository
    {
        public TinBaiRepository(foot_ball_sourceContext context) : base(context)
        {
        }
    }
}
