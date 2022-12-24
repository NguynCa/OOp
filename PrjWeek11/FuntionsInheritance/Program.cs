using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuntionsInheritance
{
    #region interface
    public interface ICalculate
    {
        Matrix multithreadCode(Matrix matrix1, Matrix matrix2);
        Matrix singlethreadCode(Matrix matrix1, Matrix matrix2); 
    }
    public interface IPrepare
    {
        void initializeObject(ref Matrix A);
    }
    #endregion
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
        private double[,] _a = new double[,] { };
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
        #endregion
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
