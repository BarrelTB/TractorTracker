using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TractorTracker.Web.Models;

namespace TractorTracker.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        // POST: Home/Login
        [HttpPost]
        [Route("login")]
        public IActionResult Login(string username, string password)
        {
            try
            {
                return RedirectToAction(nameof(User));
            }
            catch
            {
                return View();
            }
        }

        [Route("privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

        [Route("error")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
