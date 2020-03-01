using Microsoft.AspNetCore.Mvc;

namespace PC.Controllers
{
    public class MultiPlayerController : Controller
    {
        // GET
        [Route("{controller}/")]
        public IActionResult MultiPlayer()
        {
            return View();
        }
    }
}