using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 05.Hexadecimal to Decimal Number
 * Using loops write a program that converts a hexadecimal integer number to its decimal form. The input is entered as 
 * string. The output should be a variable of type long. 
 */

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.Write("Enter hexadecimal value to convert:");
        string hex = Console.ReadLine();

        long decimalValue = 0;

        for (int i = 0; i < hex.Length; i++)
        {
            switch (hex[i])
            {
                case '0':
                    decimalValue += 0 *(long) Math.Pow(16, hex.Length - i - 1);
                    break;
                case '1':
                    decimalValue += 1 * (long)Math.Pow(16, hex.Length - i - 1);
                    break;
                case '2':
                    decimalValue += 2 * (long)Math.Pow(16, hex.Length - i - 1);
                    break;
                case '3':
                    decimalValue += 3 * (long)Math.Pow(16, hex.Length - i - 1);
                    break;
                case '4':
                    decimalValue += 4 * (long)Math.Pow(16, hex.Length - i - 1);
                    break;
                case '5':
                    decimalValue += 5 * (long)Math.Pow(16, hex.Length - i - 1);
                    break;
                case '6':
                    decimalValue += 6 * (long)Math.Pow(16, hex.Length - i - 1);
                    break;
                case '7':
                    decimalValue += 7 * (long)Math.Pow(16, hex.Length - i - 1);
                    break;
                case '8':
                    decimalValue += 8 * (long)Math.Pow(16, hex.Length - i - 1);
                    break;
                case '9':
                    decimalValue += 9 * (long)Math.Pow(16, hex.Length - i - 1);
                    break;
                case 'A':
                    decimalValue += 10 * (long)Math.Pow(16, hex.Length - i - 1);
                    break;
                case 'B':
                    decimalValue += 11 * (long)Math.Pow(16, hex.Length - i - 1);
                    break;
                case 'C':
                    decimalValue += 12 * (long)Math.Pow(16, hex.Length - i - 1);
                    break;
                case 'D':
                    decimalValue += 13 * (long)Math.Pow(16, hex.Length - i - 1);
                    break;
                case 'E':
                    decimalValue += 14 * (long)Math.Pow(16, hex.Length - i - 1);
                    break;
                case 'F':
                    decimalValue += 15 * (long)Math.Pow(16, hex.Length - i - 1);
                    break;
                default:
                    Console.WriteLine("Inavlid hex value!!!");
                    break;
            }
        }

        Console.WriteLine("Decimal value:{0}",decimalValue);
    }
}

