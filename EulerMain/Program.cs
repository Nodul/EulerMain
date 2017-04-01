using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerMain
{

    class Program
    {
        static void Main(string[] args)
        {
            //Remember that each problem should inherit from P
            //Also add a delegate in each problem class, so that you can exchange solution algorithms for comparison
            //also perhaps add a namespace for every 50 problems, so you won't pollute the global namespace
            P problem = new P5();
            problem.PrintResults();
        }
    }
}
