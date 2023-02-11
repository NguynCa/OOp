using System;
using System.Diagnostics;

namespace FibonacciProblem
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Enter the number of Fibonacci digits: ");
            int n = Convert.ToInt32(Console.ReadLine());
            FibonacciNumber fibo1 = new FibonacciNumber(n);
            #region Compare
            //multithread
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Start Multithread Code: ");
            stopwatch.Start();
            fibo1.findFiByMulThread();
            Console.WriteLine(fibo1.ToString());
            Console.WriteLine("\nEnd Multithread Code!!!");
            stopwatch.Stop();
            Console.WriteLine("Multithread Code run time: " + stopwatch.ElapsedMilliseconds);

            stopwatch.Reset();
            //sequence
            stopwatch.Start();
            Console.WriteLine("Start Singlethread Code: ");
            fibo1.findFiBySingleThread();
            Console.WriteLine(fibo1.ToString());
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
