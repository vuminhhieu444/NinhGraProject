using GraduateSolution.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GraduateSolution
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogAdminController : ControllerBase
    {
        private readonly ILogAdminBLL _logAdminBLL;
        public LogAdminController(ILogAdminBLL logAdminBLL)
        {
            _logAdminBLL = logAdminBLL;
        }
        [HttpPost("Add")]
        public Task<int> Add([FromForm] LogAdmin logAdmin)
        {
            logAdmin.Id = Guid.NewGuid().ToString();
            var res = _logAdminBLL.AddAsync(logAdmin);
            return res;
        }
        [HttpPost("Update")]
        public Task<int> Update([FromForm] LogAdmin logAdmin)
        {
            var res = _logAdminBLL.Update(logAdmin);
            return res;
        }
        [HttpPost("Delete/{id}")]
        public Task<int> Delete(string id)
        {
            var res = _logAdminBLL.DeleteByIdAsync(id);
            return res;
        }
        [HttpGet("Get-List-LogAdmin")]
        public Task<List<LogAdmin>> GetList()
        {
            var res = _logAdminBLL.GetListAsync();
            return res;
        }
        [HttpGet("Get-LogAdmin/{id}")]
        public Task<LogAdmin> GetAnh(string id)
        {
            var res = _logAdminBLL.FindByIdAsync(id);
            return res;
        }
        [HttpGet("Paginate/{pageIndex}/{pageSize}")]
        public Task<PaginationModel<LogAdmin>> PaginationModel(string pageIndex, string pageSize)
        {
            var res = _logAdminBLL.Paginate(pageIndex, pageSize);
            return res;
        }
        [HttpPost("Check-log")]
        public int CheckLog([FromForm] LogAdmin logAdmin)
        {
            try
            {
                var lgAdmin = _logAdminBLL.GetListAsync().Result.Where(m => m.UserName.ToLower().Trim() == logAdmin.UserName.ToLower().Trim() && m.Pass.ToLower().Trim() == logAdmin.Pass.ToLower().Trim()).FirstOrDefault();
                if (lgAdmin != null)
                    return 1;
                throw new Exception();
            }
            catch (Exception e)
            {
                return 0;
            }
        }
    }
}
