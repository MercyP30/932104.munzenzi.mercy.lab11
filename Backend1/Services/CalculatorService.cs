using Backend1.Controllers;
using Backend1.Models;


namespace Backend1.Services
{
    public class CalculatorService : ICalculatorService
    {
        public CalculatorViewModel PerformCalculations(int num1, int num2)
        {
            CalculatorViewModel Output = new CalculatorViewModel();
            Output.num1 = num1;
            Output.num2 = num2;

            Output.AddResult = num1 + num2;
            Output.SubResult = num1 - num2;
            Output.MultResult = num1 * num2;

            if (num2 != 0)// Проверка на деление на ноль
            {
                Output.DivResult = num1 / num2;
            }
            else
            {
                Output.DivResult = 0; //обработайте ошибку деления на ноль по-другому
            }

            return Output;
        }
    }
}

