using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectFuture.Application.IBaseRepositories;
using ProjectFuture.Application.Services.IService;
using ProjectFuture.Domain.Entites.Models;

namespace ProjectFuture.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetAllUsers()
        {
            var result = await _userService.GetAll();

            return Ok(result);
        }
    }
}
