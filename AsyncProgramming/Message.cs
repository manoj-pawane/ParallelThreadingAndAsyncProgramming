using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncProgramming
{
    public class Message
    {
        
        public string Greeting(string name)
        {
            Thread.Sleep(3000);

            return string.Format("Hello, {0}", name);

        }

        public Task<string> GreetingAsync(string name)
        {
            Message cooking1 = new Message();
            return Task.Run<string>(() =>
            {
                return cooking1.Greeting(name);
            });
        }
    }

    
}
