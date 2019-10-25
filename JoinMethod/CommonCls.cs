using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JoinMethod
{
   public class CommonCls
    {
        public static void Method1()
        {
            Console.WriteLine("Method1 - Thread1 Started");
            Thread.Sleep(3000);
            Console.WriteLine("Method1 - Thread 1 Ended");
        }
        public static void Method2()
        {
            Console.WriteLine("Method2 - Thread2 Started");
            Thread.Sleep(2000);
            Console.WriteLine("Method2 - Thread2 Ended");
        }
        public static void Method3()
        {
            Console.WriteLine("Method3 - Thread3 Started");
            Thread.Sleep(5000);
            Console.WriteLine("Method3 - Thread3 Ended");
        }

    }
}
