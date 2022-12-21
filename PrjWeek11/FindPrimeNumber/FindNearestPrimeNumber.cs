using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPrimeNumber
{
    class FindNearestPrimeNumber
    {
        public static int FindNearest(bool[] isPrime, int n)
        {
            int dist = Math.Abs(n - 2);
            int temp = 0;
            for (int i = 3; i < isPrime.GetLength(0); i++)
            {
                if (isPrime[i] == false) continue;
                temp = Math.Abs(n - i);
                if (dist > temp)
                {
                    dist = temp;
                    temp = i;
                }
            }
            return temp;
        }
    }
}
