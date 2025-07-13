using Bikya.DTOs.UserDTOs;
using Bikya.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bikya.API.Areas.Identity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Area("Identity")]
    [Authorize(Roles = "Admin")]

    public class AdminUsersController : ControllerBase
    {
        private readonly IUserAdminService _adminService;

        public AdminUsersController(IUserAdminService adminService)
        {
            _adminService = adminService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] string? search, [FromQuery] string? status)
            => Ok(await _adminService.GetAllUsersAsync(search, status));

        [HttpGet("active")]
        public async Task<IActionResult> GetActive()
            => Ok(await _adminService.GetActiveUsersAsync());

        [HttpGet("inactive")]
        public async Task<IActionResult> GetInactive()
            => Ok(await _adminService.GetInactiveUsersAsync());

        [HttpGet("count")]
        public async Task<IActionResult> GetCount()
            => Ok(await _adminService.GetUsersCountAsync());

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateUserDto dto)
            => Ok(await _adminService.UpdateUserAsync(id, dto));

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
            => Ok(await _adminService.DeleteUserAsync(id));

        [HttpPost("reactivate")]
        public async Task<IActionResult> Reactivate([FromQuery] string email)
            => Ok(await _adminService.ReactivateUserAsync(email));

        [HttpPost("{id}/lock")]
        public async Task<IActionResult> Lock(int id)
            => Ok(await _adminService.LockUserAsync(id));

        [HttpPost("{id}/unlock")]
        public async Task<IActionResult> Unlock(int id)
            => Ok(await _adminService.UnlockUserAsync(id));
    }
}
