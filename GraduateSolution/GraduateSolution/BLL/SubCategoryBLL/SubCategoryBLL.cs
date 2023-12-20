using GraduateSolution.Models;

namespace GraduateSolution
{
    public class SubCategoryBLL : ServiceBLL<DanhMucCon>, ISubCategoryBLL
    {
        public SubCategoryBLL(IRepository<DanhMucCon> repository) : base(repository)
        {
        }
    }
}
