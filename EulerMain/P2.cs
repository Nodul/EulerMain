﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerMain
{
    /// <summary>
    /// [DONE] Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be: 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
    /// <para></para>
    /// By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms
    /// </summary>
    class P2 :P
    {
        ulong num1 = 1;
        ulong num2 = 2;
        ulong current = 0;

        ulong CalculateSum()
        {
            ulong sum = 2; //starts with 2 because the the num2 is already 2 and it's easier to add here instead of incorparting it in a general solution

            while (current < 4000000)
            {
                current = num1 + num2;
                num1 = num2;
                num2 = current;

                if (current % 2 == 0) { sum += current; }
            }
      
            return sum;
        }

        internal override void PrintResults()
        {
            Console.WriteLine("P2. The sum of even Fibonacci numbers up to 4 mln is: "+CalculateSum());
        }
    }
}