using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Problem 13. * – Work Hours
 * This problem is from Variant 3 of C# 
 * Basics exam from 11-04-2014 Morning. 
 * ..............................................
 * ..............................................
 * ..............................................
 */


class WorkHours
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        double workHours = (d - (0.10 * d)) * 12;
        decimal efficientWorkHours = (decimal)(workHours * p) / 100;
        int difference = (int)Math.Truncate(efficientWorkHours) - h;
        if (efficientWorkHours < h)
        {
            Console.WriteLine("No");
            Console.WriteLine("{0}", difference);
        }
        else
        {
            Console.WriteLine("Yes");
            Console.WriteLine(difference);
        }

    }
}
