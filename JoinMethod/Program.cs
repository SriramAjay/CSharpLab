using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JoinMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Started");
            //problem
            //Main Thread creating three child threads
            //main thread cann't wait 
            Thread thread1 = new Thread(CommonCls.Method1);
            Thread thread2 = new Thread(CommonCls.Method2);
            Thread thread3 = new Thread(CommonCls.Method3);
            thread1.Start();
            thread2.Start();
            thread3.Start();
            //to overcome that problem we need use joins
            //thread1.Join();
            //thread2.Join();
            //thread3.Join();

            if (thread3.Join(3000))
            {
                Console.WriteLine("Thread 3 Execution Completed in 3 second");
            }
            else
            {
                Console.WriteLine("Thread 3 Execution Not Completed in 3 second");
            }

            Console.WriteLine("Main Thread Ended");
            Console.Read();

        }
    }
}
