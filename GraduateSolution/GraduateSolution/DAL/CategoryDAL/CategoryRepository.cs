using GraduateSolution.Models;

namespace GraduateSolution
{
    public class CategoryRepository:Repository<DanhMuc>, ICategoryRepository
    {
        public CategoryRepository(foot_ball_sourceContext context):base(context)
        {
        }
    }
}
