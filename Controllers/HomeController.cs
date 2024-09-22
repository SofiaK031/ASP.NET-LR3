using LR3.Models;
using LR3.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LR3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITimeService _timeService;
        public HomeController(ITimeService timeService)
        {
            _timeService = timeService;
        }

        public IActionResult Index()
        {
            ViewData["Calculator"] = _timeService.GetCurrentTimePeriod();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
