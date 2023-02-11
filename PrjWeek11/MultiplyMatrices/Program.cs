using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;
using FuntionsInheritance;

namespace MultiplyMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matA = new Matrix(100, 5000);
            Matrix matB = new Matrix(5000, 20);
            Matrix result = new Matrix(matA.M, matB.N);
            matA.initializeObject(ref matA);
            matB.initializeObject(ref matB);

            #region Compare
            Problem2 objProblem2 = new Problem2();
            //Singlethread
            Console.WriteLine("Start Singlethread Code");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            result = objProblem2.singlethreadCode(matA, matB);
            stopwatch.Stop();
            Console.WriteLine("Stop Singlethread Code");
            Console.WriteLine("Sequential loop time in milliseconds: {0}",
                                    stopwatch.ElapsedMilliseconds);

            // Reset timer and results matrix.
            stopwatch.Reset();
            //Multithread
            Console.WriteLine("Executing parallel loop...");
            stopwatch.Start();
            result = objProblem2.multithreadCode(matA, matB);
            stopwatch.Stop();
            Console.WriteLine("Stop Multythread Code");
            Console.WriteLine("Parallel loop time in milliseconds: {0}",
                                    stopwatch.ElapsedMilliseconds);
            //Calculation.OfferToPrint(rowCount, colCount2, result);
            #endregion

            //Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
