using System.Text;
using CodingChallenge.BusinessLogic.Calculators.Interface;
using CodingChallenge.BusinessLogic.Validation;

namespace CodingChallenge.BusinessLogic.Calculators
{
    public class FizzBuzz : ICalculator
    {
        public string Calculate(string value)
        {
            var number = InputValidator.IsPositiveWholeNumber(value);
            InputValidator.IsLessThanOrEqualTo(number, Convert.ToInt16(value));

            var i = 1;  // canned as this is what was asked for
            var builder = new StringBuilder();

            while (i <= number)
            {
                builder.Append(CalculateFizzBuzzFornumber(i));
                builder.Append(Environment.NewLine);
                i++;
            }
            return builder.ToString();
        }


        public string CalculateFizzBuzzFornumber(int number)
        {
            var result = string.Empty;
            if (number % 3 == 0 && number % 5 == 0)
            {
                result = "FizzBuzz";
            }
            else if (number % 3 == 0)
            {
                result = "Fizz";
            }
            else if (number % 5 == 0)
            {
                result = "Buzz";
            }
            else
            {
                result = number.ToString();
            }
            return result;
        }
    }
}