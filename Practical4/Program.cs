using System;

namespace Practical4
{
    class Program
    {
        static void Main(string[] args)
        {
            //CONVERT DECIMAL TO BINARY 
            DecimalToBinary();

            //CONVERT DECIMAL TO OCTAL
            DecimalToOctal();
        }

        //Method of DecimaltoBinary
        public static void DecimalToBinary()
        {
            Console.Write("\t\t: Decimal to Binary :\n");
            string result;
            Console.Write("Enter a Decimal Number: ");
            int dnumber = Int32.Parse(Console.ReadLine());
            Console.Write("The Decimal number is : " + dnumber);
            result = "";
            while (dnumber > 1)
            {
                int remainder = dnumber % 2;
                result = Convert.ToString(remainder) + result;
                dnumber /= 2;
            }
            result = Convert.ToString(dnumber) + result;
            Console.WriteLine("\nIt's Binary Equivalent is : " + result);
            Console.ReadLine();
        }

        //Method of DecimaltoOctal
        public static void DecimalToOctal()
        {
            Console.Write("\n\n\t\t: Decimal to Octal :\n");
            Console.Write("Enter a Decimal Number: ");
            int dnumber = Int32.Parse(Console.ReadLine());
            Console.Write("The Decimal number is : " + dnumber);
            int[] octalNum = new int[100];
            int i = 0;
            while (dnumber != 0)
            {
                octalNum[i] = dnumber % 8;
                dnumber = dnumber / 8;
                i++;
            }
            Console.Write("\nIt's octal Equivalent is : ");
            for (int j = i - 1; j >= 0; j--)
                Console.Write(octalNum[j]);
            
            Console.ReadLine();
        }
    }
}
