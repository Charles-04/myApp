using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myApp
{
    public class Library
    {
        public static void SixthSolution()
        {
            Console.WriteLine("Hi, What's your name ? ");
            var name = Console.ReadLine();
            Console.WriteLine("Dear " + name + " Welcome to our Library");
            Console.WriteLine(" We have a couple of books to choose from");
            Console.WriteLine(" Enter 'c' for C# books ");
            Console.WriteLine(" Enter 'o' for Dotnet books ");
            Console.WriteLine(" Enter 'd' for Clean Coding");
            Console.WriteLine(" Enter 'e' for EFCore Books");

            var SelectedOption = Console.ReadLine().ToLower();
            void CheckOptions()
            {
                switch (SelectedOption)
                {
                    case "c":
                        Console.WriteLine(" You Selected C# books");
                        break;
                    case "o":
                        Console.WriteLine(" You selected Dotnet books ");
                        break;
                    case "d":
                        Console.WriteLine(" You selected Clean Coding books ");
                        break;
                    case "e":
                        Console.WriteLine(" You selected EFCore books ");
                        break;
                    default:
                        Console.WriteLine(" You made an invalid selection ! Try again ");
                        Retry();
                        break;
                }
            }

            CheckOptions();
            void Retry()
            {
                Console.WriteLine(" Enter '1' to Try again or Enter any other key to exit");
                var Option = Console.ReadLine();
                int option;
                int.TryParse(Option, out option);
                int RETRYOPTION = 1;
                if (option == RETRYOPTION)
                {
                    SixthSolution();
                }
                else
                {
                    return;
                }

            }
        }
    }
}
