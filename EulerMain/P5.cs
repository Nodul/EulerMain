using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerMain
{
    /// <summary>
    /// [DONE, O(n^2) :( ]2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
    /// <para></para>
    /// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
    /// </summary>
    class P5 : P
    {
        int lowBound = 1;
        int topBound = 20;

        internal override void PrintResults()
        {
            Console.WriteLine("P5. The smallest positive number that is evenly divisible\nby all numbers from {0} to {1} is {2}",lowBound,topBound, FindSmallestEvenDivisible(lowBound,topBound));
        }

        int FindSmallestEvenDivisible(int a, int b)
        {
            int result = 0;
            bool divisable;

            for(int i = b; ; i++) //no second param since I don't know where it will end XD
            {
                divisable = true;
                for(int j = 2; j <= 20; j++)
                {
                    if (i % j != 0)
                    {
                        divisable = false;
                        break;
                    } 
                  
                }
                if (divisable) return i;
            }

            return result;
        }

        //Idea 1: just loop around from 1 to 20 and checks if it is a divisor

    }
}
