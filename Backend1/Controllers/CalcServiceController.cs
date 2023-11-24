using Backend1.Models;
using Backend1.Services;
using Microsoft.AspNetCore.Mvc;

namespace Backend1.Controllers
{
    public class CalcServiceController : Controller
    {
        private readonly ICalculatorService _calculatorService;

        public CalcServiceController(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        public IActionResult PassUsingModel()
        {
            Random random = new Random();
            int firstNumber = random.Next(0, 11);
            int secondNumber = random.Next(0, 11);

            CalculatorViewModel Output = _calculatorService.PerformCalculations(firstNumber, secondNumber);

            return View(Output);
        }

        public IActionResult PassUsingViewData()
        {
            Random random = new Random();
            int firstNumber = random.Next(0, 11);
            int secondNumber = random.Next(0, 11);

            CalculatorViewModel Output = _calculatorService.PerformCalculations(firstNumber, secondNumber);

            ViewData["num1"] = Output.num1;
            ViewData["num2"] = Output.num2;
            ViewData["AddResult"] = Output.AddResult;
            ViewData["SubResult"] = Output.SubResult;
            ViewData["MultResult"] = Output.MultResult;
            ViewData["DivResult"] = Output.DivResult;


            return View(Output);
        }

        public IActionResult PassUsingViewBag()
        {
            Random random = new Random();
            int firstNumber = random.Next(0, 11);
            int secondNumber = random.Next(0, 11);

            CalculatorViewModel Output = _calculatorService.PerformCalculations(firstNumber, secondNumber);

            ViewBag.firstNumber = Output.num1;
            ViewBag.secondNumber = Output.num2;
            ViewBag.AddResult = Output.AddResult;
            ViewBag.SubResult = Output.SubResult;
            ViewBag.MultResult = Output.MultResult;
            ViewBag.DivResult = Output.DivResult;

            return View(Output);
        }

        public IActionResult AccessServiceDirectly()
        {
            return View();
        }
    }
}

