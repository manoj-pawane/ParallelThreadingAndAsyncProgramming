using System;
using System.Threading.Tasks;

namespace LockInThreading
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var account = new Account(1000);
            var tasks = new Task[100];
            for (int i = 0; i < tasks.Length; i++)
            {
                tasks[i] = Task.Run(() => Update(account));
            }
            await Task.WhenAll(tasks);
            Console.WriteLine($"Account's balance is {account.GetBalance()}");
        }

        static void Update(Account account)
        {
            decimal[] amounts = { 0, 2, -3, 6, -2, -1, 8, -5, 11, -6 };
            foreach (var amount in amounts)
            {
                if (amount >= 0)
                {
                    account.Credit(amount);
                }
                else
                {
                    account.Debit(Math.Abs(amount));
                }
            }
        }
    }
}
