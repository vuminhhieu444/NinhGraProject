using GraduateSolution.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GraduateSolution.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class DanhMucConController : ControllerBase
    {
        private readonly ISubCategoryBLL _subCategoryBLL;
        public DanhMucConController(ISubCategoryBLL subCategoryBLL)
        {
            _subCategoryBLL = subCategoryBLL;
        }
        [HttpPost("Add")]
        public Task<int> Add([FromForm] DanhMucCon danhMucCon)
        {
            danhMucCon.Madmc = Guid.NewGuid().ToString();
            var res = _subCategoryBLL.AddAsync(danhMucCon);
            return res;
        }
        [HttpPost("Update")]
        public Task<int> Update([FromForm] DanhMucCon danhMucCon)
        {
            var res = _subCategoryBLL.Update(danhMucCon);
            return res;
        }
        [HttpPost("Delete")]
        public Task<int> Delete(string id)
        {
            var res = _subCategoryBLL.DeleteByIdAsync(id);
            return res;
        }
        [HttpGet("GetListDanhMucCon")]
        public Task<List<DanhMucCon>> GetList()
        {
            var res = _subCategoryBLL.GetListAsync();
            return res;
        }
        [HttpGet("Get-Danh-Muc-Con/{id}")]
        public Task<DanhMucCon>GetDanhMucCon(string id)
        {
            var res = _subCategoryBLL.FindByIdAsync(id);
            return res;
        }
    }
}
