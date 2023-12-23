using GraduateSolution.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GraduateSolution
{
    [Route("api/[controller]")]
    [ApiController]
    public class GiaiDauController : ControllerBase
    {
        private readonly IGiaiDauBLL _giaiDauBLL;
        public GiaiDauController(IGiaiDauBLL giaiDauBLL)
        {
            _giaiDauBLL = giaiDauBLL;
        }
        [HttpPost("Add")]
        public Task<int> Add([FromForm]GiaiDau giaiDau)
        {
            giaiDau.Id = Guid.NewGuid().ToString();
            var res= _giaiDauBLL.AddAsync(giaiDau);
            return res;
        }
        [HttpPost("Update")]
        public Task<int> Update([FromForm] GiaiDau giaiDau)
        {
            var res = _giaiDauBLL.Update(giaiDau);
            return res;
        }
        [HttpPost("Delete/{id}")]
        public Task<int> Delete(string id)
        {
            var res = _giaiDauBLL.DeleteByIdAsync(id);
            return res;
        }
        [HttpGet("Get-List-Giai-Dau")]
        public Task<List<GiaiDau>> GetList()
        {
            var res = _giaiDauBLL.GetListAsync();
            return res;
        }
        [HttpGet("Get-Giai-Dau/{id}")]
        public Task<GiaiDau> GetGiaiDau(string id)
        {
            var res = _giaiDauBLL.FindByIdAsync(id);
            return res;
        }
    }
}
