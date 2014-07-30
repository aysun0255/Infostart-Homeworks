using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Problem 16. ** – Magic Strings
 * This problem is from Variant 3 of C# 
 * Basics exam from 11-04-2014 Morning.
 * ....................................
 * ....................................
 */


class MagicStrings
{
    static void Main(string[] args)
    {
        int diff = int.Parse(Console.ReadLine());
        char[] letters = { 'k', 'n', 'p', 's' };
        int[] weight = { 1, 4, 5, 3 };
        int firstWeight = 0;
        int secondWeight = 0;
        int maxResults = 0;

        string result = String.Empty;
        int weightr = 0;
        List<string> results = new List<string>();
        List<int> weights = new List<int>();
        for (int f = 0; f < letters.Length; f++)
        {
            for (int s = 0; s < letters.Length; s++)
            {
                for (int t = 0; t < letters.Length; t++)
                {
                    for (int fo = 0; fo < letters.Length; fo++)
                    {
                        result += letters[f];
                        weightr += weight[f];
                        result += letters[s];
                        weightr += weight[s];
                        result += letters[t];
                        weightr += weight[t];
                        result += letters[fo];
                        weightr += weight[fo];
                        results.Add(result);
                        weights.Add(weightr);
                        result = String.Empty;
                        weightr = 0;
                    }

                }

            }

        }

        for (int i = 0; i < results.Count; i++)
        {
            for (int k = 0; k < results.Count; k++)
            {
                if (i != k)
                {

                    if (Math.Abs(weights[i] - weights[k]) == diff)
                    {
                        Console.WriteLine(results[i] + results[k]);
                        maxResults++;

                    }

                }
            }
        }

        if (maxResults == 0)
        {
            Console.WriteLine("No");
        }


    }
}
