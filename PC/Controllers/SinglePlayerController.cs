using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PC.Controllers
{
    public class SinglePlayerController : Controller
    {
        // GET
        [Authorize]
        [Route("{controller}/")]
        public IActionResult SinglePlayer()
        {
            return View();
        }
    }
}