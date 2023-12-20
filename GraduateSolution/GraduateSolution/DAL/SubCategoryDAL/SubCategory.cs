using GraduateSolution.Models;

namespace GraduateSolution
{
    public class SubCategory : Repository<DanhMucCon>, ISubCategory
    {
        public SubCategory(foot_ball_sourceContext context) : base(context)
        {
        }
    }
}
