using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace MulMatrixVector
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation.ProcessInitialization(ref Calculation.pVector, Calculation.size);

            //multithread
            //DateTime startTime = DateTime.Now;
            Console.WriteLine("Start Multithread Code");
            Console.Error.WriteLine("Executing sequential loop...");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Calculation.ParallelResultCalculation();
            //Calculation.PrintVector(Calculation.pResult, Calculation.size);
            Console.WriteLine("End Multithread Code!!!");
            stopwatch.Stop();
            Console.Error.WriteLine("Sequential loop time in milliseconds: {0}",
                                    stopwatch.ElapsedMilliseconds);
            //DateTime endTime = DateTime.Now;
            //TimeSpan Duration1 = endTime - startTime;

            stopwatch.Reset();

            Calculation.ProcessInitialization(ref Calculation.pVector, Calculation.size);
            //sequence
            //startTime = DateTime.Now;
            Console.WriteLine("Start Singlethread Code");
            stopwatch.Start();
            Calculation.SerialResultCalculation(Calculation.pMatrix, Calculation.pVector, ref Calculation.pResult, Calculation.size);
            //Calculation.PrintVector(Calculation.pResult, Calculation.size);
            Console.WriteLine("End Singlethread Code!!!");
            stopwatch.Stop();
            Console.Error.WriteLine("Parallel loop time in milliseconds: {0}",
                                    stopwatch.ElapsedMilliseconds);
            //endTime = DateTime.Now;
            //TimeSpan Duration2 = endTime - startTime;

            //Console.WriteLine($"\nTime of Multithread Code: {Duration1.TotalMilliseconds,10}"
            //    + $"\nTime of Sequence Code:    {Duration2.TotalMilliseconds,10}");
            Console.ReadKey();
        }
    }
}
