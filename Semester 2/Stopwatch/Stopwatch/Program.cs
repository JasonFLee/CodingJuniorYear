using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static void Main()
    {
        // Create new stopwatch.
        Stopwatch stopwatch = new Stopwatch();

        // Begin timing.
        stopwatch.Start();

        // Do something.

       
            Thread.Sleep(2000);
        


        // Stop timing.
        stopwatch.Stop();

        // Write result.
        Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);



        int stopwatchtime = (int)stopwatch.Elapsed.TotalSeconds;
        



        for (int y = 0; y < 10; y --)
        {

            if(stopwatchtime<y)
            {
                Console.WriteLine("you ran out of time");
                break;
            }
        }
        Console.ReadLine();

    }
}