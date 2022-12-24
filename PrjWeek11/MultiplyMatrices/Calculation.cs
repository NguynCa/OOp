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
    class Problem2 : ICalculate
    {
        public Problem2() { }
        // Function for serial matrix-matrix multiplication
        #region SingleThread
        public Matrix singlethreadCode(Matrix matA, Matrix matB)
        {
            Matrix result = new Matrix(matA.M, matB.N);
            int matACols = matA.N;
            int matBCols = matB.N;
            int matARows = matA.M;

            for (int i = 0; i < matARows; i++)
            {
                for (int j = 0; j < matBCols; j++)
                {
                    double temp = 0;
                    for (int k = 0; k < matACols; k++)
                    {
                        temp += matA.A[i, k] * matB.A[k, j];
                    }
                    result.A[i, j] += temp;
                }
            }
            return result;
        }
        #endregion

        // Function for parallel matrix-matrix multiplication
        #region Multithread
        public Matrix multithreadCode(Matrix matA, Matrix matB)
        {
            Matrix result = new Matrix(matA.M, matB.N);
            int matACols = matA.N;
            int matBCols = matB.N;
            int matARows = matA.M;

            Parallel.For(0, matARows, i =>
            {
                for (int j = 0; j < matBCols; j++)
                {
                    double temp = 0;
                    for (int k = 0; k < matACols; k++)
                    {
                        temp += matA.A[i, k] * matB.A[k, j];
                    }
                    result.A[i, j] += temp;
                }
            }); // Parallel.For
            return result;
        }
        #endregion

    }
}
