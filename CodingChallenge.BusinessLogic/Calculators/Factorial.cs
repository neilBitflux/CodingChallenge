using System.Numerics;
using CodingChallenge.BusinessLogic.Calculators.Interface;
using CodingChallenge.BusinessLogic.Validation;

namespace CodingChallenge.BusinessLogic.Calculators
{
    public class Factorial : ICalculator
    {
        public string Calculate(string value)
        {
            var number = InputValidator.IsPositiveWholeNumber(value);

            BigInteger result = 1;

            for (int i = Convert.ToInt32(number); i > 0; i--)
            {
                result *= i;
            }

            return result.ToString();
        }
    }
}