using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RetrieveData
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number = 10;
            //Create the ResultCallbackDelegate instance and to its constructor 
            //pass the callback method name
            NumberHelper obj = new NumberHelper(Number,ResultCallBackMethod);
            Thread T1 = new Thread(new ThreadStart(obj.CalculateSum));
            T1.Start();
            Console.Read();
        }
        //Callback method and the signature should be the same as the callback delegate signature
        public static void ResultCallBackMethod(int Result)
        {
            Console.WriteLine("The Result is " + Result);
        }

    }
}
