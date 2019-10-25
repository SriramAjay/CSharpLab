﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MutexDemo
{
    class Program
    {
        private static Mutex mutex = new Mutex();
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                Thread threadObject = new Thread(MutexDemo);
                threadObject.Name = "Thread " + i;
                threadObject.Start();
            }
            Console.ReadKey();
        }
        //Method to implement syncronization using Mutex  
        static void MutexDemo()
        {
            Console.WriteLine(Thread.CurrentThread.Name + " Wants to Enter Critical Section for processing");
            try
            {
                //Blocks the current thread until the current WaitOne method receives a signal.  
                //Wait until it is safe to enter. 
                mutex.WaitOne();
                Console.WriteLine("Success: " + Thread.CurrentThread.Name + " is Processing now");
                Thread.Sleep(2000);
                Console.WriteLine("Exit: " + Thread.CurrentThread.Name + " is Completed its task");
            }
            finally
            {
                //Call the ReleaseMutex method to unblock so that other threads
                //that are trying to gain ownership of the mutex.  
                mutex.ReleaseMutex();
            }
        }

    }
}
