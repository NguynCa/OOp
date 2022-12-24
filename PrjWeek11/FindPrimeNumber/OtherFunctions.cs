using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using FuntionsInheritance;

namespace FindPrimeNumber
{
    class OtherFunctions
    {
        public static int findMax(Matrix array)
        {
            int n = array.N;
            int maxArray = (int)array.A[0, 0];
            for (int i = 1; i < n; i++)
            {
                if (maxArray < array.A[0, i])
                    maxArray = (int)array.A[0, i];
            }
            return maxArray;
        }
        public static bool checkParity(int n)
        {
            if (n % 2 == 0) return true;
            return false;
        }
        public static void numberDistribution (Matrix forThreadA, Matrix forThreadB, Matrix array)
        {
        int A = 0;
        int B = 0;
            for (int i = 0; i < array.N; i++)
            {
                if (!checkParity((int)array.A[0, i]))
                {
                    forThreadA.A[0, A] = (int)array.A[0, i];
                    forThreadA.A[1, A] = i;
                    A++;
                }
                else
                {
                    forThreadB.A[0, B] = (int)array.A[0, i];
                    forThreadB.A[1, B] = i;
                    B++;
                }
            }
        }
        public static void functionThreadA (Matrix forThreadA, Matrix isPrime, Matrix lastReturn)
        {
            for (int i = 0; i < lastReturn.N; i++)
            {
                if (CheckPrimeNumber.check((int)forThreadA.A[0, i], isPrime))
                {
                    lastReturn.A[0, (int)forThreadA.A[1, i]] = (int)forThreadA.A[0, i];
                }
                else
                {
                    int temp = FindNearestPrimeNumber.findNearest(isPrime, (int)forThreadA.A[0, i]);
                    lastReturn.A[0, (int)forThreadA.A[1, i]] = temp;
                }
            }
        }
        public static void functionThreadB (Matrix forThreadB, Matrix isPrime, Matrix lastReturn)
        {
            for (int i = 0; i < lastReturn.N; i++)
            {
                int temp = FindNearestPrimeNumber.findNearest(isPrime, (int)forThreadB.A[0, i]);
                lastReturn.A[0, (int)forThreadB.A[1, i]] = temp;
            }
        }
        public static void printForMultiThread (Matrix array, Matrix lastReturn, Matrix isPrime, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(array.A[0, i] + " ");
            }
            Console.Write("\n");
            lastReturn.A[0, 0] = FindNearestPrimeNumber.findNearest(isPrime, (int)array.A[0, 0]);
            for (int i = 0; i < n; i++)
            {
                Console.Write(lastReturn.A[0, i] + " ");
            }
        }
        public static void printForSinglethread (Matrix array, Matrix lastReturn, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(array.A[0, i] + " ");
            }
            Console.Write("\n");
            for (int i = 0; i < n; i++)
            {
                Console.Write(lastReturn.A[0, i] + " ");
            }
        }
    }
}
