using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class FibonacciSequence
    {
        static int Fibonacci (int n)
        {
            if (n == 1) return 1;
            if (n == 2) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        public static void PrintFibo (int n)
        {
            for (int i = 1; i <= n; i++)
                Console.Write(Fibonacci(i) + " ");
        }
    }
}
