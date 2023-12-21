using GraduateSolution.Models;

namespace GraduateSolution
{
    public class TranDauRepository : Repository<TranDau>, ITranDauRepository
    {
        public TranDauRepository(foot_ball_sourceContext context) : base(context)
        {
        }
    }
}
