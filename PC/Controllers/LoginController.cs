using Microsoft.AspNetCore.Mvc;

namespace PC.Controllers
{
    public class LoginController : Controller
    {
        // GET
        [Route("{controller}/")]
        public IActionResult Login()
        {
            return View();
        }
    }
}