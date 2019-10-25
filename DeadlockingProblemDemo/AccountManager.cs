using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DeadlockingProblemDemo
{
    class AccountManager
    {
        private Account FromAccount;
        private Account ToAccount;
        private double TransferAmount;

        public AccountManager(Account AccountFrom, Account AccountTo, double AmountTransfer)
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

                lock (ToAccount)
                {

                    FromAccount.Withdraw(TransferAmount);
                    ToAccount.Deposite(TransferAmount);
                }
            }
        }
    }
}
