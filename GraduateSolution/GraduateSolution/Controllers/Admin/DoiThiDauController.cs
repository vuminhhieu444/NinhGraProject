using GraduateSolution.BLL.NguoiDungBLL;
using GraduateSolution.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GraduateSolution.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoiThiDauController : ControllerBase
    {
        private readonly IDoiThiDauBLL _doiThiDauBLL;
        public DoiThiDauController(IDoiThiDauBLL doiThiDauBLL)
        {
            _doiThiDauBLL = doiThiDauBLL;
        }
        [HttpPost("Add")]
        public Task<int> Add([FromForm] DoiThiDau doiThiDau)
        {
            doiThiDau.Id = Guid.NewGuid().ToString();
            var res = _doiThiDauBLL.AddAsync(doiThiDau);
            return res;
        }
        [HttpPost("Update")]
        public Task<int> Update([FromForm] DoiThiDau doiThiDau)
        {
            var res = _doiThiDauBLL.Update(doiThiDau);
            return res;
        }
        [HttpPost("Delete")]
        public Task<int> Delete(string id)
        {
            var res = _doiThiDauBLL.DeleteByIdAsync(id);
            return res;
        }
        [HttpGet("GetListBangXepHang")]
        public Task<List<DoiThiDau>> GetXepHangs()
        {
            var res = _doiThiDauBLL.GetListAsync();
            return res;
        }
        [HttpGet("GetBangXepHang/{id}")]
        public Task<DoiThiDau> GetEntity(string id)
        {
            var res = _doiThiDauBLL.FindByIdAsync(id);
            return res;
        }
        [HttpGet("Paginate/{pageIndex}/{pageSize}")]
        public Task<PaginationModel<DoiThiDau>> PaginationModel(string pageIndex, string pageSize)
        {
            var res = _doiThiDauBLL.Paginate(pageIndex, pageSize);
            return res;
        }
    }
}
