using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Problem 1. Sum of 3 Numbers
 * Write a program that reads 3 real 
 * numbers from the console and prints their 
 * sum
 * 
 */

class SumOfThreeNumbers
{
    static void Main()
    {
        Console.Write("a:");
        decimal a = decimal.Parse(Console.ReadLine());
        Console.Write("b:");
        decimal b = decimal.Parse(Console.ReadLine());
        Console.Write("c:");
        decimal c = decimal.Parse(Console.ReadLine());

        decimal sum = a + b + c;
        Console.WriteLine("a + b + c = {0}",sum);

    }
}

