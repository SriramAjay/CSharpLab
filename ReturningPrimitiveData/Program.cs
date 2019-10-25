using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturningPrimitiveData
{
    class Program
    {
        //using anonymous method, returning pritive data
        static void Main(string[] args)
        {
            Console.WriteLine("$Main thread excution begin");
            Task<double> t1 = Task.Run(
                () => {
                    double sum = 0;
                    for (int i = 0; i < 10; i++)
                    {
                        sum = sum + i;
                    }
                    return sum;
                }
                );
            Console.WriteLine($"Sum is: {t1.Result}");
            Console.WriteLine("$Main thread excution End");
            Console.ReadLine();

        }

    }
}
