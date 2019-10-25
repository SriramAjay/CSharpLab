using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AvoidDeadlock
{
    class AccountManagerUsingMonitor
    {
        private Account FromAccount;
        private Account ToAccount;
        private double TransferAmount;

        public AccountManagerUsingMonitor(Account AccountFrom, Account AccountTo, double AmountTransfer)
        {
            FromAccount = AccountFrom;
            ToAccount = AccountTo;
            TransferAmount = AmountTransfer;
        }

        public void FundTransfer()
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} trying to acquire lock on {FromAccount.ID}");
            lock (FromAccount)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} acquired lock on {FromAccount.ID}");
                Console.WriteLine($"{Thread.CurrentThread.Name} Doing Some work");
                Thread.Sleep(1000);
                Console.WriteLine($"{Thread.CurrentThread.Name} trying to acquire lock on {ToAccount.ID}");
                // here we are using monitor.tryenter
                if (Monitor.TryEnter(ToAccount,1500))
                {
                    FromAccount.Withdraw(TransferAmount);
                    ToAccount.Deposite(TransferAmount);
                }
               
            }
        }
    }
}
