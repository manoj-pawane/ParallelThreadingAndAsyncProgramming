using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fruits = new List<string>();
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Bilberry");
            fruits.Add("Blackberry");
            fruits.Add("Blackcurrant");
            fruits.Add("Blueberry");
            fruits.Add("Cherry");
            fruits.Add("Coconut");
            fruits.Add("Cranberry");


            Console.WriteLine("Printing list using foreach loop\n");

            foreach (string fruit in fruits)
            {
                Console.WriteLine("Fruit Name: {0}, Thread Id= {1}", fruit, Thread.CurrentThread.ManagedThreadId);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Printing list using Parallel.ForEach\n");

            Parallel.ForEach(fruits, fruit =>
            {
                Console.WriteLine("Fruit Name: {0}, Thread Id= {1}", fruit, Thread.CurrentThread.ManagedThreadId);

            }
            );
            Console.Read();
        }
    }
}
