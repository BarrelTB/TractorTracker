using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TractorTracker.Application.DTOs;
using TractorTracker.Application.Services.Interfaces;
using TractorTracker.Web.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TractorTracker.Web.Controllers
{
    public class UserController : Controller
    {

        private IUserService _userService;
        private ILogger<UserController> _logger;
        private IMapper _mapper;

        public UserController(IUserService userService, ILogger<UserController> logger, IMapper mapper)
        {
            _userService = userService;
            _logger = logger;
            _mapper = mapper;
        }

        // GET: UserController/Create
        public IActionResult Create()
        {
            UserViewModel model = new UserViewModel();
            return View(model);
        }

        // POST: UserController/Create
        [HttpPost]
        public IActionResult Create(UserViewModel userViewModel)
        {
            try
            {
                var userDto = _mapper.Map<UserViewModel, UserDTO>(userViewModel);
                var userId = _userService.CreateOrUpdateUser(userDto);
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

                    return RedirectToAction(nameof(Index), "Home");
                }
                else
                {
                    throw new Exception("User failed to be created");
                }

                
            }
            catch (Exception ex)
            {
                // log error
                return RedirectToAction(nameof(Error));
            }
        }

        // GET: UserController/Edit/5
        public IActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Delete/5
        public IActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
