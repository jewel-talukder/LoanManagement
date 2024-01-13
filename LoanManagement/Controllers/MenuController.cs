using LoanManagement.Interfaces;
using LoanManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoanManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly IMenu _menu;
        public MenuController(IMenu menu)
        {
            _menu = menu;
        }
        [HttpGet("GetMenu")]
        public async Task<IActionResult> GetMenu()
        {
            var result = _menu.GetMenuListAsync();
            return Ok(result.Result);
        }
        [HttpPost("NewMenu")]
        public async Task<ActionResult> CreateMenu(Menu menu)
        {
            var result = _menu.CreateOrUpdate(menu, 1);
            return Ok(result);
        }
        [HttpPut("UpdateMenu")]
        public async Task<ActionResult> UpdateMenu(Menu menu)
        {
            var result = _menu.CreateOrUpdate(menu, 2);
            return Ok(result);
        }
    }
    
}
