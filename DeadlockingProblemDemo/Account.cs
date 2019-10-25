using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadlockingProblemDemo
{
    class Account
    {
        public int ID { get; }
        public double Balance;

        public Account(int id,double balance)
        {
            ID = id;
            Balance = balance;
        }
        public void Withdraw(double amount) {
            Balance -= amount;
        }
        public void Deposite(double amount)
        {
            Balance += amount;
        }

    }
}
