using GraduateSolution.Models;

namespace GraduateSolution
{
    public class XepHangRepository : Repository<XepHang>, IXepHangRepository
    {
        public XepHangRepository(foot_ball_sourceContext context) : base(context)
        {
        }
    }
}
