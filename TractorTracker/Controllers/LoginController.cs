using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;
using TractorTracker.Web.Models;

namespace TractorTracker.Web.Controllers
{
    public class LoginController : Controller
    {
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
                //login code here
                //var user = _userService.Login(username, password);
                //var userViewModel = _mapper.Map<UserDTO, UserViewModel>(user);
                /*var userViewModel = new UserViewModel();
                userViewModel.UserName = username;
                userViewModel.Password = password;
                userViewModel.TimeZoneInfo = TimeZoneInfo.Utc;
                userViewModel.Email = "email@email.com";*/

                //call to user login just needs to return user id
                //user id then needs to be added as a cookie via session storage
                //This way when user acccesses user settings page their info can be pulled and modified as necessary

                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex);
                return RedirectToAction(nameof(Error));
            }
        }

        //implement reset password/username methods maybe??
    }
}
