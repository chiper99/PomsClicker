using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PC.Controllers
{
    public class MultiPlayerController : Controller
    {
        // GET
        [Authorize]
        [Route("{controller}/")]
        public IActionResult MultiPlayer()
        {
            return View();
        }

        public IActionResult ChoosePlayers()
        {

            return View();
        }
    }
}