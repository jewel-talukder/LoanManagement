﻿using LoanManagement.DataContext;
using LoanManagement.Interfaces;
using LoanManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LoanManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserListController : ControllerBase
    {
        private readonly DatabaseContext _context;
        private readonly ILogin _login;
       public UserListController(ILogin login,DatabaseContext context)
        {
            _login = login;
            _context = context;
        }
        [HttpGet("GetAllUser")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await _login.GetUserListAsync();
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }

        }
        [HttpPost("LoginUser")]
        public async Task<IActionResult> LoginUser(UserList user)
        {
            try
            {
                var result = await _login.LoginUser(user);
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }

        }
        
    }
}
