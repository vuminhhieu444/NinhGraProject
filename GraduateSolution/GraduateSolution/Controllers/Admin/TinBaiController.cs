using GraduateSolution.Models;
using Microsoft.AspNetCore.Mvc;

namespace GraduateSolution
{
    [Route("api/[controller]")]
    [ApiController]
    public class TinBaiController : ControllerBase
    {
        private readonly ITinBaiBLL _tinBaiBLL;
        public TinBaiController(ITinBaiBLL tinBaiBLL)
        {
            _tinBaiBLL = tinBaiBLL;
        }
        [HttpPost("Add")]
        public Task<int> Add([FromForm] TinBai tinBai)
        {
            tinBai.Matinbai = Guid.NewGuid().ToString();
            var res = _tinBaiBLL.AddAsync(tinBai);
            return res;
        }
        [HttpPost("Update")]
        public Task<int> Update([FromForm]TinBai tinBai)
        {
            var res = _tinBaiBLL.Update(tinBai);
            return res;
        }
        [HttpPost("Delete")]
        public Task<int> Delete(string id)
        {
            var res= _tinBaiBLL.DeleteByIdAsync(id);
            return res;
        }
        [HttpGet("GetList")]
        public Task<List<TinBai>> GetList()
        {
            var res = _tinBaiBLL.GetListAsync();
            return res;
        }
        [HttpGet("GetTinBai/{id}")]
        public Task<TinBai> GetTinBai(string id)
        {
            var res = _tinBaiBLL.FindByIdAsync(id);
            return res;
        }
    }
}
