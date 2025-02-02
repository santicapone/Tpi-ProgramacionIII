﻿using Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BurgerDemoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService; 
        }

        [HttpGet("GetAllUsers")]
        public IActionResult GetAllUsers() 
        {
            return Ok(_userService.GetAllUsers());
        }

        [HttpGet("GetUserByName{name}")]
        [Authorize("Admin")]
        public IActionResult GetUserByName(string name)
        {
            var exist = _userService.GetUserByName(name);
            if (exist == null)
            {
                return NotFound("the user was not found");
            }
            return Ok(exist);
        }
    }
}
