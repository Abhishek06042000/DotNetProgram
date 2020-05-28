using System;

namespace Practical3
{
    class Program
    {
        static void Main(string[] args)
        {
            //CONVERT BINARY TO DECIMAL 
            BinaryToDecimal();

            //CONVERT DECIMAL TO HEXADECIMAL
            DecimalToHexadecimal();            
        }

        //Method of BinarytoDecimal
        public static void BinaryToDecimal()
        {
            Console.Write("\t\t: Binary to Decimal :\n");
            int inputNumber, binaryValue, decimalValue = 0, baseValue = 1, temp;
            Console.Write("Enter a Binary Number(1's and 0's) : ");
            inputNumber = int.Parse(Console.ReadLine());
            binaryValue = inputNumber;
            while (inputNumber > 0)
            {
                temp = inputNumber % 10;
                decimalValue = decimalValue + temp * baseValue;
                inputNumber = inputNumber / 10;
                baseValue = baseValue * 2;
            }
            Console.Write("The Binary number is : " + binaryValue);
            Console.Write("\nIt's Decimal Equivalent is : " + decimalValue);
            Console.ReadLine();
        }

        //Method of DecimaltoHexadecimal 
        public static void DecimalToHexadecimal()
        {
            Console.Write("\n\n\t\t: Decimal to Hexadecimal :\n");
            int number;
            Console.Write("Enter a Decimal Number: ");
            number = int.Parse(Console.ReadLine());
            Console.Write("The Decimal number is : " + number);
            if (number < 1) 
                Console.Write("Not Valid!"); ;

            int hex = number;
            string hexStr = string.Empty;

            while (number > 0)
            {
                hex = number % 16;

                if (hex < 10)
                    hexStr = hexStr.Insert(0, Convert.ToChar(hex + 48).ToString());
                else
                    hexStr = hexStr.Insert(0, Convert.ToChar(hex + 55).ToString());

                number /= 16;
            }            
            Console.Write("\nIt's HexaDecimal Equivalent is : " + hexStr);
            Console.ReadLine();
        }  

    }
}
