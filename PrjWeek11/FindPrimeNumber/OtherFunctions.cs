﻿using System;
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
        public static void FunctionThreadA (int[,] forThreadA, bool[] isPrime, int[] lastReturn, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (CheckPrimeNumber.Check(forThreadA[0, i], isPrime))
                {
                    lastReturn[forThreadA[1, i]] = forThreadA[0, i];
                }
                else
                {
                    int temp = FindNearestPrimeNumber.FindNearest(isPrime, forThreadA[0, i]);
                    lastReturn[forThreadA[1, i]] = temp;
                }
            }
        }
        public static void FunctionThreadB (int[,] forThreadB, bool[] isPrime, int[] lastReturn, int n)
        {
            for (int i = 0; i < n; i++)
            {
                int temp = FindNearestPrimeNumber.FindNearest(isPrime, forThreadB[0, i]);
                lastReturn[forThreadB[1, i]] = temp;
            }
        }
        public static void PrintForMultiThread (int[] array, int[] lastReturn, bool[] isPrime, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.Write("\n");
            lastReturn[0] = FindNearestPrimeNumber.FindNearest(isPrime, array[0]);
            for (int i = 0; i < n; i++)
            {
                Console.Write(lastReturn[i] + " ");
            }
        }
        public static void PrintForSinglethread (int[] array, int[] lastReturn, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.Write("\n");
            for (int i = 0; i < n; i++)
            {
                Console.Write(lastReturn[i] + " ");
            }
        }
    }
}
