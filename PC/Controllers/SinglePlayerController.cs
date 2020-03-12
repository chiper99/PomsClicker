using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PC.Models;

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

        [Route("{controller}/{action}")]
        [HttpPost]
        public void postData([FromForm] userSaveData data)
        {

        }
    }
}