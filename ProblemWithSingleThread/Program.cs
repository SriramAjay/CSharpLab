using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ProblemWithSingleThread
{
    class Program
    {
        /* if we have three methods in our application and if all these three methods are going to be called from the Main method. 
         * Then the main thread is responsible to execute all these three methods sequentially i.e. one by one. 
         * It will execute the first method and once it completes the execution of the first method then only it executes the second method and so on.         
         */ 
         
        static void Main(string[] args)
        {
            Method1();
            Method2();
            Method3();
            Console.Read();
        }
        static void Method1()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method1 :" + i);
            }
        }

        static void Method2()
        {
            for (int i = 1; i <= 5; i++)
            {
                if (i==3)
                {
                    //database connection or getting data from db
                    Thread.Sleep(1000);
                    Console.WriteLine("wait for 10 seconds");
                }
                Console.WriteLine("Method2 :" + i);
            }
        }

        static void Method3()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method3 :" + i);
            }
        }
    }
}
