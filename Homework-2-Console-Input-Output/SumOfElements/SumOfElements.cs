using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Problem 14. **– Sum of Elements
 * This problem is from Variant 3 of C# 
 * Basics exam from 11-04-2014 Morning.
 * ....................................
 * ....................................
 */

namespace SumOfElements
{
    class SumOfElements
    {
        static void Main()
        {
            checked
            {
                string input = Console.ReadLine();
                string[] nums = input.Split(' ');
                long[] numss = new long[nums.Length];
                long sum = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    numss[i] = long.Parse(nums[i]);
                }

                List<long> mindiff = new List<long>();
                bool isNo = false;
                long rsum = 0;
                for (int i = 0; i < numss.Length; i++)
                {
                    for (int k = 0; k < numss.Length; k++)
                    {
                        if (i != k)
                        {
                            sum += numss[k];
                        }
                    }

                    if (numss[i] == sum)
                    {
                        isNo = false;
                        rsum = sum;
                        break;
                    }
                    else
                    {
                        isNo = true;

                        mindiff.Add(Math.Abs(numss[i] - sum));


                    }
                    sum = 0;

                }

                if (isNo == false)
                {
                    Console.WriteLine("Yes, sum={0}", rsum);
                }
                else
                {
                    Console.WriteLine("No, diff={0}", mindiff.Min());
                }


            }
        }
    }
}
