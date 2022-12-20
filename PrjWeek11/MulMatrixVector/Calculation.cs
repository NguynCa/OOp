using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulMatrixVector
{
    class Calculation
    {
        //public static double[] pVector = new double[] { };
		//public static double[] pMatrix = new double[] { };
		//public static double[] pResult = new double[] { };
		public static int size;

		// Function for formatted vector output
		public static void PrintVector(double[] pVector, int Size)
		{
			for (int i = 0; i < Size; i++)
				Console.Write(pVector[i] + " ");
		}

		// Function for random definition of matrix and vector elements
		public static void RandomDataInitialization(ref double[] pMatrix, ref double[] pVector, int Size)
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
		public static void ProcessInitialization(ref int Size)
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

			//PrintVector(pVector, Size);
		}

		// Function for parallel matrix-vector multiplication
		public static void ParallelResultCalculation(double[] pMatrix, double[] pVector, double[] pResult)
        {
			Parallel.For(0, size, i =>
			{
				pResult[i] = 0;
				for (int j = 0; j < size; j++)
					pResult[i] += pMatrix[i * size + j] * pVector[j];
			}); // Parallel.For
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
