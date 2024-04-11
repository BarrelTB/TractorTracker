using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;
using TractorTracker.Application.Services.Interfaces;
using AutoMapper;

namespace TractorTracker.Web.Controllers
{
    public class LoginController : Controller
    {
        private ILogger<LoginController> _logger;
        private IUserService _userService;
        private IMapper _mapper;

        public LoginController(ILogger<LoginController> logger, IUserService userService, IMapper mapper)
        {
            _logger = logger;
            _userService = userService;
            _mapper = mapper;
        }

        // GET: HomeController1
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string username, string password)
        {
            try
            {
                var userId = _userService.Login(username, password);
                if(userId > 0)
                {
                    Response.Cookies.Append("userId", userId.ToString(), new CookieOptions
                    {
                        Expires = DateTimeOffset.UtcNow.AddHours(1),
                        //Domain = ".example.com",
                        Path = "/",
                        //Secure = true,
                        //HttpOnly = true,
                        //SameSite = SameSiteMode.Strict
                    });

                    return RedirectToAction("Index", "Home");
                } 
                else
                {
                    throw new Exception("Username or Password incorrect");
                }

                
            }
            catch (Exception ex)
            {
                // log error
                return RedirectToAction(nameof(Error));
            }
        }

        //implement reset password/username methods maybe??
    }
}
