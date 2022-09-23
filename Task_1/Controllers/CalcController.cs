using Microsoft.AspNetCore.Mvc;
using Task_1.Service;

namespace Task_1.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Add(int value1, int value2)
        {
            return View("Arithmetic", Calculator.Add(value1, value2));
        }

        public IActionResult Mul(int value1, int value2)
        {
            return View("Arithmetic", Calculator.Mul(value1, value2));
        }

        public IActionResult Div(int value1, int value2)
        {
            return View("Arithmetic", Calculator.Div(value1, value2));
        }

        public IActionResult Sub(int value1, int value2)
        {
            return View("Arithmetic", Calculator.Sub(value1, value2));
        }
    }
}
