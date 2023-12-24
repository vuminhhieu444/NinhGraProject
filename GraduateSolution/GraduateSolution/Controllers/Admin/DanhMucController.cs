using GraduateSolution.BLL.CategoryBLL;
using GraduateSolution.BLL.NguoiDungBLL;
using GraduateSolution.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GraduateSolution
{
    [Route("api/[controller]")]
    [ApiController]
    public class DanhMucController : ControllerBase
    {
        private readonly ICategoryBLL _categoryBLL;
        public DanhMucController(ICategoryBLL categoryBLL)
        {
            _categoryBLL = categoryBLL;
        }
        [HttpPost("Add")]
        public Task<int> Add([FromForm]DanhMuc danhMuc)
        {
            danhMuc.Madm = Guid.NewGuid().ToString();
            var res = _categoryBLL.AddAsync(danhMuc);
            return res;
        }
        [HttpPost("Update")]
        public Task<int> Update([FromForm] DanhMuc danhMuc)
        {
            var res = _categoryBLL.Update(danhMuc);
            return res;
        }
        [HttpPost("Delete")]
        public Task<int> Delete(string id)
        {
            var res = _categoryBLL.DeleteByIdAsync(id);
            return res;
        }
        [HttpGet("Get-List")]
        public Task<List<DanhMuc>> GetList()
        {
            var res = _categoryBLL.GetListAsync();
            return res;
        }
        [HttpGet("GetDanhMuc/{id}")]
        public Task<DanhMuc> GetDanMucById(string id)
        {
            var res = _categoryBLL.FindByIdAsync(id);
            return res;
        }
        [HttpGet("Paginate/{pageIndex}/{pageSize}")]
        public Task<PaginationModel<DanhMuc>> PaginationModel(string pageIndex, string pageSize)
        {
            var res = _categoryBLL.Paginate(pageIndex, pageSize);
            return res;
        }
    }
}
