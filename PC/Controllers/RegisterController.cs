using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PC.Auth;
using PC.Models;

namespace PC.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public RegisterController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        // GET
        [Route("{controller}/")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [Route("{controller}/")]
        public async Task<IActionResult> Register(RegisterUserModel user)
        {
            User User = new User { Email = user.email, UserName = user.name };
            var result = await _userManager.CreateAsync(User, user.password);

            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(User, false);

                return RedirectToAction("Index", "Home");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return BadRequest();
        }        
    }
}