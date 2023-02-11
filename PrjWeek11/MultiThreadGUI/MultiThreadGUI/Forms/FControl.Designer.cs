namespace MultiThreadGUI
{
    partial class FControl
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
            this.lbChooseProblem = new System.Windows.Forms.Label();
            this.lbProblem1 = new System.Windows.Forms.Label();
            this.lbProblem2 = new System.Windows.Forms.Label();
            this.lbProblem3 = new System.Windows.Forms.Label();
            this.btProblem1 = new System.Windows.Forms.Button();
            this.btProblem2 = new System.Windows.Forms.Button();
            this.btProblem3 = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btExit);
            this.panel1.Controls.Add(this.btProblem3);
            this.panel1.Controls.Add(this.btProblem2);
            this.panel1.Controls.Add(this.btProblem1);
            this.panel1.Controls.Add(this.lbProblem3);
            this.panel1.Controls.Add(this.lbProblem2);
            this.panel1.Controls.Add(this.lbProblem1);
            this.panel1.Controls.Add(this.lbChooseProblem);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 284);
            this.panel1.TabIndex = 0;
            // 
            // lbChooseProblem
            // 
            this.lbChooseProblem.AutoEllipsis = true;
            this.lbChooseProblem.AutoSize = true;
            this.lbChooseProblem.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChooseProblem.Location = new System.Drawing.Point(186, 4);
            this.lbChooseProblem.Name = "lbChooseProblem";
            this.lbChooseProblem.Size = new System.Drawing.Size(219, 31);
            this.lbChooseProblem.TabIndex = 0;
            this.lbChooseProblem.Text = "Lựa chọn bài toán:";
            this.lbChooseProblem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbProblem1
            // 
            this.lbProblem1.AutoSize = true;
            this.lbProblem1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProblem1.Location = new System.Drawing.Point(6, 68);
            this.lbProblem1.Name = "lbProblem1";
            this.lbProblem1.Size = new System.Drawing.Size(261, 23);
            this.lbProblem1.TabIndex = 1;
            this.lbProblem1.Text = "Bài toán 1: Tính số Fibonacci.";
            // 
            // lbProblem2
            // 
            this.lbProblem2.AutoSize = true;
            this.lbProblem2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProblem2.Location = new System.Drawing.Point(6, 117);
            this.lbProblem2.Name = "lbProblem2";
            this.lbProblem2.Size = new System.Drawing.Size(253, 23);
            this.lbProblem2.TabIndex = 2;
            this.lbProblem2.Text = "Bài toán 2: Nhân hai ma trận.";
            // 
            // lbProblem3
            // 
            this.lbProblem3.AutoSize = true;
            this.lbProblem3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProblem3.Location = new System.Drawing.Point(6, 169);
            this.lbProblem3.Name = "lbProblem3";
            this.lbProblem3.Size = new System.Drawing.Size(602, 23);
            this.lbProblem3.TabIndex = 3;
            this.lbProblem3.Text = "Bài toán 3: Biến đổi dãy số đã cho trở thành dãy số chỉ có số nguyên tố.";
            // 
            // btProblem1
            // 
            this.btProblem1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProblem1.Location = new System.Drawing.Point(20, 224);
            this.btProblem1.Name = "btProblem1";
            this.btProblem1.Size = new System.Drawing.Size(113, 33);
            this.btProblem1.TabIndex = 4;
            this.btProblem1.Text = "Bài toán 1";
            this.btProblem1.UseVisualStyleBackColor = true;
            this.btProblem1.Click += new System.EventHandler(this.btProblem1_Click);
            // 
            // btProblem2
            // 
            this.btProblem2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProblem2.Location = new System.Drawing.Point(175, 224);
            this.btProblem2.Name = "btProblem2";
            this.btProblem2.Size = new System.Drawing.Size(113, 33);
            this.btProblem2.TabIndex = 5;
            this.btProblem2.Text = "Bài toán 2";
            this.btProblem2.UseVisualStyleBackColor = true;
            this.btProblem2.Click += new System.EventHandler(this.btProblem2_Click);
            // 
            // btProblem3
            // 
            this.btProblem3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProblem3.Location = new System.Drawing.Point(327, 224);
            this.btProblem3.Name = "btProblem3";
            this.btProblem3.Size = new System.Drawing.Size(113, 33);
            this.btProblem3.TabIndex = 6;
            this.btProblem3.Text = "Bài toán 3";
            this.btProblem3.UseVisualStyleBackColor = true;
            this.btProblem3.Click += new System.EventHandler(this.btProblem3_Click);
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Location = new System.Drawing.Point(481, 224);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(113, 33);
            this.btExit.TabIndex = 7;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // FControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(628, 304);
            this.Controls.Add(this.panel1);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "FControl";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MultiThread Program";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FControl_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbChooseProblem;
        private System.Windows.Forms.Button btProblem3;
        private System.Windows.Forms.Button btProblem2;
        private System.Windows.Forms.Button btProblem1;
        private System.Windows.Forms.Label lbProblem3;
        private System.Windows.Forms.Label lbProblem2;
        private System.Windows.Forms.Label lbProblem1;
        private System.Windows.Forms.Button btExit;
    }
}

