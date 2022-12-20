using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of Fibonacci digits: ");
            int n = Convert.ToInt32(Console.ReadLine());

            //multithread
            DateTime startTime = DateTime.Now;
            Console.WriteLine("Start Multithread Code: ");
            FibonacciMultithread.ParallelFor(n);
            for (int i = 0; i < n; i++)
            {
                Console.Write(FibonacciMultithread.a[i] + " ");
            }
            Console.WriteLine("\nEnd Multithread Code!!!");
            DateTime endTime = DateTime.Now;
            TimeSpan Duration1 = endTime - startTime;

            //sequence
            startTime = DateTime.Now;
            Console.WriteLine("Start Singlethread Code: ");
            //FibonacciSequence.PrintFibo(n);
            for (int i = 0; i < n; i++)
                FibonacciMultithread.PrintFibo(n);
            Console.WriteLine("\nEnd Singlethread Code!!!");
            endTime = DateTime.Now;
            TimeSpan Duration2 = endTime - startTime;

            Console.WriteLine($"\nTime of Multithread Code: {Duration1.TotalMilliseconds,10}"
                + $"\nTime of Sequence Code:    {Duration2.TotalMilliseconds,10}");
   
            Console.ReadKey();
        }
    }
}
