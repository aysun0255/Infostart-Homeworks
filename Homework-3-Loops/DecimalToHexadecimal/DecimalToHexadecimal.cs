using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 06.Decimal to Hexadecimal Number
 * Using loops write a program that converts an integer number to its hexadecimal representation. The input is entered 
 * as long. The output should be a variable of type string.
 */

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter decimal value to convert:");
        long decimalValue = long.Parse(Console.ReadLine());

        string hex = null;

        while (decimalValue > 0)
        {
            switch (decimalValue%16)
            {
                case 0:
                    hex += '0';
                    break;
                case 1:
                    hex += '1';
                    break;
                case 2:
                    hex += '2';
                    break;
                case 3:
                    hex += '3';
                    break;
                case 4:
                    hex += '4';
                    break;
                case 5:
                    hex += '5';
                    break;
                case 6:
                    hex += '6';
                    break;
                case 7:
                    hex += '7';
                    break;
                case 8:
                    hex += '8';
                    break;
                case 9:
                    hex += '9';
                    break;
                case 10:
                    hex += 'A';
                    break;
                case 11:
                    hex += 'B';
                    break;
                case 12:
                    hex += 'C';
                    break;
                case 13:
                    hex += 'D';
                    break;
                case 14:
                    hex += 'E';
                    break;
                case 15:
                    hex += 'F';
                    break;
                default:
                    Console.WriteLine("Inavlid  value!!!");
                    break;
            }
            decimalValue = decimalValue / 16;
        }

        string hexFinal = null;

        //Reverse the string
        for (int i = hex.Length-1; i >=0 ; i--)
        {
            hexFinal += hex[i];
        }

        Console.WriteLine("Hexadecimal value is:{0}",hexFinal);
    }
}

