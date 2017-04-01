using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerMain
{
    /// <summary>
    /// [DONE]A palindromic number reads the same both ways.The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
    /// <para>Find the largest palindrome made from the product of two 3-digit numbers</para>
    /// </summary>
    class P4 : P
    {

        internal override void PrintResults()
        {
            int result = FindPalindrome();
            //Console.WriteLine("Checking palindrome {0} : {1}",input,CheckIfPalindrome(input));
            Console.WriteLine("The largest palindrome of the product of two 3-digit numbers is {0}",result);
        }

        bool CheckIfPalindrome(int _num)
        {
            int[] temp = IntToIntArray(_num);

            for(int i = 0; i < temp.Length-1; i++)
            {
                if (temp[i] == temp[temp.Length-1-i]) continue; //all ok, it's still a palindrome
                else return false;
            }
            return true;
        }

        int FindPalindrome()
        {
            int largest = -1;
            int num1 = 999;
            int num2 = 999;
            List<int> allPalis = new List<int>();

            for(int i = num1; i > 0; i--)
            {
                for(int j = num2; j > 0; j--)
                {
                    
                    if (CheckIfPalindrome(i * j))
                    {
                        //Console.WriteLine("Found palindrome for numbers: {0} x {1} = {2}", i, j, (i * j));
                        allPalis.Add(i * j);
                    }
                }
            }

            largest = allPalis.Max();
            return largest;
        }

        //Idea 1: Well, most brutal idea is to start from 999 x 999, check if palindrome, if not do 998 x 999 etc
        //

        //Helpers:
        int[] IntToIntArray(int num)
        {
            List<int> result = new List<int>(); 

            for(;num != 0; num /= 10)
            {
                result.Add(num % 10);
            }

            var final = result.ToArray();
            Array.Reverse(final);

            return final;

        }
    }
}
