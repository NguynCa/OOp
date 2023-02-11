namespace MultiThreadGUI
{
    partial class FProblem2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.latimeofmulthread = new System.Windows.Forms.Label();
            this.latimeofsingthread = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBn = new System.Windows.Forms.TextBox();
            this.textBm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textAn = new System.Windows.Forms.TextBox();
            this.textAm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lamatrixA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.laNoti = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.laNoti);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBn);
            this.panel1.Controls.Add(this.textBm);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textAn);
            this.panel1.Controls.Add(this.textAm);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lamatrixA);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 441);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.latimeofmulthread);
            this.panel2.Controls.Add(this.latimeofsingthread);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(15, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 367);
            this.panel2.TabIndex = 11;
            // 
            // latimeofmulthread
            // 
            this.latimeofmulthread.AutoSize = true;
            this.latimeofmulthread.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latimeofmulthread.Location = new System.Drawing.Point(224, 94);
            this.latimeofmulthread.Name = "latimeofmulthread";
            this.latimeofmulthread.Size = new System.Drawing.Size(32, 21);
            this.latimeofmulthread.TabIndex = 15;
            this.latimeofmulthread.Text = "ms";
            // 
            // latimeofsingthread
            // 
            this.latimeofsingthread.AutoSize = true;
            this.latimeofsingthread.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latimeofsingthread.Location = new System.Drawing.Point(224, 32);
            this.latimeofsingthread.Name = "latimeofsingthread";
            this.latimeofsingthread.Size = new System.Drawing.Size(32, 21);
            this.latimeofsingthread.TabIndex = 14;
            this.latimeofsingthread.Text = "ms";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Thời gian chạy đa luồng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Thời gian chạy đơn luồng:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(656, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 32);
            this.button1.TabIndex = 10;
            this.button1.Text = "Bắt đầu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(554, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "x";
            // 
            // textBn
            // 
            this.textBn.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBn.Location = new System.Drawing.Point(579, 32);
            this.textBn.Name = "textBn";
            this.textBn.Size = new System.Drawing.Size(56, 20);
            this.textBn.TabIndex = 8;
            // 
            // textBm
            // 
            this.textBm.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBm.Location = new System.Drawing.Point(492, 32);
            this.textBm.Name = "textBm";
            this.textBm.Size = new System.Drawing.Size(56, 20);
            this.textBm.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(442, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "x";
            // 
            // textAn
            // 
            this.textAn.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAn.Location = new System.Drawing.Point(371, 31);
            this.textAn.Name = "textAn";
            this.textAn.Size = new System.Drawing.Size(56, 20);
            this.textAn.TabIndex = 5;
            // 
            // textAm
            // 
            this.textAm.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAm.Location = new System.Drawing.Point(284, 32);
            this.textAm.Name = "textAm";
            this.textAm.Size = new System.Drawing.Size(56, 20);
            this.textAm.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(346, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(468, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "B";
            // 
            // lamatrixA
            // 
            this.lamatrixA.AutoSize = true;
            this.lamatrixA.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lamatrixA.Location = new System.Drawing.Point(257, 10);
            this.lamatrixA.Name = "lamatrixA";
            this.lamatrixA.Size = new System.Drawing.Size(33, 31);
            this.lamatrixA.TabIndex = 1;
            this.lamatrixA.Text = "A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập kích thước của ma trận:";
            // 
            // laNoti
            // 
            this.laNoti.AutoSize = true;
            this.laNoti.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laNoti.Location = new System.Drawing.Point(702, 43);
            this.laNoti.Name = "laNoti";
            this.laNoti.Size = new System.Drawing.Size(16, 15);
            this.laNoti.TabIndex = 16;
            this.laNoti.Text = "...";
            // 
            // FProblem2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FProblem2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài toán 2: Nhân hai ma trận";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lamatrixA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBn;
        private System.Windows.Forms.TextBox textBm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textAn;
        private System.Windows.Forms.TextBox textAm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label latimeofmulthread;
        private System.Windows.Forms.Label latimeofsingthread;
        private System.Windows.Forms.Label laNoti;
    }
}