using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerMain
{
    /// <summary>
    /// [DONE]The prime factors of 13195 are 5, 7, 13 and 29.
    ///<para></para>
    ///What is the largest prime factor of the number 600851475143 ?
    /// </summary>
    class P3 : P
    {
        /// "Prime Factorization" is finding which prime numbers multiply together to make the original number.
        /// Example: 2 x 3 = 6; 2 and 3 are the prime factors of 6 [prime factor = czynnik pierwszy]
        /// these factors can occur several times: 12 = 2 × 2 × 3
        /// if the number is a prime number, then it is it's own prime factor: 17 = 17
        /// There is only one (unique!) set of prime factors for any number.
        /// Example: 330 = 2 × 3 × 5 × 11; there is no other possible set of prime numbers which multiplied would give 330

        ///Observation: if you divide a number by one it prime factors, you "remove" that factor from the pool,
        ///Example: if you divide 12 by 2 = get 6 which leaves only 2 x 3 as prime factors [this is handy]
        long input = 600851475143;
        //long result = -1;

          
        internal override void PrintResults()
        {
            Console.WriteLine("P3. The largest prime factor of {0} is {1}.",input,CalculateLargestFactor(input));
        }
        /// <summary>
        /// Very ineffective, goes through all numbers instead of only primes;  0 means an error has occured;
        /// </summary>
        long CalculateLargestFactor(long _input)
        {
            long largest = 0;
            for (long i = 2; i <= _input; i++)
            {
                //Console.WriteLine("Starting i= "+i);
                if(_input % i == 0)  
                {
                    Console.WriteLine("Found factor: {0}",i);
                    if (i > largest)
                    {
                        largest = i;
                       // Console.Write(" Found new largest: "+largest);
                    }           
                    _input /= i;
                    i--; //to try again in case multiples of one prime factor happen
                }

            }

            return largest;
        }

    }
}
