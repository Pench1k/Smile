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
            var user = await _userManager.FindByIdAsync("cb4b72b8-426b-4377-9c72-12078ffecc98"); //6e1d5268-016e-4c81-be3f-347b18b85395 пациент
            //var user = await _userManager.FindByIdAsync("cb4b72b8-426b-4377-9c72-12078ffecc98"); //cb4b72b8-426b-4377-9c72-12078ffecc98 доктор
            //var user = await _userManager.FindByIdAsync("39e4fe87-b165-4af0-ac0d-c94b4a9a964a"); //928a710a-40f5-4ff3-9c37-02c39f3c167d админ
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