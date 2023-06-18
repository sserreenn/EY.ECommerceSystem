using EY.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace EY.WebAPI.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : BaseController
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
                _userService= userService;
        }
        public IActionResult Index()
        {
            var values = _userService.TGetAll();
            if(values.Count == 0)
            {
                return BadRequest(null);
            }
            return Ok(values);
        }
    }
}
