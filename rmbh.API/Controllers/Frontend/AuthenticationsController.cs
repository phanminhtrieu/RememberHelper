using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using rmbh_backoffice.MVC.Models.Dtos.Authentications;
using rmbh_backoffice.MVC.Models.Services.Authentications;

namespace rmbh.API.Controllers.Frontend
{
    /// <summary>
    /// Authentication controller
    /// </summary>
    public class AuthenticationsController : BaseController
    {
        private readonly IAuthenticationService _authenticationService;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="authenticationService"></param>
        public AuthenticationsController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        /// <summary>
        /// Authen user by email and password
        /// </summary>
        /// <param name="request">Email and password</param>
        /// <returns>Trạng thái xác thực</returns>
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] AuthenticationRequest request)
        {
            if (_authenticationService.IsLoginSuccessful(request))
            {
                var user = await _authenticationService.GetUserByEmail(request.Email);
                
                return Ok(user);
            }
            return Unauthorized("Email or password is incorrect");
        }

    }
}
