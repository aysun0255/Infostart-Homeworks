using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Problem 7. Sum of 5 Numbers
 * Write a program that enters 5 numbers
 * (given in a single line, separated by a 
 * space), calculates and prints their sum
 * 
 */

class SumOfFiveNumbers
{
    static void Main()
    {
        Console.Write("Enter five numbers(seperated by space):");
        string input = Console.ReadLine();
        string[] inputSplitted = input.Split(' ');
        double[] numbers = new double[5];
        for (int i = 0; i < 5; i++)
        {
            numbers[i] = double.Parse(inputSplitted[i]);
        }

        double sum = 0;

        for (int i = 0; i < 5; i++)
        {
            sum += numbers[i];
        }

        Console.WriteLine("The sum of entered five elements is:{0}", sum);
    }
}

