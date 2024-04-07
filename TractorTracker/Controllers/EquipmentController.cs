using Microsoft.AspNetCore.Mvc;

namespace TractorTracker.Web.Controllers
{
    public class EquipmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
