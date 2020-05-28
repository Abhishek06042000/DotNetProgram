using System;

namespace Practical8
{
    class Program
    {
        static void Main(string[] args)
        {
            float celsius, fahrenheit;
            int choice;
            Console.WriteLine("Give your choice:");
            Console.WriteLine("1. Celsius to Fahrenheit");
            Console.WriteLine("2. Fahrenheit to Celsius");

            choice = int.Parse(Console.ReadLine());
            
            switch (choice)
            {
                case 1:               
                    Console.Write("Enter temperature in celsius(°C):  ");
                    celsius = float.Parse(Console.ReadLine());

                    fahrenheit = celsius * 9 / 5 + 32;
                    Console.WriteLine($"{celsius}°C = {fahrenheit}°F");
                    break;
                case 2:
                    Console.Write("Enter temperature in fahrenheit(°F):  ");
                    fahrenheit = float.Parse(Console.ReadLine());

                    celsius = (fahrenheit - 32) * 5 / 9;
                    Console.WriteLine($"{fahrenheit}°F = {celsius}°C");
                    break;
            }
            Console.Read();
        }
    }
}
