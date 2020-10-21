using System;
using System.Threading;

namespace DeadLockForThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            new Thread(new ThreadStart(Threads)).Start();
            Thread.Sleep(500);
            Console.WriteLine("Locking Lock2");
            lock (lock2)
            {
                Console.WriteLine("Locked Lock2");
                Console.WriteLine("Locking Lock1");
                lock (lock1)
                {
                    Console.WriteLine("Locked Lock1");
                }
                Console.WriteLine("Released Lock1");
            }
            Console.WriteLine("Released Lock2");
            Console.Read();
        }

        static readonly object lock1 = new object();
        static readonly object lock2 = new object();

        static void Threads()
        {
            Console.WriteLine("\t\t\t\tLocking Lock1");
            lock (lock1)
            {
                Console.WriteLine("\t\t\t\tLocked Lock1");
                Thread.Sleep(1000);
                Console.WriteLine("\t\t\t\tLocking Lock2");
                lock (lock2)
                {
                    Console.WriteLine("\t\t\t\tLocked Lock2");
                }
                Console.WriteLine("\t\t\t\tReleased Lock2");
            }
            Console.WriteLine("\t\t\t\tReleased Lock1");
        }
    }
}
