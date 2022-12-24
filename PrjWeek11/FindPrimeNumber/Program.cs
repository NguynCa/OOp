using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using FuntionsInheritance;

namespace FindPrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            Matrix array = new Matrix(1, n);
            for (int i = 0; i < n; i++)
            {
                DateTime now = new DateTime();
                now = DateTime.Now;
                array.A[0, i] = now.Millisecond;
                //Thread.Sleep(4);
            }
            int maxArray = OtherFunctions.findMax(array);
            Matrix isPrime = new Matrix(1, maxArray + 1);
            CheckPrimeNumber.sieveOfEratosthenes(maxArray, ref isPrime);
            Matrix lastReturn = new Matrix(1, n);

            Problem3 objProblem3 = new Problem3();
            #region Compare
            //Multithread
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Start Multithread Code: ");
            stopwatch.Start();
            lastReturn = objProblem3.multithreadCode(isPrime, array);
            //OtherFunctions.PrintForMultiThread(array, lastReturn, isPrime, n);
            
            Console.WriteLine("\nEnd Multithread Code!!!");
            stopwatch.Stop();
            Console.WriteLine("Multithread time in milliseconds: {0}",
                                    stopwatch.ElapsedMilliseconds);
            stopwatch.Reset();

            //Singlethread
            Console.WriteLine("Start Singlethread Code: ");
            stopwatch.Start();
            lastReturn = objProblem3.singlethreadCode(isPrime, array);
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
