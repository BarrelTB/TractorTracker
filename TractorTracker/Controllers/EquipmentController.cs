using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TractorTracker.Application.DTOs;
using TractorTracker.Application.Services.Interfaces;
using TractorTracker.Web.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TractorTracker.Web.Controllers
{
    public class EquipmentController : Controller
    {
        private IEquipmentService _equipmentService;
        private ILogger<EquipmentController> _logger;
        private IMapper _mapper;

        public EquipmentController(IEquipmentService equipmentService, ILogger<EquipmentController> logger, IMapper mapper)
        {
            _equipmentService = equipmentService;
            _logger = logger;
            _mapper = mapper;
        }

        // GET: EquipmentController
        public ActionResult Index()
        {
            try
            {
                Request.Cookies.TryGetValue("userId", out string id);
                int.TryParse(id, out int userId);

                var generalEquipmentsList = _equipmentService.GetAllEquipmentGeneralForUser(userId);
                var generalEquipmentsViewModelList = _mapper.Map<List<EquipmentGeneralDTO>, List<EquipmentGeneralViewModel>>(generalEquipmentsList);
                return View(generalEquipmentsViewModelList);
            }
            catch (Exception ex)
            {
                return RedirectToAction(nameof(Error));
            }
            
        }

        // POST: EquipmentController/Create
        [HttpPost]
        public ActionResult Create(EquipmentGeneralViewModel equipmentViewModel)
        {
            try
            {
                var equipmentDTO = _mapper.Map<EquipmentGeneralViewModel, EquipmentGeneralDTO>(equipmentViewModel);

                Request.Cookies.TryGetValue("userId", out string id);
                int.TryParse(id, out int userId);

                var isCreated = _equipmentService.CreateEquipmentFromGeneral(equipmentDTO, userId);
                if(isCreated)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    throw new Exception("Failed to create equipment");
                }
                
            }
            catch
            {
                return RedirectToAction(nameof(Error));
            }
        }

        // POST: EquipmentController/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Error));
            }
        }

        // POST: EquipmentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Error));
            }
        }
    }
}
