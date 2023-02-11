namespace MultiThreadGUI
{
    partial class FProblem1
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
            this.lbEnterN = new System.Windows.Forms.Label();
            this.tbEnterN = new System.Windows.Forms.TextBox();
            this.btStart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.laNotification = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbtimeofmulthread = new System.Windows.Forms.Label();
            this.lbtimeofsingthread = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbsofibonaccin = new System.Windows.Forms.Label();
            this.lbFibonaccin = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.laNoti = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbEnterN
            // 
            this.lbEnterN.AutoSize = true;
            this.lbEnterN.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEnterN.Location = new System.Drawing.Point(25, 40);
            this.lbEnterN.Name = "lbEnterN";
            this.lbEnterN.Size = new System.Drawing.Size(74, 22);
            this.lbEnterN.TabIndex = 0;
            this.lbEnterN.Text = "Nhập n:";
            // 
            // tbEnterN
            // 
            this.tbEnterN.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEnterN.Location = new System.Drawing.Point(109, 37);
            this.tbEnterN.Multiline = true;
            this.tbEnterN.Name = "tbEnterN";
            this.tbEnterN.Size = new System.Drawing.Size(104, 25);
            this.tbEnterN.TabIndex = 1;
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(235, 39);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(83, 25);
            this.btStart.TabIndex = 2;
            this.btStart.Text = "Bắt đầu";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.laNoti);
            this.panel1.Controls.Add(this.laNotification);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btStart);
            this.panel1.Controls.Add(this.tbEnterN);
            this.panel1.Controls.Add(this.lbEnterN);
            this.panel1.Location = new System.Drawing.Point(6, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 421);
            this.panel1.TabIndex = 3;
            // 
            // laNotification
            // 
            this.laNotification.AutoSize = true;
            this.laNotification.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.laNotification.Location = new System.Drawing.Point(366, 21);
            this.laNotification.Name = "laNotification";
            this.laNotification.Size = new System.Drawing.Size(0, 19);
            this.laNotification.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbtimeofmulthread);
            this.panel2.Controls.Add(this.lbtimeofsingthread);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbsofibonaccin);
            this.panel2.Controls.Add(this.lbFibonaccin);
            this.panel2.Location = new System.Drawing.Point(15, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(790, 354);
            this.panel2.TabIndex = 5;
            // 
            // lbtimeofmulthread
            // 
            this.lbtimeofmulthread.Location = new System.Drawing.Point(216, 269);
            this.lbtimeofmulthread.Name = "lbtimeofmulthread";
            this.lbtimeofmulthread.Size = new System.Drawing.Size(263, 19);
            this.lbtimeofmulthread.TabIndex = 8;
            this.lbtimeofmulthread.Text = "ms";
            // 
            // lbtimeofsingthread
            // 
            this.lbtimeofsingthread.Location = new System.Drawing.Point(216, 214);
            this.lbtimeofsingthread.Name = "lbtimeofsingthread";
            this.lbtimeofsingthread.Size = new System.Drawing.Size(263, 19);
            this.lbtimeofsingthread.TabIndex = 7;
            this.lbtimeofsingthread.Text = "ms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Thời gian chạy đa luồng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Thời gian chạy đơn luồng:";
            // 
            // lbsofibonaccin
            // 
            this.lbsofibonaccin.Location = new System.Drawing.Point(9, 49);
            this.lbsofibonaccin.Name = "lbsofibonaccin";
            this.lbsofibonaccin.Size = new System.Drawing.Size(770, 165);
            this.lbsofibonaccin.TabIndex = 4;
            // 
            // lbFibonaccin
            // 
            this.lbFibonaccin.AutoSize = true;
            this.lbFibonaccin.Location = new System.Drawing.Point(9, 11);
            this.lbFibonaccin.Name = "lbFibonaccin";
            this.lbFibonaccin.Size = new System.Drawing.Size(75, 19);
            this.lbFibonaccin.TabIndex = 3;
            this.lbFibonaccin.Text = "Kết quả: ";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // laNoti
            // 
            this.laNoti.AutoSize = true;
            this.laNoti.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laNoti.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.laNoti.Location = new System.Drawing.Point(25, 9);
            this.laNoti.Name = "laNoti";
            this.laNoti.Size = new System.Drawing.Size(168, 15);
            this.laNoti.TabIndex = 8;
            this.laNoti.Text = "Nhập số nguyên dương bất kì";
            // 
            // FProblem1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 437);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FProblem1";
            this.Text = "Bài toán 1: Tính số Fibonacci thứ n";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbEnterN;
        private System.Windows.Forms.TextBox tbEnterN;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbFibonaccin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbsofibonaccin;
        private System.Windows.Forms.Label lbtimeofsingthread;
        private System.Windows.Forms.Label lbtimeofmulthread;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label laNotification;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label laNoti;
    }
}