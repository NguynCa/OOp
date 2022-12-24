using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuntionsInheritance;

namespace FindPrimeNumber
{
    class FindNearestPrimeNumber
    {
        public static int findNearest(Matrix isPrime, int n)
        {
            int dist = Math.Abs(n - 2);
            int temp;
            int nearest = 0;
            for (int i = 3; i < isPrime.N; i++)
            {
                if (isPrime.A[0, i] == 0) continue;
                temp = Math.Abs(n - i);
                if (dist > temp)
                {
                    dist = temp;
                    nearest = i;
                }
                if (dist < temp) break;
            }
            return nearest;
        }
    }
}
