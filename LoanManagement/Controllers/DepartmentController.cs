using LoanManagement.Interfaces;
using LoanManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoanManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartment _department;
        public DepartmentController(IDepartment department)
        {
            _department = department;    
        }
        [HttpGet("GetDepartment")]
        public async Task<IActionResult> GetDepartment()
        {
            try
            {
                var result = _department.GetDepartmentListAsync();
                return Ok(result.Result);
            }
            catch (Exception)
            {

                throw;
            }
           
        }
        [HttpPost("NewDepartment")]
        public async Task<ActionResult> CreateDepartment(Department department)
        {
            try
            {
                var result = _department.CreateOrUpdate(department, 1);
                if(result.Result == true)
                {
                    return Ok(department);
                }
                else
                {
                    return BadRequest("Department Creation Failed");
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        
    }
}
