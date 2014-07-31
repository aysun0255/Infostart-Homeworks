using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *08.Matrix of Numbers
 * Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the 
 * examples below. Use two nested loops.
 * 
 */

class MatrixOfNumbers
{
    static void Main()
    {
        Console.Write("n:");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            for (int k = i+1; k < i+1+n; k++)
            {
                Console.Write("{0}",k);
            }
            Console.WriteLine();
        }

    }
}

