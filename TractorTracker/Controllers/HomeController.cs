using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TractorTracker.Application.DTOs;
using TractorTracker.Application.Services;
using TractorTracker.Web.Models;

namespace TractorTracker.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserService _userService;
        private readonly AutoMapper.Mapper _mapper;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index(UserViewModel userViewModel)
        {
            return View();
        }

        [Route("Error")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
