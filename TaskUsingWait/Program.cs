using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskUsingWait
{
    // we are calling the Wait() method on the task1 object to make the program execution wait until the task1 completes its execution.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Main Thread : {Thread.CurrentThread.ManagedThreadId} Statred");
            Task task1 = Task.Run(() => { PrintNumbers(); });
            task1.Wait();
            Console.WriteLine($"Main Thread : {Thread.CurrentThread.ManagedThreadId} Completed");
            Console.ReadKey();
        }
        static void PrintNumbers()
        {
            Console.WriteLine($"Child Thread : {Thread.CurrentThread.ManagedThreadId} Started");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Count value is {i}");
            }
            Console.WriteLine($"Child Thread : {Thread.CurrentThread.ManagedThreadId} Completed");

        }
    }
}
