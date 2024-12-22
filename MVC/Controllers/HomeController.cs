using BD.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System.Diagnostics;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public HomeController(ILogger<HomeController> logger, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _logger = logger;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByIdAsync("2abfe17d-06ea-493a-81d0-dfc0a4e5c94e");
            //var user = await _userManager.FindByIdAsync("397aa1bc-dd39-4551-983e-0ee755b1287c");
            //var user = await _userManager.FindByIdAsync("39e4fe87-b165-4af0-ac0d-c94b4a9a964a");
            if (user == null)
                return Privacy();
            await _signInManager.SignInAsync(user, isPersistent: false);
            return View(user);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}