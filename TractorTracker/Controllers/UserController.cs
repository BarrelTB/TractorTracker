using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TractorTracker.Application.DTOs;
using TractorTracker.Application.Services.Interfaces;
using TractorTracker.Web.Models;

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
                _userService.CreateOrUpdateUser(userDto);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
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
