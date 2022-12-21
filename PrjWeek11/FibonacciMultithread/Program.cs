using System;
using System.Diagnostics;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of Fibonacci digits: ");
            int n = Convert.ToInt32(Console.ReadLine());

            #region Compare
            //multithread
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Start Multithread Code: ");
            stopwatch.Start();
            FibonacciMultithread.ParallelFor(n);
            for (int i = 0; i < n; i++)
            {
                Console.Write(FibonacciMultithread.a[i] + " ");
            }
            Console.WriteLine("\nEnd Multithread Code!!!");
            stopwatch.Stop();
            Console.WriteLine("Multithread Code run time: " + stopwatch.ElapsedMilliseconds);

            stopwatch.Reset();
            //sequence
            stopwatch.Start();
            Console.WriteLine("Start Singlethread Code: ");
            for (int i = 1; i < n; i++)
                FibonacciMultithread.LoadFibo(i);
            for (int i = 0; i < n; i++)
            {
                Console.Write(FibonacciMultithread.a[i] + " ");
            }
            Console.WriteLine("\nEnd Singlethread Code!!!");
            stopwatch.Stop();
            Console.WriteLine("Singlethread Code run time: " + stopwatch.ElapsedMilliseconds);
            #endregion

            //Keep the window console open in debug mode
            Console.WriteLine("Press any key to exit!!!");   
            Console.ReadKey();
        }
    }
}
