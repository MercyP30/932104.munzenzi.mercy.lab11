using Backend1.Models;

namespace Backend1.Controllers
{
    public interface ICalculatorService
    {
        CalculatorViewModel PerformCalculations(int num1, int num2);
    }
}