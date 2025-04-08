using Microsoft.AspNetCore.Mvc;
using DateTimeTask.Models;

namespace DateTimeTask.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new TimeZoneViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult UpdateTimeZone(TimeZoneViewModel model)
        {
            return View("Index", model); // Return back to the Index view with the updated timezone
        }
    }
}