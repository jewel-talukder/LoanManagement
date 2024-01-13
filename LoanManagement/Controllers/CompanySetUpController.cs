using LoanManagement.Interfaces;
using LoanManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoanManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanySetUpController : ControllerBase
    {
        private readonly ICompanySetUp _companySetUp;
        public CompanySetUpController(ICompanySetUp companySetUp)
        {
                _companySetUp = companySetUp;
        }
        [HttpGet("GetCompanySetUp")]
        public async Task<IActionResult> GetCompanySetUp()
        {
            try
            {
                var result = _companySetUp.GetCompanySetUpListAsync();
                return Ok(result.Result);
            }
            catch (Exception)
            {

                throw;
            }
           
        }
        [HttpPost("NewCompanySetUp")]
        public async Task<ActionResult> CreateCompanySetUp(CompanySetUP companySetUp)
        {
            try
            {
                var result = _companySetUp.CreateOrUpdate(companySetUp, 1);
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
