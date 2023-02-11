using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiThreadGUI
{
    public partial class FControl : Form
    {
        public FControl()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

   
        private void lbChooseProblem_Click(object sender, EventArgs e)
        {

        }

        private void btProblem1_Click(object sender, EventArgs e)
        {
            FProblem1 f = new FProblem1();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }  
        }

        private void btProblem2_Click(object sender, EventArgs e)
        {
            FProblem2 f = new FProblem2();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btProblem3_Click(object sender, EventArgs e)
        {
            FProblem3 f = new FProblem3();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
