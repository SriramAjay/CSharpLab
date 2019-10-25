using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DeadlockingProblemDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread started");
            Account CNBKMTAJAY100 = new Account(4965, 5000);
            Account CNBKMTANIL101 = new Account(4966, 2000);
            //single transaction
            AccountManager TransfertAmountToAnil = new AccountManager(CNBKMTAJAY100, CNBKMTANIL101, 2000);
            Thread t1 = new Thread(TransfertAmountToAnil.FundTransfer) { Name = "Ajay transfering funds to anil" };
            //if both users send in transaction like below
            AccountManager TransfertAmountToAjay = new AccountManager(CNBKMTANIL101, CNBKMTAJAY100, 2500);
            Thread t2 = new Thread(TransfertAmountToAjay.FundTransfer) { Name = "Anil transfering funds to ajay" };
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
            Console.WriteLine("Remaing balance is "+ CNBKMTAJAY100.Balance);
            Console.WriteLine("Main Thread end");
            Console.ReadLine();
        }
    }
}
