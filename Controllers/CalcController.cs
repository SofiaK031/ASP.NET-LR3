using LR3.Services;
using Microsoft.AspNetCore.Mvc;

namespace LR3.Controllers
{
    public class CalcController : Controller
    {
        ICalcService _calcService;
        public CalcController(ICalcService calcService)
        {
            _calcService = calcService;
        }

        public IActionResult Index(int a, int b)
        {
            return View();
        }


        // without redirection

        [HttpGet]
        public IActionResult Addition(int a = 0, int b = 0)
        {
            TempData["AdditionResult"] = _calcService.Addition(a, b);
            TempData["ActiveOperation"] = "Addition";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Subtraction(int a = 0, int b = 0)
        {
            TempData["SubtractionResult"] = _calcService.Subtraction(a, b);
            TempData["ActiveOperation"] = "Subtraction";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Multiplication(int a = 0, int b = 0)
        {
            TempData["MultiplicationResult"] = _calcService.Multiplication(a, b);
            TempData["ActiveOperation"] = "Multiplication";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Division(int a, int b)
        {
            try
            {
                double result = _calcService.Division(a, b);
                TempData["DivisionResult"] = Math.Round(result, 2).ToString();
            }
            catch (ArgumentException ex)
            {
                TempData["DivisionResult"] = ex.Message;
            }
            return RedirectToAction("Index");
        }



        // with redirection
        /*
        public string Addition(int a, int b)
        {
            return _calcService.Addition(a, b).ToString();
        }

        public string Subtraction(int a, int b)
        {
            return _calcService.Subtraction(a, b).ToString();
        }
        public string Multiplication(int a, int b)
        {
            return _calcService.Multiplication(a, b).ToString();
        }
        public string Division(int a, int b)
        {
            return _calcService.Division(a, b).ToString();
        }
        */

    }
}
