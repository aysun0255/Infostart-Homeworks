using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 07.Odd and Even Product
 * You are given n integers (given in a single line, separated by a space). Write a program that checks whether the 
 * product of the odd elements is equal to the product of the even elements. Elements are counted from 1 to n, so the 
 * first element is odd, the second is even, etc.
 */

class OddEvenProduct
{
    static void Main()
    {
        string numbers = Console.ReadLine();
        string[] numbersArray = numbers.Split(' ');
        int[] nums = new int[numbersArray.Length];

        //Parse the input
        for (int i = 0; i < numbersArray.Length; i++)
        {
            nums[i] = int.Parse(numbersArray[i]);
        }

        int oddProduct = 1;
        int evenProduct = 1;

        for (int i = 0; i < nums.Length; i++)
        {
            if (i % 2 == 0)
            {
                evenProduct *= nums[i];
            }
            else
            {
                oddProduct *= nums[i];
            }
        }

        if (oddProduct == evenProduct)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = {0}", evenProduct);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_product = {0}", oddProduct);
            Console.WriteLine("even_product = {0}", evenProduct);
        }

    }
}

