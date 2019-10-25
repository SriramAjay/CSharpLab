using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SingleThreadAndUnderstanding
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = Thread.CurrentThread;
            //By Default the Thread does not have any name
            //if you want then you can provide the name explicitly
            t.Name = "This is test thread";
            Console.WriteLine( "This is ajay  " + Thread.CurrentThread.Name);
            Console.ReadLine();
        }
    }
}
