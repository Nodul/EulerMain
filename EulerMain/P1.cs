using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerMain
{
    /// <summary>
    /// [DONE!] If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    ///<para></para>
    ///Find the sum of all the multiples of 3 or 5 below 1000
    /// </summary>
    class P1 : P
    {
        int input = 1000;
        int start = 1;

        int CalculateSum()
        {
            int sum = 0;
            for (int i = start; i< input;i++)
            {
                if(i % 3 == 0 || i % 5 == 0) 
                {
                    sum += i;
                    //Console.Write(i+", ");
                }
            }
            return sum;
        }

        override internal void PrintResults()
        {
            Console.WriteLine("P1. The sum in range [{0},{1}) is: {2}",start,input,CalculateSum());
        }
        
        ///Comments:
        ///For 1 000 000 it's visually as fast as for 1 000, but for 1 000 000 000 it takes about 25 seconds 
        ///[In this case I think the sum overflows, so it should be changed to BigInteger for such a range 
    }
}
