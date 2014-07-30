using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Problem 3. Circle Perimeter and Area
 * Write a program that reads the radius r of a 
 * circle and prints its perimeter and area 
 * formatted with 2 digits after the decimal 
 * point.
 */

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Enter circle radius:");
        decimal radius = decimal.Parse(Console.ReadLine());
        decimal perimeter = 2 * (decimal)Math.PI * radius;
        decimal area = (decimal) Math.PI * (radius * radius);
        Console.WriteLine("Perimeter:{0:0.00} , Area:{1:0.00}",perimeter,area);
    }
}

