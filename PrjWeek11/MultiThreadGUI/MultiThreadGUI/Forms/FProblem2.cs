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
using SupportFuntion;

namespace MultiThreadGUI
{
    public partial class FProblem2 : Form
    {
        public FProblem2()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool checkinput = false;
            if (SupportFuntion.CheckNumInput.CheckInt(textAm.Text) == true)
            {
                if (SupportFuntion.CheckNumInput.CheckInt(textAn.Text) == true)
                {
                    if (SupportFuntion.CheckNumInput.CheckInt(textBm.Text) == true)
                    {
                        if (SupportFuntion.CheckNumInput.CheckInt(textBn.Text) == true)
                        {
                            if (Convert.ToInt32(textAn.Text) == Convert.ToInt32(textBm.Text))
                            {
                                checkinput = true;
                            }
                        }
                    }
                }
            }
            if (checkinput == false)
            {
                laNoti.Text = "Nhập lại";
                textAm.Text = "";
                textAn.Text = "";
                textBm.Text = "";
                textBn.Text = "";

            }
            else
            {
                laNoti.Text = "Đang tính";
                int Am, An, Bn, Bm;
                Am = Convert.ToInt32(textAm.Text);
                An = Convert.ToInt32(textAn.Text);
                Bm = Convert.ToInt32(textBm.Text);
                Bn = Convert.ToInt32(textBn.Text);
                Matrix matA = new Matrix(Am, An);
                Matrix matB = new Matrix(Bm,Bn);
                Matrix result = new Matrix(matA.M, matB.N);
                matA.initializeObject(ref matA);
                matB.initializeObject(ref matB);

                #region Compare
                Problem2 objProblem2 = new Problem2();
                //Singlethread
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                result = objProblem2.singlethreadCode(matA, matB);
                stopwatch.Stop();
                latimeofsingthread.Text = stopwatch.ElapsedMilliseconds.ToString() + "ms";

                // Reset timer and results matrix.
                stopwatch.Reset();
                //Multithread
                stopwatch.Start();
                result = objProblem2.multithreadCode(matA, matB);
                stopwatch.Stop();
                latimeofmulthread.Text = stopwatch.ElapsedMilliseconds.ToString() + "ms";
                #endregion
                laNoti.Text = "Đã xong";
            }
        }
    }
}
