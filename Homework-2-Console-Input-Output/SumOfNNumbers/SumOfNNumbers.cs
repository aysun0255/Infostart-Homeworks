using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Problem 9. Sum of n Numbers
 * Write a program that enters a number n
 * and after that enters more n numbers and 
 * calculates and prints their sum. Note that 
 * you may need to use a for-loop.
 */

class SumOfNNumbers
{
    static void Main()
    {
        Console.Write("n:");
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        Console.WriteLine("Enter n numbers:");
        for (int i = 0; i < n; i++)
        {
            sum += double.Parse(Console.ReadLine());
        }

        Console.WriteLine("The sum of entered elements is:{0}", sum);

    }
}

