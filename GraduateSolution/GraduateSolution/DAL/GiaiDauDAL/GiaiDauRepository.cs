using GraduateSolution.Models;

namespace GraduateSolution
{
    public class GiaiDauRepository : Repository<GiaiDau>, IGiaiDauRepository
    {
        public GiaiDauRepository(foot_ball_sourceContext context) : base(context)
        {
        }
    }
}
