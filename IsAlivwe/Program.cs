using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IsAlive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Started");
            Thread thread1 = new Thread(Method1);
            thread1.Start();
            thread1.Join();
            if (thread1.IsAlive)
            {
                Console.WriteLine("Thread1 Method1 is still doing its work");
            }
            else
            {
                Console.WriteLine("Thread1 Method1 Completed its work");
            }
            
            Console.WriteLine("Main Thread Ended");
            Console.Read();
            Monitor
        }
        static void Method1()
        {
            Console.WriteLine("Method1 - Thread1 Started");
            Console.WriteLine("Method1 - Thread 1 Ended");
        }
    }
}
