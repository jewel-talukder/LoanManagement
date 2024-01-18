using LoanManagement.Interfaces;
using LoanManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoanManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRole _role;
        public RoleController(IRole role)
        {
            _role = role;    
        }
        [HttpGet("GetRole")]
        public async Task<IActionResult> GetRole()
        {
            try
            {
                var result = _role.GetRoleListAsync();
                return Ok(result.Result);
            }
            catch (Exception)
            {

                throw;
            }
           
        }
        [HttpPost("NewRole")]
        public async Task<ActionResult> CreateRole(Role role)
        {
            try
            {
                var result = _role.CreateOrUpdate(role, 1);
                if(result.Result == true)
                {
                    return Ok(role);
                }
                else
                {
                    return BadRequest("Role Creation Failed");
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
