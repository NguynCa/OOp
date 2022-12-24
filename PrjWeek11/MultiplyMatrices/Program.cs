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
            int colCount = 180;
            int rowCount = 5000;
            int colCount2 = 20;
            double[,] m1 = Calculation.InitializeMatrix(rowCount, colCount);
            double[,] m2 = Calculation.InitializeMatrix(colCount, colCount2);
            double[,] result = new double[rowCount, colCount2];

            #region Compare
            //Singlethread
            Console.WriteLine("Start Singlethread Code");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Calculation.MultiplyMatricesSequential(m1, m2, result);
            stopwatch.Stop();
            Console.WriteLine("Stop Singlethread Code");
            Console.WriteLine("Sequential loop time in milliseconds: {0}",
                                    stopwatch.ElapsedMilliseconds);

            // For the skeptics.
            Calculation.OfferToPrint(rowCount, colCount2, result);

            // Reset timer and results matrix.
            stopwatch.Reset();
            result = new double[rowCount, colCount2];

            //Multithread
            Console.WriteLine("Executing parallel loop...");
            stopwatch.Start();
            Calculation.MultiplyMatricesParallel(m1, m2, result);
            stopwatch.Stop();
            Console.WriteLine("Stop Multythread Code");
            Console.WriteLine("Parallel loop time in milliseconds: {0}",
                                    stopwatch.ElapsedMilliseconds);
            Calculation.OfferToPrint(rowCount, colCount2, result);
            #endregion

            //Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
