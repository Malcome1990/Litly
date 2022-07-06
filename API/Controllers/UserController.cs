using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos.User;
using API.Models;
using API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;

        }
        [HttpPut]
        public async Task<ActionResult<ServiceResponse<UpdateUserDto>>> UpdateUser(UpdateUserDto updatedUser)
        {
            return Ok(await _userService.UpdateUserById(updatedUser));
        }
    }
}