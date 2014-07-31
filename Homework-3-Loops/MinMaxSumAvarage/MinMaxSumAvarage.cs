using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 03. Min, Max, Sum and Average of N Numbers
 * Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the 
 * maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point). The input
 * starts by the number n (alone in a line) followed by n lines, each holding an integer number. The output is like in the 
 * examples below.
 * 
 */

class MinMaxSumAvarage
{
    static void Main()
    {
        Console.Write("N:");
        int n = int.Parse(Console.ReadLine());

        int? min = null;
        int max = 0;
        double sum = 0;

        for (int i = 0; i < n; i++)
        {
            int input = int.Parse(Console.ReadLine());

            if (min == null)
            {
                min = input; 
            }
            if ( input < min )
            {
                min = input;
            }

            if (input > max)
            {
                max = input;
            }

            sum += input;
            
        }

        double avarage = sum / n;
        Console.WriteLine("min:{0},max:{1},sum:{2},avarage:{3:0.00}",min,max,sum,avarage);
    }
}

