using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FuntionsInheritance;
using SupportFuntion;
using MatrixProblem;
namespace PrimeProblem
{
    
    public class FindNearestPrimeNumber
    {
        public static int findNearest(MatrixProblem.Matrix isPrime, int n)
        {
            int dist = Math.Abs(n - 2);
            int temp;
            int nearest = 0;
            for (int i = 3; i < isPrime.N; i++)
            {
                if (isPrime.A[0, i] == 0) continue;
                temp = Math.Abs(n - i);
                if (dist > temp)
                {
                    dist = temp;
                    nearest = i;
                }
                if (dist < temp) break;
            }
            return nearest;
        }
    }
    public class CheckPrimeNumber
    {
        public static void sieveOfEratosthenes(int n, ref MatrixProblem.Matrix isPrime)
        {
            for (int i = 0; i <= n; i++)
                isPrime.A[0, i] = 1;
            isPrime.A[0, 0] = 0;
            isPrime.A[0, 1] = 0;
            for (int i = 2; i * i <= n; i++)
            {
                if (isPrime.A[0, i] == 1)
                {
                    //Mark all the multiples of i as composite numbers
                    for (int j = i * i; j <= n; j += i)
                        isPrime.A[0, j] = 0;
                }
            }
        }
        public static bool check(int n, MatrixProblem.Matrix isPrime)
        {
            if (isPrime.A[0, n] == 1) return true;
            return false;
        }
    }
    public class Problem3 : ICalculate
    {
        public MatrixProblem.Matrix multithreadCode(MatrixProblem.Matrix isPrime, MatrixProblem.Matrix array)
        {
            int n = array.N;
            #region Prepare data for multithreading
            MatrixProblem.Matrix forThreadA = new MatrixProblem.Matrix(2, n + 1);
            MatrixProblem.Matrix forThreadB = new MatrixProblem.Matrix(2, n + 1);
            OtherFunctions.numberDistribution(forThreadA, forThreadB, array);
            #endregion
            #region Multithread initialization
            MatrixProblem.Matrix lastReturn = new MatrixProblem.Matrix(1, n);
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
        public MatrixProblem.Matrix singlethreadCode(MatrixProblem.Matrix isPrime, MatrixProblem.Matrix array)
        {
            int n = array.N;
            MatrixProblem.Matrix lastReturn = new MatrixProblem.Matrix(1, n);
            for (int i = 0; i < n; i++)
            {
                lastReturn.A[0, i] = FindNearestPrimeNumber.findNearest(isPrime, (int)array.A[0, i]);
            }
            return lastReturn;
        }
    }

}
