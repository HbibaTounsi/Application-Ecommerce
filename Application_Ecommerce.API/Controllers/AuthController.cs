using Application_Ecommerce.App.Athentication.Interfaces;
using Application_Ecommerce.Core.Entities.Identity;
using Application_Ecommerce.Core.Interfaces.External;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Application_Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly IEmailSender _emailSender;
        private readonly IConfiguration _configuration;
        private readonly UserManager<ApplicationUser> _userManager;

        public AuthController(
            IAuthService authService,
            IEmailSender emailSender,
            IConfiguration configuration,
            UserManager<ApplicationUser> userManager)
        {
            _authService = authService;
            _emailSender = emailSender;
            _configuration = configuration;
            _userManager = userManager;
        }


    }
}
