namespace MultiThreadGUI
{
    partial class FProblem3
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
            this.label1 = new System.Windows.Forms.Label();
            this.textEnterN = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.latimeofmulthread = new System.Windows.Forms.Label();
            this.latimeofsingthread = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số lượng phần tử của dãy: ";
            // 
            // textEnterN
            // 
            this.textEnterN.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEnterN.Location = new System.Drawing.Point(440, 20);
            this.textEnterN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textEnterN.Name = "textEnterN";
            this.textEnterN.Size = new System.Drawing.Size(382, 44);
            this.textEnterN.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(866, 20);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "Bắt đầu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thời gian chạy đơn luồng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(327, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thời gian chạy đa luồng:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.latimeofmulthread);
            this.panel1.Controls.Add(this.latimeofsingthread);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(18, 118);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 565);
            this.panel1.TabIndex = 5;
            // 
            // latimeofmulthread
            // 
            this.latimeofmulthread.AutoSize = true;
            this.latimeofmulthread.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latimeofmulthread.Location = new System.Drawing.Point(432, 134);
            this.latimeofmulthread.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.latimeofmulthread.Name = "latimeofmulthread";
            this.latimeofmulthread.Size = new System.Drawing.Size(49, 36);
            this.latimeofmulthread.TabIndex = 6;
            this.latimeofmulthread.Text = "ms";
            // 
            // latimeofsingthread
            // 
            this.latimeofsingthread.AutoSize = true;
            this.latimeofsingthread.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latimeofsingthread.Location = new System.Drawing.Point(432, 28);
            this.latimeofsingthread.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.latimeofsingthread.Name = "latimeofsingthread";
            this.latimeofsingthread.Size = new System.Drawing.Size(49, 36);
            this.latimeofsingthread.TabIndex = 5;
            this.latimeofsingthread.Text = "ms";
            // 
            // FProblem3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textEnterN);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FProblem3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài toán 3: Biến đổi dãy số đã cho thành dãy số chỉ chứa số nguyên tố";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textEnterN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label latimeofmulthread;
        private System.Windows.Forms.Label latimeofsingthread;
    }
}