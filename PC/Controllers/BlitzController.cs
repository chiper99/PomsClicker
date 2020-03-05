using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PC.Controllers
{
    public class BlitzController : Controller
    {
        // GET
        [Route("{controller}/")]
        [Authorize]
        public IActionResult Blitz()
        {
            return View();
        }
    }
}