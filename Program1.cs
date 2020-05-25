using System;
using System.Threading;

namespace StopWatch
{

    class Program_1
    {
        static void Main(string[] args)
        {
            var stopwatch = new StopWatch();

            for (var i=0; i<2; i++) 
            {
                stopwatch.Start();

                //Thread.Sleep(1000); //ritardo di 1000 millisecondi all'applicazione

                stopwatch.Stop();

                Console.WriteLine("Duration: " + stopwatch.GetTimeSpan());
            Console.ReadLine();
            }
          



        }
    }
}

