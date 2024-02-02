using Entities;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using Services.Model.Request;

namespace WebApp.Controllers
{
    public class UserController : Controller
    {
        public readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            var users = userService.GetAllUsers();
            return View(users);
        }

        /*  [HttpGet]
          public IActionResult GetAllUsersWithFilter(string firstName)
          {
              var request=new UserRequest { FirstName = firstName};
             // var users = userService.GetAllUserFilter(request);
              return View(users);
          }*/

        public IActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateUser(UserRequest user)
        { 
            try
            {
                if (user == null)
                {
                    return BadRequest();
                }

                userService.CreateUser(user);
                return StatusCode(201, user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
