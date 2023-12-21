using GraduateSolution.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace GraduateSolution
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminBLL _admin;
        public AdminController(IAdminBLL admin)
        {
            _admin = admin;
        }
        [HttpPost("Add")]
        public Task<int> AddAdmin([FromForm] Admin admin)
        {
            admin.Maadmin = Guid.NewGuid().ToString();
            var res = _admin.AddAsync(admin);
            return res;
        }
        [HttpPost("Update")]
        public Task<int> UpdateAdmin([FromForm] Admin admin)
        {
            var res = _admin.Update(admin);
            return res;
        }
        [HttpPost("Delete")]
        public Task<int> DeleteAdmin(string id)
        {
            var res = _admin.DeleteByIdAsync(id);
            return res;
        }
        [HttpGet("Get-Admin_List")]
        public Task<List<Admin>> GetList()
        {
            var res = _admin.GetListAsync();
            return res;
        }
        [HttpGet("GetAdmin/{id}")]
        public Task<Admin> GetAdminById(string id)
        {
            var res = _admin.FindByIdAsync(id);
            return res;
        }
        [HttpPost("AdminLoginCheck")]
        public bool CheckLogin(string user, string pass)
        {
            return true;
        }
    }
}
