using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Open.User.IServices.Users;
using Open.User.Models.Users;
using Open.User.Services.Users;

namespace Open.Api.Controllers.User
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserInfoController : ControllerBase
    {
        private readonly IUserInfoService _userInfoService;
        public UserInfoController(IUserInfoService userInfoService)
        {
            _userInfoService = userInfoService;
        }

        [HttpGet(Name = "AddUserInfoAsync")]
        public async Task<IActionResult> AddUserInfoAsync()
        {
            UserInfo user = new UserInfo();
            int result = await _userInfoService.AddUserInfoAsync(user);
            return Content(result.ToString());
        }
    }
}
