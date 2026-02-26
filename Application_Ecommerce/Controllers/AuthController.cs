using Microsoft.AspNetCore.Mvc;

namespace Application_Ecommerce.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
