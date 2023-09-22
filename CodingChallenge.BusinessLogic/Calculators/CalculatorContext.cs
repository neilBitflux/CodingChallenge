using CodingChallenge.BusinessLogic.Calculators.Interface;

namespace CodingChallenge.BusinessLogic.Calculators
{
    public class CalculatorContext
    {
        private ICalculator _calculator;
        public CalculatorContext(ICalculator callculator)
        {
            Set(callculator);
        }

        public string Execute(string value)
        {
            return _calculator.Calculate(value);
        }

        private void Set(ICalculator callculator)
        {
            _calculator = callculator;
        }
    }
}