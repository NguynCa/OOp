using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuntionsInheritance;
using SupportFuntion;

namespace MatrixProblem
{
    public class Matrix : IPrepare
    {
        #region Properties and Field
        private int _m;
        private int _n;
        public int M
        {
            get => _m;
            set => _m = M;
        }
        public int N
        {
            get => _n;
            set => _n = N;
        }
        public double[,] _a = new double[,] { };
        public double[,] A
        {
            get => _a;
            set => _a = A;
        }
        #endregion
        #region Constructor
        public Matrix(int m, int n)
        {
            this._m = m;
            this._n = n;
            this._a = new double[M, N];
        }
        #endregion
        // Function for random definition of matrix and vector elements
        #region Method
        public void initializeObject(ref Matrix matrix)
        {
            Random r = new Random();
            for (int i = 0; i < matrix.M; i++)
            {
                for (int j = 0; j < matrix.N; j++)
                {
                    matrix.A[i, j] = r.Next(100);
                }
            }
        }
        public override string ToString()
        {
            String str = "";
            for(int i = 0; i < M; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    str += Convert.ToString(A[i, j]) +" ";
                }
                str = str + "\n";
            }
            return str;
        }
        #endregion
    }   
    public class Problem2 : ICalculate
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
                        temp = matA.A[i, k] * matB.A[k, j];
                    }
                    result.A[i, j] += temp;
                }
            }); // Parallel.For
            return result;
        }
        #endregion

    }
}
