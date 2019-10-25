using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace WithMultipleThreadMoreCors
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            stopwatch = Stopwatch.StartNew();
            Thread t1 = new Thread(EvenNumbersSum);
            Thread t2 = new Thread(OddNumbersSum);
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
            stopwatch.Stop();
            Console.WriteLine($"Total time in milliseconds : {stopwatch.ElapsedMilliseconds}");
            Console.ReadKey();

        }
        public static void EvenNumbersSum()
        {
            double Evensum = 0;
            for (int count = 0; count <= 50000000; count++)
            {
                if (count % 2 == 0)
                {
                    Evensum = Evensum + count;
                }
            }
            Console.WriteLine($"Sum of even numbers = {Evensum}");
        }
        public static void OddNumbersSum()
        {
            double Oddsum = 0;
            for (int count = 0; count <= 50000000; count++)
            {
                if (count % 2 == 1)
                {
                    Oddsum = Oddsum + count;
                }
            }
            Console.WriteLine($"Sum of odd numbers = {Oddsum}");
        }
    }
}

