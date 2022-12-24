using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuntionsInheritance;

namespace FindPrimeNumber
{
    class CheckPrimeNumber
    {
        public static void sieveOfEratosthenes(int n, ref Matrix isPrime)
        {
            for (int i = 0; i <= n; i++)
                isPrime.A[0, i] = 1;
            isPrime.A[0, 0] = 0;
            isPrime.A[0, 1] = 0;
            for (int i = 2; i * i <= n; i++)
            {
                if (isPrime.A[0, i] == 1)
                {
                    //Mark all the multiples of i as composite numbers
                    for (int j = i * i; j <= n; j += i)
                        isPrime.A[0, j] = 0;
                }
            }
        }
        public static bool check(int n, Matrix isPrime)
        {
            if (isPrime.A[0, n] == 1) return true;
            return false;
        }
    }
}
