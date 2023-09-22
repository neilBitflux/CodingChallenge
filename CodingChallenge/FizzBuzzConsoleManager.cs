using CodingChallenge.BusinessLogic.Calculators;

namespace CodingChallenge
{
    static class FizzBuzzConsoleManager
    {    
        public static void Run()
        {
            CalculatorContext calculator;
            calculator = new CalculatorContext(new FizzBuzz());
            var result = "unknown";
            try
            {
                // canned as this is what was asked for
                result = calculator.Execute("100"); 
                DisplayResult(result);
            }
            catch (Exception ex)
            {
                DisplayUnhandeledException();
            } 
        }

        private static void DisplayResult(string result)
        {
            Console.WriteLine();
            Console.WriteLine("Result:");
            Console.WriteLine(result);
        }

        private static void DisplayUnhandeledException()
        {
            Console.WriteLine("Oops something when wrong!");
        }
    }
}
