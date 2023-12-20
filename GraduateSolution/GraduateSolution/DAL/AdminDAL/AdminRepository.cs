using GraduateSolution.Models;

namespace GraduateSolution.DAL.AdminDAL
{
    public class AdminRepository : Repository<Admin>, IAdminRepository
    {
        public AdminRepository(foot_ball_sourceContext context) : base(context)
        {
        }
    }
}
