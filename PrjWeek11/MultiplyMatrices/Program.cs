using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace MultiplyMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set up matrices. Use small values to better view
            // result matrix. Increase the counts to see greater
            // speedup in the parallel loop vs. the sequential loop.
            int colCount = 180;
            int rowCount = 5000;
            int colCount2 = 1;
            double[,] m1 = Calculation.InitializeMatrix(rowCount, colCount);
            double[,] m2 = Calculation.InitializeMatrix(colCount, colCount2);
            double[,] result = new double[rowCount, colCount2];

            // First do the sequential version.
            Console.Error.WriteLine("Executing sequential loop...");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Calculation.MultiplyMatricesSequential(m1, m2, result);
            stopwatch.Stop();
            Console.Error.WriteLine("Sequential loop time in milliseconds: {0}",
                                    stopwatch.ElapsedMilliseconds);

            // For the skeptics.
            Calculation.OfferToPrint(rowCount, colCount2, result);

            // Reset timer and results matrix.
            stopwatch.Reset();
            result = new double[rowCount, colCount2];

            // Do the parallel loop.
            Console.Error.WriteLine("Executing parallel loop...");
            stopwatch.Start();
            Calculation.MultiplyMatricesParallel(m1, m2, result);
            stopwatch.Stop();
            Console.Error.WriteLine("Parallel loop time in milliseconds: {0}",
                                    stopwatch.ElapsedMilliseconds);
            Calculation.OfferToPrint(rowCount, colCount2, result);

            // Keep the console window open in debug mode.
            Console.Error.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
