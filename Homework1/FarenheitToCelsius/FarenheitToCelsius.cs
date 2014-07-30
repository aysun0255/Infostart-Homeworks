using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FarenheitToCelsius
{

    static void Main(string[] args)
    {
        Console.Write("Enter temperature in Farenheit:");
        int farenheit = int.Parse(Console.ReadLine());
        int celsius = FarenheitToCelsiuss(farenheit);
        Console.WriteLine("Temperature in celsius:{0}",celsius);
    }

    static int FarenheitToCelsiuss(int farenheit)
    {
        int celsius = ((farenheit - 32) * 5) / 9;
        return celsius;
    }
}


