using CodingChallenge.BusinessLogic;
using System.Runtime.InteropServices;

namespace CodingChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu.Run();
                if (showMenu)
                {
                    Console.WriteLine();
                    Console.WriteLine("Do you want to try again? [y/n]");
                    var response = Console.ReadKey(false);

                    if (response.Key == ConsoleKey.N)
                    {
                        showMenu = false;
                    }
                }
            }

        }
    }
}