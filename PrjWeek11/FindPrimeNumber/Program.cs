using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FindPrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Random random = new Random();
                array[i] = random.Next(1000);
            }
            int maxArray = OtherFunctions.FindMax(array);
            bool[] isPrime = new bool[maxArray + 1];
            CheckPrimeNumber.SieveOfEratosthenes(maxArray, ref isPrime);

            #region Prepare data for multithreading
            int[,] forThreadA = new int[2, n + 1];
            int[,] forThreadB = new int[2, n + 1];
            OtherFunctions.NumberDistribution(forThreadA, forThreadB, array, n);
            #endregion

            #region Multithread initialization
            int[] lastReturn = new int[n];            
            Thread threadA = new Thread(
                delegate () 
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (CheckPrimeNumber.Check(forThreadA[0,i], isPrime))
                        {
                            lastReturn[forThreadA[1, i]] = forThreadA[0, i];
                        }
                        else
                        {
                            Thread threadC = new Thread(
                                delegate ()
                                {
                                    int temp = FindNearestPrimeNumber.FindNearest(isPrime, forThreadA[0, i]);
                                    lastReturn[forThreadA[1, i]] = temp;
                                }
                                );
                            threadC.Start();
                        }
                    }
                }
                );
            Thread threadB = new Thread(
                delegate () 
                {
                    for (int i = 0; i < n; i++)
                    {
                        int temp = FindNearestPrimeNumber.FindNearest(isPrime, forThreadB[0, i]);
                        lastReturn[forThreadB[1, i]] = temp;
                    }
                }
                );
            #endregion

            #region Multithread 
            threadA.Start();
            threadB.Start();
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.Write("\n");
            for (int i = 0; i < n; i++)
            {
                Console.Write(lastReturn[i] + " ");
            }    
            #endregion

            Console.ReadKey();
        }
    }
}
