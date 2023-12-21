using GraduateSolution.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GraduateSolution
{
    [Route("api/[controller]")]
    [ApiController]
    public class XepHangController : ControllerBase
    {
        private readonly IXepHangBLL _xepHangBLL;
        public XepHangController(IXepHangBLL xepHangBLL)
        {
            _xepHangBLL = xepHangBLL;
        }
        [HttpPost("Add")]
        public Task<int> Add([FromForm]XepHang xepHang)
        {
            xepHang.MaBangXepHang = Guid.NewGuid().ToString();
            var res= _xepHangBLL.AddAsync(xepHang);
            return res;
        }
        [HttpPost("Update")]
        public Task<int> Update([FromForm]XepHang xepHang)
        {
            var res = _xepHangBLL.Update(xepHang);
            return res;
        }
        [HttpPost("Delete")]
        public Task<int> Delete(string id)
        {
            var res = _xepHangBLL.DeleteByIdAsync(id);
            return res;
        }
        [HttpGet("GetListBangXepHang")]
        public Task<List<XepHang>> GetXepHangs()
        {
            var res = _xepHangBLL.GetListAsync();
            return res;
        }
        [HttpGet("GetBangXepHang/{id}")]
        public Task<XepHang> GetEntity(string id)
        {
            var res = _xepHangBLL.FindByIdAsync(id);
            return res;
        }
    }
}
