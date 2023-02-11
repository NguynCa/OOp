using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FibonacciProblem
{
    class FibonacciNumber
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
        #region Constructor
        public FibonacciNumber(int n)
        {
            _n = n;
            for (int i = 0; i < _n; i++)
            {
                a[i] = 0;
            }
        }
        #endregion
        #region Methods
        static long getFibonacciN(int i)
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
                        a[i - 1] = getFibonacciN(i);
                    }
                });
            Thread threadB = new Thread(
                delegate ()
                {
                    for (int i = 2; i <= _n; i += 3)
                    {
                        a[i - 1] = getFibonacciN(i);
                    }
                });
            Thread threadC = new Thread(
                delegate ()
                {
                    for (int i = 3; i <= _n; i += 3)
                    {
                        a[i - 1] = getFibonacciN(i);
                    }
                });
            threadA.Start();
            threadB.Start();
            threadC.Start();
        }
        public void findFiBySingleThread()
        {
            for (int i = 1; i <= _n; i++)
            {
                this.a[i - 1] = getFibonacciN(i);
            }
        }
        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < _n; i++)
            {
                str += Convert.ToString(this.a[i]) + " ";
            }
            return str;
        }
        #endregion
    }

}