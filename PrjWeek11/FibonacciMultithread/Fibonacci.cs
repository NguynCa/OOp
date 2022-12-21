using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Fibonacci
{
    class FibonacciMultithread
    {
        public static int[] a = new int[100];
        static int Fibonacci(int n)
        {
            double x = 1.0 / Math.Sqrt(5.0);
            double y = (1.0 + Math.Sqrt(5.0)) / 2.0;
            double z = (1.0 - Math.Sqrt(5.0)) / 2.0;
            return (int)Math.Round(x * (Math.Pow(y, n) - Math.Pow(z, n)));
        }
        public static void LoadFibo(int n)
        {
            a[n - 1] = Fibonacci(n);
            //Console.WriteLine($"task:{Task.CurrentId,3}  " + $"thread: {Thread.CurrentThread.ManagedThreadId}"
            //    + $"\n{a[n],10}");
        }
        public static void ParallelFor(int n)
        {
            ParallelLoopResult result = Parallel.For(1, n + 1, LoadFibo);
            Console.WriteLine($"All task start and finish: {result.IsCompleted}");
        }
    }
}
