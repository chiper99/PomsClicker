using Microsoft.AspNetCore.Mvc;

namespace PC.Controllers
{
    public class SinglePlayerController : Controller
    {
        // GET
        [Route("{controller}/")]
        public IActionResult SinglePlayer()
        {
            return View();
        }
    }
}