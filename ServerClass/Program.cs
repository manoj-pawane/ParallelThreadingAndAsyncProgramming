using System;
using System.Threading;

namespace ServerClass
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateThread createThread = new CreateThread();

            // Create the thread object, passing in the
            // serverObject.InstanceMethod method using a
            // ThreadStart delegate.
            Thread InstanceCaller = new Thread(
                new ThreadStart(createThread.InstanceMethod));

            // Start the thread.
            InstanceCaller.Start();

            Console.WriteLine("The Main() thread calls this after "
                + "starting the new InstanceCaller thread.");

            // Create the thread object, passing in the
            // serverObject.StaticMethod method using a
            // ThreadStart delegate.
            Thread StaticCaller = new Thread(
                new ThreadStart(CreateThread.StaticMethod));

            // Start the thread.
            StaticCaller.Start();

            Console.WriteLine("The Main() thread calls this after "
                + "starting the new StaticCaller thread.");
        }

    }
}
