using System;
using System.Text.RegularExpressions;
namespace Practical2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name, Country;
            do
            {
                Console.WriteLine("Hello! Whats your name?");
                Name = Console.ReadLine();
            } while (!Regex.IsMatch(Name, @"^[a-zA-Z]+$"));
            do
            {
                Console.WriteLine("Where are you from?");
                Country = Console.ReadLine();
            } while (!Regex.IsMatch(Country, @"^[a-zA-Z]+$"));

            Console.WriteLine($"Hello {Name} from country {Country}!");
            Console.Read();
        }
    }
}
