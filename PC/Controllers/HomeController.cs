using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PC.Models;

namespace PC.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            var model = new HomeViewModel()
            {
                UserName = User.FindFirstValue(ClaimTypes.Name)
            };
            return View(model);
        }
        
        
    }
}
