using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPrimeNumber
{
    class CheckPrimeNumber
    {
        public static void SieveOfEratosthenes (int n, ref bool[] isPrime)
        {
            for (int i = 0; i <= n; i++)
                isPrime[i] = true;
            isPrime[0] = false;
            isPrime[1] = false;
            for (int i = 2; i * i <= n; i++)
            {
                if (isPrime[i] == true)
                {
                    //Mark all the multiples of i as composite numbers
                    for (int j = i * i; j <= n; j += i)
                        isPrime[j] = false;
                }
            }
        }
        public static bool Check (int n, bool[] isPrime)
        {
            if (isPrime[n] == true) return true;
            return false;
        }
    }
}
