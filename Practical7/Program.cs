using System;
using System.Globalization;

namespace Practical7
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal rupees, dollor, frank, euro;

            Console.Write("Enter amount in INR: ");
            rupees = decimal.Parse(Console.ReadLine());

            dollor = 0.0139531M * rupees;
            frank = 0.0135894M * rupees;
            euro = 0.0127937M * rupees;

            Console.WriteLine($"INR {rupees} = {dollor.ToString("C", new CultureInfo("en-US"))}");
            Console.WriteLine($"INR {rupees} = {frank.ToString("C", new CultureInfo("de-CH"))}");
            Console.WriteLine($"INR {rupees} = {euro.ToString("C", new CultureInfo("en-GB"))}");
            Console.Read();

        }
    }
}
