using CodingChallenge.BusinessLogic.Calculators;

namespace CodingChallenge
{
    static class FactoralConsoleManager
    {
        public static void Run()
        {
            CalculatorContext calculator;
            calculator = new CalculatorContext(new Factorial());
            var result = "unknown";
            try
            {
                result = calculator.Execute(GetConsoleInput());
                DisplayResult(result);
            }
            catch (ArgumentOutOfRangeException)
            {
                DisplayArgumentException();
            }
            catch (ArgumentException)
            {
                DisplayArgumentException();
            }
            catch (Exception ex)
            {
                DisplayUnhandeledException();
            } 
        }

        private static string GetConsoleInput()
        {
            Console.WriteLine("PLease input a whole number > 0");
            return Console.ReadLine();
        }


        private static void DisplayResult(string result)
        {
            Console.WriteLine($"the answer is: {result}");
        }

        private static void DisplayArgumentException()
        {
            Console.WriteLine("Invalid! Please input a whole number > 0");
        }

        private static void DisplayUnhandeledException()
        {
            Console.WriteLine("Oops something when wrong!");
        }
    }
}
