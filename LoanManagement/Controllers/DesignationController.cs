using LoanManagement.Interfaces;
using LoanManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoanManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DesignationController : ControllerBase
    {
        private readonly IDesignation _designation;
        public DesignationController(IDesignation designation)
        {
            _designation = designation;    
        }
        [HttpGet("GetDesignation")]
        public async Task<IActionResult> GetDesignation()
        {
            try
            {
                var result = _designation.GetDesignationListAsync();
                return Ok(result.Result);
            }
            catch (Exception)
            {

                throw;
            }
           
        }
        [HttpPost("NewDesignation")]
        public async Task<ActionResult> CreateDesignation(Designation designation)
        {
            try
            {
                var result = _designation.CreateOrUpdate(designation, 1);
                if(result.Result == true)
                {
                    return Ok(designation);
                }
                else
                {
                    return BadRequest("Designation Creation Failed");
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
