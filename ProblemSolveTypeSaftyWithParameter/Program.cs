using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ProblemSolveTypeSaftyWithParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 5;
            NumberHelper num = new NumberHelper(max);
            Thread t1 = new Thread(num.DisplayNumbers);
            t1.Start();
            Console.ReadLine();
        }
    }
}
