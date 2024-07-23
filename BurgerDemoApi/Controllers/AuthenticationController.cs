using Application.Interfaces;
using Application.Models.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BurgerDemoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AuthenticationController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IAuthServiceCustom _authServiceCustom;


        public AuthenticationController(IConfiguration configuration, IAuthServiceCustom authServiceCustom)
        {
            _configuration = configuration;
            _authServiceCustom = authServiceCustom;
            
        }


        [HttpPost("authenticate")]
        public ActionResult<string> Authenticate(AuthenticationRequest authenticationRequest)
        {
            string token = _authServiceCustom.Authenticate(authenticationRequest);

            return Ok(token);
        }
    }
}
