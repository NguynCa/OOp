using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulMatrixVector
{
    class Calculation
    {
        public static double[] pVector = new double[] { };
		public static double[] pMatrix = new double[] { };
		public static double[] pResult = new double[] { };
		public static int size;

		// Function for formatted vector output
		public static void PrintVector(double[] pVector, int Size)
		{
			for (int i = 0; i < Size; i++)
				Console.Write(pVector[i] + " ");
		}

		// Function for random definition of matrix and vector elements
		static void RandomDataInitialization(ref double[] pMatrix, ref double[] pVector, int Size)
		{
			for (int i = 0; i < Size; i++)
			{
				Random a = new Random();
				pVector[i] = a.Next(1000);
				for (int j = 0; j < Size; j++)
                {
					Random b = new Random();
					pMatrix[i * Size + j] = b.Next(1000);
				}
			}
		}

		// Function for memory allocation and definition of object’s elements
		public static void ProcessInitialization(ref double[] pVector, int Size)
		{
			//size of initial vector definition
			do
			{
				Console.Write("Enter size of the initial objects: ");
				Size = Convert.ToInt32(Console.ReadLine());
				if (Size <= 0)
					Console.WriteLine("Size of objects must be greater than 0");
			}
			while (Size <= 0);
			//memory allocation
			pMatrix = new double[Size * Size];
			pVector = new double[Size];
			pResult = new double[Size];
			RandomDataInitialization(ref pMatrix, ref pVector, Size);
			//PrintVector(pVector, Size);
		}

		// Function for parallel matrix-vector multiplication
		static void Cal(double[] pMatrix, double[] pVector, ref double[] pResult, int i)
		{
				pResult[i] = 0;
				for (int j = 0; j < size; j++)
					pResult[i] += pMatrix[i * size + j] * pVector[j];
		}
		static void LoadResult(int i)
        {
			Cal(pMatrix, pVector, ref pResult, i);
		}
		public static void ParallelResultCalculation()
        {
			ParallelLoopResult result = Parallel.For(0, size, LoadResult);
			Console.WriteLine($"All task start and finish: {result.IsCompleted}");
		}

		// Function for serial matrix-vector multiplication
		public static void SerialResultCalculation(double[] pMatrix, double[] pVector, ref double[] pResult, int Size)
		{
			for (int i = 0; i < Size; i++)
			{
				pResult[i] = 0;
				for (int j = 0; j < Size; j++)
					pResult[i] += pMatrix[i * Size + j] * pVector[j];
			}
		}
	}
}
