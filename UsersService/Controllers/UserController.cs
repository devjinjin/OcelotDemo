using Microsoft.AspNetCore.Mvc;
using NANUApp.Models.Users;

namespace UsersService.Controllers
{

    //[Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [Route("GetUserDetails")]
        [HttpGet]
        public UserModel GetUserDetails()
        {
            UserModel obj = new UserModel();

            obj.Email = "testemail@test.com";
            obj.UserId = 1001;
            obj.Name = "Test User";

            return obj;
        }

    }
}
