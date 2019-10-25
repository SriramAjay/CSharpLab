using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ParameterThreadStart
{
    class Program
    {
        static void Main(string[] args)
        {
            //Thread t1 = new Thread(DisplayNumbers);
            //t1.Start(5);

            Program obj = new Program();

            ParameterizedThreadStart PTSD = new ParameterizedThreadStart(ProblemWithParameterized.DisplayNumber);
            Thread t11 = new Thread(PTSD);

            t11.Start("HI");
            Console.ReadLine();
        }
        public static void DisplayNumbers(object Max)
        {
            int Number = Convert.ToInt32(Max);
            for (int i = 1; i <= Number; i++)
            {
                Console.WriteLine("Method1 :" + i);
            }
        }
    }
}
