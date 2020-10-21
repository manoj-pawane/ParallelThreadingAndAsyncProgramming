namespace ServerClass
{
    using System;
    using System.Threading;

    public class CreateThread
    {
        public void InstanceMethod()
        {
            Console.WriteLine(
                "Program.InstanceMethod is running on another thread.");

            // Pause for a moment to provide a delay to make
            // threads more apparent.
            Thread.Sleep(3000);
            Console.WriteLine(
                "The instance method called by the worker thread has ended.");
        }

        public static void StaticMethod()
        {
            Console.WriteLine(
                "Program.StaticMethod is running on another thread.");

            // Pause for a moment to provide a delay to make
            // threads more apparent.
            Thread.Sleep(5000);
            Console.WriteLine(
                "The static method called by the worker thread has ended.");
        }
    }
}
    