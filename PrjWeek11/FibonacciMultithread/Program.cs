using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FibonacciMultithread
{
    class Program
    {
        static int[] a = new int[30];
        static int Fibonacci (int n)
        {
            double x = 1.0 / Math.Sqrt(5.0);
            double y = (1.0 + Math.Sqrt(5.0)) / 2.0;
            double z = (1.0 - Math.Sqrt(5.0)) / 2.0;
            return (int)Math.Round(x * (Math.Pow(y, n) - Math.Pow(z, n)));
        }
        static void PrintFibo (int n)
        {
            //Console.WriteLine($"task:{Task.CurrentId,3}  " + $"thread: {Thread.CurrentThread.ManagedThreadId}");
            a[n] = Fibonacci(n);
            //Console.WriteLine($"{fiboNumber,10}");
            //Thread.Sleep(1000);
        }
        public static void ParallelFor()
        {
            ParallelLoopResult result = Parallel.For(0, 29, PrintFibo);
            Console.WriteLine($"All task start and finish: {result.IsCompleted}");
            //Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            ParallelFor();
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}
