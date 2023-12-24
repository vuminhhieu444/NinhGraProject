using GraduateSolution.BLL.NguoiDungBLL;
using GraduateSolution.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GraduateSolution.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class TranDauController : ControllerBase
    {
        private readonly ITranDauBLL _tranDauBLL;
        public TranDauController(ITranDauBLL tranDauBLL)
        {
            _tranDauBLL = tranDauBLL;  
        }
        [HttpPost("Add")]
        public Task<int> Add([FromForm] TranDau tranDau)
        {
            tranDau.Id = Guid.NewGuid().ToString();
            var res = _tranDauBLL.AddAsync(tranDau);
            return res;
        }
        [HttpPost("Update")]
        public Task<int> Update([FromForm] TranDau tranDau)
        {
            var res = _tranDauBLL.Update(tranDau);
            return res;
        }
        [HttpPost("Delete")]
        public Task<int> Delete(string id)
        {
            var res = _tranDauBLL.DeleteByIdAsync(id);
            return res;
        }
        [HttpGet("GetListBangTranDau")]
        public Task<List<TranDau>> GetTranDaus()
        {
            var res = _tranDauBLL.GetListAsync();
            return res;
        }
        [HttpGet("GetBangTranDau/{id}")]
        public Task<TranDau> GetEntity(string id)
        {
            var res = _tranDauBLL.FindByIdAsync(id);
            return res;
        }
        [HttpGet("Paginate/{pageIndex}/{pageSize}")]
        public Task<PaginationModel<TranDau>> PaginationModel(string pageIndex, string pageSize)
        {
            var res = _tranDauBLL.Paginate(pageIndex, pageSize);
            return res;
        }
    }
}
