using PrimeProblem;
using SupportFuntion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MatrixProblem;
using FuntionsInheritance;
namespace MultiThreadGUI
{
    public partial class FProblem3 : Form
    {
        public FProblem3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckNumInput.CheckInt(textEnterN.Text) == false)
            {

            }
            else
            {
                int n = Convert.ToInt32(textEnterN.Text);
                Matrix array = new Matrix(1, n);
                for (int i = 0; i < n; i++)
                {
                    DateTime now = new DateTime();
                    now = DateTime.Now;
                    array.A[0, i] = now.Millisecond;
                    //Thread.Sleep(4);
                }
                int maxArray = OtherFunctions.findMax(array);
                Matrix isPrime = new Matrix(1, maxArray + 1);
                CheckPrimeNumber.sieveOfEratosthenes(maxArray, ref isPrime);
                Matrix lastReturn = new Matrix(1, n);
                Problem3 objProblem3 = new Problem3();
                #region Compare
                //Multithread
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                lastReturn = objProblem3.multithreadCode(isPrime, array);
                //OtherFunctions.PrintForMultiThread(array, lastReturn, isPrime, n);
                stopwatch.Stop();
                latimeofmulthread.Text = stopwatch.ElapsedMilliseconds.ToString() + "ms";
                stopwatch.Reset();
                //Singlethread
                stopwatch.Start();
                lastReturn = objProblem3.singlethreadCode(isPrime, array);
                //OtherFunctions.PrintForSinglethread(array, lastReturn, n);
                stopwatch.Stop();
                latimeofsingthread.Text = stopwatch.ElapsedMilliseconds.ToString() + "ms";
                #endregion
            }
        }
    }
}
