using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SemaphoreDemo
{
    class Program
    {
        //2-is intial number of requrests can be served and 3 is maximum
        public static Semaphore semaphore = new Semaphore(4, 5);
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Thread threadObject = new Thread(DoSomeTask)
                {
                    Name = "Thread " + i
                };
                threadObject.Start(i);
            }
            Console.ReadKey();
        }
        static void DoSomeTask(object id)
        {
            Console.WriteLine(Thread.CurrentThread.Name + " Wants to Enter into Critical Section for processing");
            try
            {
                //Blocks the current thread until the current WaitHandle receives a signal.   
                semaphore.WaitOne();
                Console.WriteLine("Success: " + Thread.CurrentThread.Name + " is Doing its work");
                Thread.Sleep(5000);
                Console.WriteLine(Thread.CurrentThread.Name + "Exit.");
            }
            finally
            {
                //Release() method to releage semaphore  
                semaphore.Release();
            }
        }

    }
}

