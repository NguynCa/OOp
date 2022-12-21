using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace FindPrimeNumber
{
    class OtherFunctions
    {
        public static int FindMax(int[] array)
        {
            int n = array.GetLength(0);
            int maxArray = array[0];
            for (int i = 1; i < n; i++)
            {
                if (maxArray < array[i])
                    maxArray = array[i];
            }
            return maxArray;
        }
        public static bool CheckParity(int n)
        {
            if (n % 2 == 0) return true;
            return false;
        }
        public static void NumberDistribution (int[,] forThreadA, int[,] forThreadB, int[] array, int n)
        {
        int A = 0;
        int B = 0;
            for (int i = 0; i < n; i++)
            {
                if (!CheckParity(array[i]))
                {
                    forThreadA[0, A] = array[i];
                    forThreadA[1, A] = i;
                    A++;
                }
                else
                {
                    forThreadB[0, B] = array[i];
                    forThreadB[1, B] = i;
                    B++;
                }
            }
        }
    }
}
