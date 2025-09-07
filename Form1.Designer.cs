namespace StarlightRotation
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelDevice1SerialNumber = new System.Windows.Forms.Label();
            this.labelDevice2SerialNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LabelLight1ReadNumber = new System.Windows.Forms.Label();
            this.LabelLight2ReadNumber = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDevice1SerialNumber
            // 
            this.labelDevice1SerialNumber.AutoSize = true;
            this.labelDevice1SerialNumber.Location = new System.Drawing.Point(282, 61);
            this.labelDevice1SerialNumber.Name = "labelDevice1SerialNumber";
            this.labelDevice1SerialNumber.Size = new System.Drawing.Size(82, 24);
            this.labelDevice1SerialNumber.TabIndex = 0;
            this.labelDevice1SerialNumber.Text = "label1";
            this.labelDevice1SerialNumber.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelDevice2SerialNumber
            // 
            this.labelDevice2SerialNumber.AutoSize = true;
            this.labelDevice2SerialNumber.Location = new System.Drawing.Point(282, 108);
            this.labelDevice2SerialNumber.Name = "labelDevice2SerialNumber";
            this.labelDevice2SerialNumber.Size = new System.Drawing.Size(82, 24);
            this.labelDevice2SerialNumber.TabIndex = 0;
            this.labelDevice2SerialNumber.Text = "label1";
            this.labelDevice2SerialNumber.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Device1 Serial Number:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Device2 Serial Number:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Light1 Read Number: ";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Light2 Read Number";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // LabelLight1ReadNumber
            // 
            this.LabelLight1ReadNumber.AutoSize = true;
            this.LabelLight1ReadNumber.Location = new System.Drawing.Point(282, 176);
            this.LabelLight1ReadNumber.Name = "LabelLight1ReadNumber";
            this.LabelLight1ReadNumber.Size = new System.Drawing.Size(82, 24);
            this.LabelLight1ReadNumber.TabIndex = 0;
            this.LabelLight1ReadNumber.Text = "label1";
            this.LabelLight1ReadNumber.Click += new System.EventHandler(this.label1_Click);
            // 
            // LabelLight2ReadNumber
            // 
            this.LabelLight2ReadNumber.AutoSize = true;
            this.LabelLight2ReadNumber.Location = new System.Drawing.Point(282, 223);
            this.LabelLight2ReadNumber.Name = "LabelLight2ReadNumber";
            this.LabelLight2ReadNumber.Size = new System.Drawing.Size(82, 24);
            this.LabelLight2ReadNumber.TabIndex = 0;
            this.LabelLight2ReadNumber.Text = "label1";
            this.LabelLight2ReadNumber.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(506, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 71);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelLight2ReadNumber);
            this.Controls.Add(this.LabelLight1ReadNumber);
            this.Controls.Add(this.labelDevice2SerialNumber);
            this.Controls.Add(this.labelDevice1SerialNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDevice1SerialNumber;
        private System.Windows.Forms.Label labelDevice2SerialNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LabelLight1ReadNumber;
        private System.Windows.Forms.Label LabelLight2ReadNumber;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}

