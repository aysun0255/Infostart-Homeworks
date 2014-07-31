using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 10.Random Numbers in Given Range
 * Write a program that enters 3 integers n, min and max (min ≤ max) and prints n random numbers in the range 
 * [min...max].
 */

class RandomNumbersInRange
{
    static void Main()
    {
        //Read n min and max
        Console.Write("n:");
        int n = int.Parse(Console.ReadLine());
        Console.Write("min:");
        int min = int.Parse(Console.ReadLine());
        Console.Write("max:");
        int max = int.Parse(Console.ReadLine());

        Random rand = new Random();

        for (int i = 0; i < n; i++)
        {

            Console.Write("{0} ", rand.Next(min, max));
        }
        Console.WriteLine();

    }
}

