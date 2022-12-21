using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace FindPrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10000000;
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                DateTime now = new DateTime();
                now = DateTime.Now;
                array[i] = now.Millisecond;
                //Thread.Sleep(4);
            }
            int maxArray = OtherFunctions.FindMax(array);
            bool[] isPrime = new bool[maxArray + 1];
            CheckPrimeNumber.SieveOfEratosthenes(maxArray, ref isPrime);

    //Multithread Code Start
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Start Multithread Code: ");
            stopwatch.Start();

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
                    OtherFunctions.FunctionThreadA(forThreadA, isPrime, lastReturn, n);
                }
                );
            Thread threadB = new Thread(
                delegate () 
                {
                    OtherFunctions.FunctionThreadB(forThreadB, isPrime, lastReturn, n);
                }
                );
            #endregion

            #region Compare
        //multithread
            threadA.Start();
            threadB.Start();
            //OtherFunctions.PrintForMultiThread(array, lastReturn, isPrime, n);
            Console.WriteLine("\nEnd Multithread Code!!!");
            stopwatch.Stop();
            Console.WriteLine("Multithread time in milliseconds: {0}",
                                    stopwatch.ElapsedMilliseconds);
            stopwatch.Reset();
        //sequence
            Console.WriteLine("Start Singlethread Code: ");
            stopwatch.Start();
            for (int i = 0; i < n; i++)
            {
            lastReturn[i] = FindNearestPrimeNumber.FindNearest(isPrime, array[i]);
            }
            //OtherFunctions.PrintForSinglethread(array, lastReturn, n);
            Console.WriteLine("\nEnd Singlethread Code!!!");
            stopwatch.Stop();
            Console.WriteLine("Singlethread time in milliseconds: {0}",
                                    stopwatch.ElapsedMilliseconds);
            #endregion

            //Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
