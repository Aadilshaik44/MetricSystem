using MetricSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MetricSystem.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.MS = null;
            return View();
        }

        [HttpPost]
        public IActionResult Index(TemperatureValueModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.MS = model.CalculateCelsiusValue();
            }
            else
            {
                ViewBag.MS = null;
            }
            return View(model);
        }
    }
}