using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncProgramming
{
    class Program
    {
        public static void Main(string[] args)
        {
            CallWithAsync();
            Console.WriteLine("Hello world");
            Thread.Sleep(15000);
        }

        private async static void CallWithAsync()
        {
            Message cooking = new Message();
            //some other tasks
            string result = await cooking.GreetingAsync("Sam");
            Console.WriteLine(result);


            string result1 = cooking.Greeting("Mike");
            Console.WriteLine(result1);


            string result2 = await cooking.GreetingAsync("John");
            Console.WriteLine(result2);
        }



    }
}
