using GraduateSolution.Models;

namespace GraduateSolution
{
    public class AnhRepository : Repository<Anh>, IAnhRepository
    {
        public AnhRepository(foot_ball_sourceContext context) : base(context)
        {
        }
    }
}
