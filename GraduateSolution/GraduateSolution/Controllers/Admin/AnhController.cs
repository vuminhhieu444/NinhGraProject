using GraduateSolution.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GraduateSolution
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnhController : ControllerBase
    {
        private readonly IAnhBLL _anhBLL;
        public AnhController(IAnhBLL anhBLL)
        {
            _anhBLL = anhBLL;
        }
        [HttpPost("Add")]
        public Task<int> Add([FromForm] Anh anh)
        {
            anh.Maanh = Guid.NewGuid().ToString();
            var res = _anhBLL.AddAsync(anh);
            return res;
        }
        [HttpPost("Update")]
        public Task<int> Update([FromForm] Anh anh)
        {
            var res = _anhBLL.Update(anh);
            return res;
        }
        [HttpPost("Delete/{id}")]
        public Task<int> Delete(string id)
        {
            var res = _anhBLL.DeleteByIdAsync(id);
            return res;
        }
        [HttpGet("Get-List-Anh")]
        public Task<List<Anh>> GetList()
        {
            var res = _anhBLL.GetListAsync();
            return res;
        }
        [HttpGet("Get-Anh/{id}")]
        public Task<Anh> GetAnh(string id)
        {
            var res = _anhBLL.FindByIdAsync(id);
            return res;
        }
        [HttpGet("Paginate/{pageIndex}/{pageSize}")]
        public Task<PaginationModel<Anh>> PaginationModel(string pageIndex, string pageSize)
        {
            var res = _anhBLL.Paginate(pageIndex, pageSize);
            return res;
        }
    }
}
