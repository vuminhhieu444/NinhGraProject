using GraduateSolution.Models;
using Microsoft.AspNetCore.Mvc;

namespace GraduateSolution
{
    [Route("api/[controller]")]
    [ApiController]
    public class BinhLuanController : ControllerBase
    {
        private readonly IBinhLuanBLL _binhLuanBLL;
        public BinhLuanController(IBinhLuanBLL binhLuanBLL)
        {
            _binhLuanBLL = binhLuanBLL;
        }
        [HttpPost("Add")]
        public Task<int> AddAdmin([FromForm] BinhLuan binhLuan)
        {
            binhLuan.MaBinhLuan = Guid.NewGuid().ToString();
            var res = _binhLuanBLL.AddAsync(binhLuan);
            return res;
        }
        [HttpPost("Update")]
        public Task<int> UpdateAdmin([FromForm] BinhLuan binhLuan)
        {
            var res = _binhLuanBLL.Update(binhLuan);
            return res;
        }
        [HttpPost("Delete")]
        public Task<int> DeleteAdmin(string id)
        {
            var res = _binhLuanBLL.DeleteByIdAsync(id);
            return res;
        }
        [HttpGet("Get-Admin_List")]
        public Task<List<BinhLuan>> GetList()
        {
            var res = _binhLuanBLL.GetListAsync();
            return res;
        }
        [HttpGet("GetAdmin/{id}")]
        public Task<BinhLuan> GetAdminById(string id)
        {
            var res = _binhLuanBLL.FindByIdAsync(id);
            return res;
        }
        [HttpPost("AdminLoginCheck")]
        public bool CheckLogin(string user, string pass)
        {
            return true;
        }
        [HttpGet("Paginate/{pageIndex}/{pageSize}")]
        public Task<PaginationModel<BinhLuan>> PaginationModel(string pageIndex, string pageSize)
        {
            var res = _binhLuanBLL.Paginate(pageIndex, pageSize);
            return res;
        }
        [HttpGet("Get-Binh-Luan-By-Tin-Bai/{id}")]
        public async Task<List<BinhLuan>> GetBinhLuanByIdTinBai(string id)
        {
            var listBinhLuan = _binhLuanBLL.GetListAsync();
            var res = listBinhLuan.Result.Where(m => m.MaTinBai.ToLower().Trim() == id.ToLower().Trim()).ToList();
            return res;
        }
    }
}
