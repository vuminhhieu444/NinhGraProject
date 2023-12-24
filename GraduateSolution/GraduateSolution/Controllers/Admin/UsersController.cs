using GraduateSolution.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GraduateSolution
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly  INguoiDungBLL _nguoiDungBLL;
        public UsersController(INguoiDungBLL nguoiDungBLL)
        {
            _nguoiDungBLL= nguoiDungBLL;
        }
        [HttpPost("Add")]
        public Task<int> AddUser([FromForm] NguoiDung nguoiDung)
        {
            nguoiDung.Manguoidung = Guid.NewGuid().ToString();
            var res= _nguoiDungBLL.AddAsync(nguoiDung);
            return res;
        }
        [HttpPost("Update")]
        public Task<int> UpdateUser([FromForm] NguoiDung nguoiDung)
        {
            var res = _nguoiDungBLL.Update(nguoiDung);
            return res;
        }
        [HttpGet("GetListUser")]
        public Task<List<NguoiDung>> GetListNguoiDung()
        {
            var res = _nguoiDungBLL.GetListAsync();
            return res;
        }
        [HttpGet("GetUser/{id}")]
        public Task<NguoiDung> GetNguoiDung(string id)
        {
            var res = _nguoiDungBLL.FindByIdAsync(id);
            return res;
        }
        [HttpGet("Paginate/{pageIndex}/{pageSize}")]
        public Task<PaginationModel<NguoiDung>> PaginationModel(string pageIndex, string pageSize)
        {
            var res = _nguoiDungBLL.Paginate(pageIndex, pageSize);
            return res;
        }
    }
}
