using GraduateSolution.Models;

namespace GraduateSolution
{
    public class BinhLuanRepository : Repository<BinhLuan>, IBinhLuanRepository
    {
        public BinhLuanRepository(foot_ball_sourceContext context) : base(context)
        {
        }
    }
}
