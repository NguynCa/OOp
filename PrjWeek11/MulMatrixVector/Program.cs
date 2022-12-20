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
            Calculation.ProcessInitialization(ref Calculation.size);
            int Size = Calculation.size;
            double[] pMatrix = new double[Size * Size];
            double[] pVector = new double[Size];
            double[] pResult = new double[Size];
            Calculation.RandomDataInitialization(ref pMatrix, ref pVector, Size);
            //multithread
            Console.WriteLine("Start Multithread Code");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Calculation.ParallelResultCalculation(pMatrix, pVector, pResult);
            stopwatch.Stop();
            Console.WriteLine("End Multithread Code!!!");
            Console.Error.WriteLine("Sequential loop time in milliseconds: {0}",
                                    stopwatch.ElapsedMilliseconds);

            stopwatch.Reset();

            //singlethread
            Console.WriteLine("Start Singlethread Code");
            stopwatch.Start();
            Calculation.SerialResultCalculation(pMatrix, pVector, ref pResult, Calculation.size);
            stopwatch.Stop();
            Console.WriteLine("End Singlethread Code!!!");
            Console.Error.WriteLine("Parallel loop time in milliseconds: {0}",
                                    stopwatch.ElapsedMilliseconds);
            Console.ReadKey();
        }
    }
}
