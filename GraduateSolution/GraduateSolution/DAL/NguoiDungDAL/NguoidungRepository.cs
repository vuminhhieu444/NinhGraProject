using GraduateSolution.Models;

namespace GraduateSolution.DAL.NguoiDungDAL
{
    public class NguoidungRepository : Repository<NguoiDung>, INguoidungRepository
    {
        public NguoidungRepository(foot_ball_sourceContext context) : base(context)
        {
        }
    }
}
