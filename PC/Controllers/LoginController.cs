using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PC.Auth;
using PC.Models;

namespace PC.Controllers
{
    [Route("{controller}/")]
    public class LoginController : Controller
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        public LoginController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }
        // GET
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LogIn(RegisterUserModel user)
        {
            var userToLogIn = await _userManager.FindByEmailAsync(user.email);
            var response = await _signInManager.PasswordSignInAsync(userToLogIn, user.password, false, false);
            if (response.Succeeded)
            {
                return RedirectToAction("Index", "Home");

            }
            return BadRequest();
        }
    }
}