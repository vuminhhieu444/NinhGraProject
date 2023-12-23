using GraduateSolution.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GraduateSolution
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogUserController : ControllerBase
    {
        private readonly ILogUserBLL _logUserBLL;
        public LogUserController(ILogUserBLL logUserBLL)
        {
            _logUserBLL = logUserBLL;
        }
        [HttpPost("Add")]
        public Task<int> Add([FromForm] LogUser logUser)
        {
            logUser.Id = Guid.NewGuid().ToString();
            var res = _logUserBLL.AddAsync(logUser);
            return res;
        }
        [HttpPost("Update")]
        public Task<int> Update([FromForm] LogUser logUser)
        {
            var res = _logUserBLL.Update(logUser);
            return res;
        }
        [HttpPost("Delete/{id}")]
        public Task<int> Delete(string id)
        {
            var res = _logUserBLL.DeleteByIdAsync(id);
            return res;
        }
        [HttpGet("Get-List-LogUser")]
        public Task<List<LogUser>> GetList()
        {
            var res = _logUserBLL.GetListAsync();
            return res;
        }
        [HttpGet("Get-LogUser/{id}")]
        public Task<LogUser> GetAnh(string id)
        {
            var res = _logUserBLL.FindByIdAsync(id);
            return res;
        }
        [HttpGet("Paginate/{pageIndex}/{pageSize}")]
        public Task<PaginationModel<LogUser>> PaginationModel(string pageIndex, string pageSize)
        {
            var res = _logUserBLL.Paginate(pageIndex, pageSize);
            return res;
        }
        [HttpPost("Check-log")]
        public int CheckLog([FromForm] LogAdmin logAdmin)
        {
            try
            {
                var lgAdmin = _logUserBLL.GetListAsync().Result.Where(m => m.UserName.ToLower().Trim() == logAdmin.UserName.ToLower().Trim() && m.Pass.ToLower().Trim() == logAdmin.Pass.ToLower().Trim()).FirstOrDefault();
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
