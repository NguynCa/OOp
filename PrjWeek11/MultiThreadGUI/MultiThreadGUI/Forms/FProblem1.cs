using System;
using FibonacciProblem;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using SupportFuntion;

namespace MultiThreadGUI
{
    public partial class FProblem1 : Form
    {
        public FProblem1()
        {
            InitializeComponent();
        }       
        private void btStart_Click(object sender, EventArgs e)
        {
            
            //Kiểm tra xem số n nhập vào đã đúng chưa?
            if (CheckNumInput.CheckInt(tbEnterN.Text) == false)
            {
                laNoti.Text = "Vui lòng nhập lại!";
                tbEnterN.Text = "";
            }
            else if (Convert.ToInt32(tbEnterN.Text) < 1)
            {
                laNoti.Text = "Vui lòng nhập lại!";
                tbEnterN.Text = "";
            }
            else
            {
                int n = Convert.ToInt32(tbEnterN.Text);
                FibonacciProblem.Fibonacci Fi1 = new FibonacciProblem.Fibonacci(n);
                FibonacciProblem.Fibonacci Fi2 = new FibonacciProblem.Fibonacci(n);
                
                //SingleThread
                Stopwatch stopwatch1 = new Stopwatch();
                stopwatch1.Start();
                Fi1.FindFiBySingleThread();
                stopwatch1.Stop();
                lbtimeofsingthread.Text = stopwatch1.ElapsedMilliseconds.ToString() + "ms";
                
                //Multithread
                Stopwatch stopwatch2 = new Stopwatch();
                stopwatch2.Start();         
                Fi1.findFiByMulThread();
                stopwatch2.Stop();
                lbtimeofmulthread.Text = stopwatch2.ElapsedMilliseconds.ToString() + "ms";
                lbsofibonaccin.Text = Fi1.ToString();       
                laNoti.Text = "Đã xong!";
            } 
  
        }

    }
}
