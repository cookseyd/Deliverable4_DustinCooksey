using System;

/*
 * Author: Dustin Cooksey
 * Date: 02/06/2023
 * Description: This C# Console application calculates the
 * first 25 instances of the Fibonacci sequence and then
 * stores them in an array to output them
 * 
*/

namespace Deliverable4_DustinCooksey
{
    class Deliverable4_DC
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int c = 0;

            int[] fib = new int[25];
            fib[0] = a;
            fib[1] = b;

            for(int d = 0; d < fib.Length; d++)
            {
                if (d >= 2)
                {
                    fib[d] = fib[d - 1] + fib[d - 2];
                }
            }

            for (int d = 0; d < fib.Length; d++)
            {
                Console.WriteLine(fib[d]);
            }

        }
    }
}
