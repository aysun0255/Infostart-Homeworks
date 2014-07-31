using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 04.Decimal to Binary Number
 * Using loops write a program that converts an integer number to its binary representation. The input is entered as 
 * long. The output should be a variable of type string. 
 */

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter number to convert:");
        long number = long.Parse(Console.ReadLine());

        string binary = null;

        while (number > 0)
        {
            binary += number % 2;
            number = number / 2;
        }

        string binaryFinal = null;

        //Reverse the binary we have to get the final binary representation
        for (int i = binary.Length - 1; i >= 0; i--)
        {
            binaryFinal += binary[i];
        }

        Console.WriteLine(binaryFinal);
    }
}

