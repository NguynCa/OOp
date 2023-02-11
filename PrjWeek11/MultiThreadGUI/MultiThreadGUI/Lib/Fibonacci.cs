using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FibonacciProblem
{
    class Fibonacci
    {
        #region Properties and Field
        private int _n;
        public int N
        {
            get => _n;
            set => _n = N;
        }
        public long[] a = new long[100];
        #endregion
        #region Methods
        public Fibonacci(int N) {
            _n = N;
            for(int i = 0; i < _n; i++)
            {
                a[i] = 0;
            }
        }
        static long GetFibonacciN(int i)
        {
            double x = 1.0 / Math.Sqrt(5.0);
            double y = (1.0 + Math.Sqrt(5.0)) / 2.0;
            double z = (1.0 - Math.Sqrt(5.0)) / 2.0;
            return (long)Math.Round(x * (Math.Pow(y, i) - Math.Pow(z, i)));
        }
        public void findFiByMulThread()
        {
            Thread threadA = new Thread(
                delegate ()
                {
                    for (int i = 1; i <= _n; i += 3)
                    {
                        a[i - 1] = GetFibonacciN(i);
                    }
                });
            Thread threadB = new Thread(
                delegate ()
                {
                    for (int i = 2; i <= _n; i += 3)
                    {
                        a[i - 1] = GetFibonacciN(i);
                    }
                });
            Thread threadC = new Thread(
                delegate ()
                {
                    for (int i = 3; i <= _n; i += 3)
                    {
                        a[i - 1] = GetFibonacciN(i);
                    }
                });
            threadA.Start();
            threadB.Start();
            threadC.Start();
        }
        public void FindFiBySingleThread ()
        {
            for (int i = 1; i <= _n; i++)
            {
                this.a[i - 1] = GetFibonacciN(i);
            }    
        }
        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < _n; i++)
            {
                str += Convert.ToString(a[i]) + " ";
            }
            return str;
        }
        #endregion
    }

}
 