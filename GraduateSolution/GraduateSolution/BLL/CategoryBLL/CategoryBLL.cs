using GraduateSolution.BLL.CategoryBLL;
using GraduateSolution.Models;

namespace GraduateSolution
{
    public class CategoryBLL :ServiceBLL<DanhMuc>, ICategoryBLL 
    {
        public CategoryBLL(IRepository<DanhMuc> repository) : base(repository)
        {
        }
    }
}
