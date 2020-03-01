using Microsoft.AspNetCore.Mvc;

namespace PC.Controllers
{
    public class RegisterController : Controller
    {
        // GET
        [Route("{controller}/")]
        public IActionResult Register()
        {
            return View();
        }
    }
}