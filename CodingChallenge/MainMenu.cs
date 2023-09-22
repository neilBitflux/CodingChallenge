using CodingChallenge.BusinessLogic.Calculators;

namespace CodingChallenge
{
    static class MainMenu
    {
        public static bool Run()
        {
            Console.Clear();
            Console.WriteLine("Choose a calculator: ");
            Console.WriteLine("(1) Factorial");
            Console.WriteLine("(2) FizzBuzz");
            Console.WriteLine("(3) Exit");
            Console.WriteLine("\r\nSelect an option: ");

            CalculatorContext calculator;

            switch (Console.ReadLine())
            {
                case "1":
                    FactoralConsoleManager.Run();
                    return true;
                case "2":
                    FizzBuzzConsoleManager.Run();
                    return true;
                case "3":
                    return false;
                    default: return true;
            }
        }
    }
}
