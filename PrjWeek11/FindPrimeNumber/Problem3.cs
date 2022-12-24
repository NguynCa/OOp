using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FuntionsInheritance;

namespace FindPrimeNumber
{
    class Problem3 : ICalculate
    {
        public Matrix multithreadCode(Matrix isPrime, Matrix array)
        {
            int n = array.N;
            #region Prepare data for multithreading
            Matrix forThreadA = new Matrix(2, n + 1);
            Matrix forThreadB = new Matrix(2, n + 1);
            OtherFunctions.numberDistribution(forThreadA, forThreadB, array);
            #endregion
            #region Multithread initialization
            Matrix lastReturn = new Matrix(1, n);
            Thread threadA = new Thread(
                delegate ()
                {
                    OtherFunctions.functionThreadA(forThreadA, isPrime, lastReturn);
                }
                );
            Thread threadB = new Thread(
                delegate ()
                {
                    OtherFunctions.functionThreadB(forThreadB, isPrime, lastReturn);
                }
                );
            #endregion
            threadA.Start();
            threadB.Start();
            return lastReturn;
        }
        public Matrix singlethreadCode(Matrix isPrime, Matrix array)
        {
            int n = array.N;
            Matrix lastReturn = new Matrix(1, n);
            for (int i = 0; i < n; i++)
            {
                lastReturn.A[0, i] = FindNearestPrimeNumber.findNearest(isPrime, (int)array.A[0, i]);
            }
            return lastReturn;
        }
    }
}
