namespace Bot
{
    using System;
    using System.Diagnostics;

    using Nancy.Hosting.Self;

    class Program
    {
        static void Main(string[] args)
        {
            using (var nancyHost = new NancyHost(new Uri("http://localhost:8888/"), new Uri("http://127.0.0.1:8898/"), new Uri("http://localhost:8889/")))
            {
                nancyHost.Start();

                Console.WriteLine("Nancy now listening - navigating to http://localhost:8888/. Press enter to stop");
                
                try
                {
                    Process.Start("http://localhost:8888/");
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }

                Console.ReadKey();
            }

            Console.WriteLine("Stopped. Good bye!");
        }
    }
}
