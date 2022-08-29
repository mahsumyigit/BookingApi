using System;
using Microsoft.AspNetCore.Mvc;

namespace BookingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : GenericBaseController<User, IUserService>
    {
        public UserController(IUserService userService) : base(userService)
        {
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            return base.GetResponseByResultSuccess(base._service.GetAll());
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            return base.GetResponseByResultSuccess(base._service.GetUserById(id));
        }
        [HttpGet("getbyemail")]
        public IActionResult GetByName(string email)
        {
            return base.GetResponseByResultSuccess(base._service.GetUserByName(email));
        }
    }
}

