using Microsoft.AspNetCore.Mvc;

namespace PC.Controllers
{
    public class BlitzController : Controller
    {
        // GET
        [Route("{controller}/")]
        public IActionResult Blitz()
        {
            return View();
        }
    }
}