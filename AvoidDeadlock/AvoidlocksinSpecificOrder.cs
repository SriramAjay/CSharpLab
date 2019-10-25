using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AvoidDeadlock
{
    class AvoidlocksinSpecificOrder
    {
        private Account FromAccount;
        private Account ToAccount;
        private double TransferAmount;

        public AvoidlocksinSpecificOrder(Account AccountFrom, Account AccountTo, double AmountTransfer)
        {
            FromAccount = AccountFrom;
            ToAccount = AccountTo;
            TransferAmount = AmountTransfer;
        }

        //need to clarify dought
        public void FundTransfer()
        {
            object _lock1, _lock2;
            if (FromAccount.ID < ToAccount.ID)
            {
                _lock1 = FromAccount;
                _lock2 = ToAccount;
            }
            else
            {
                _lock1 = ToAccount;
                _lock2 = FromAccount;
            }

            Console.WriteLine($"{Thread.CurrentThread.Name} trying to acquire lock on {((Account)_lock1).ID}");
            lock (_lock1)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} acquired lock on {((Account)_lock1).ID}");
                Console.WriteLine($"{Thread.CurrentThread.Name} Doing Some work");
                Thread.Sleep(1000);
                Console.WriteLine($"{Thread.CurrentThread.Name} trying to acquire lock on {((Account)_lock2).ID}");
                // here we are using monitor.tryenter
                lock (_lock2)
                {
                    FromAccount.Withdraw(TransferAmount);
                    ToAccount.Deposite(TransferAmount);
                }

            }
        }
    }
}
