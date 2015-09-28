namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewtOutput = new System.Windows.Forms.TextBox();
            this.btnNewtPath = new System.Windows.Forms.Button();
            this.txtLower4 = new System.Windows.Forms.TextBox();
            this.txtLower3 = new System.Windows.Forms.TextBox();
            this.txtLower2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLower1 = new System.Windows.Forms.TextBox();
            this.txtUpper4 = new System.Windows.Forms.TextBox();
            this.txtUpper3 = new System.Windows.Forms.TextBox();
            this.txtUpper2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUpper1 = new System.Windows.Forms.TextBox();
            this.btnStartNewt = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtExcelOutput = new System.Windows.Forms.TextBox();
            this.picCompanyLogo = new System.Windows.Forms.PictureBox();
            this.btnGetLic = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCompanyLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNewtOutput);
            this.groupBox1.Controls.Add(this.btnNewtPath);
            this.groupBox1.Controls.Add(this.txtLower4);
            this.groupBox1.Controls.Add(this.txtLower3);
            this.groupBox1.Controls.Add(this.txtLower2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtLower1);
            this.groupBox1.Controls.Add(this.txtUpper4);
            this.groupBox1.Controls.Add(this.txtUpper3);
            this.groupBox1.Controls.Add(this.txtUpper2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtUpper1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 179);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auto NEWT";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 40);
            this.label3.TabIndex = 27;
            this.label3.Text = "Output Path";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNewtOutput
            // 
            this.txtNewtOutput.Location = new System.Drawing.Point(153, 126);
            this.txtNewtOutput.Name = "txtNewtOutput";
            this.txtNewtOutput.Size = new System.Drawing.Size(509, 35);
            this.txtNewtOutput.TabIndex = 26;
            this.txtNewtOutput.Text = "\\\\bfs1\\IT_Department\\Inventory\\Brampton";
            this.txtNewtOutput.TextChanged += new System.EventHandler(this.txtNewtOutput_TextChanged);
            // 
            // btnNewtPath
            // 
            this.btnNewtPath.BackColor = System.Drawing.Color.Bisque;
            this.btnNewtPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewtPath.Location = new System.Drawing.Point(454, 41);
            this.btnNewtPath.Name = "btnNewtPath";
            this.btnNewtPath.Size = new System.Drawing.Size(188, 61);
            this.btnNewtPath.TabIndex = 23;
            this.btnNewtPath.Text = "NEWT Path";
            this.btnNewtPath.UseVisualStyleBackColor = false;
            this.btnNewtPath.Click += new System.EventHandler(this.btnNewtPath_Click);
            // 
            // txtLower4
            // 
            this.txtLower4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLower4.Location = new System.Drawing.Point(377, 77);
            this.txtLower4.Multiline = true;
            this.txtLower4.Name = "txtLower4";
            this.txtLower4.Size = new System.Drawing.Size(48, 38);
            this.txtLower4.TabIndex = 22;
            this.txtLower4.Text = "1";
            this.txtLower4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLower3
            // 
            this.txtLower3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLower3.Location = new System.Drawing.Point(323, 77);
            this.txtLower3.Multiline = true;
            this.txtLower3.Name = "txtLower3";
            this.txtLower3.Size = new System.Drawing.Size(48, 38);
            this.txtLower3.TabIndex = 21;
            this.txtLower3.Text = "1";
            this.txtLower3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLower2
            // 
            this.txtLower2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLower2.Location = new System.Drawing.Point(269, 77);
            this.txtLower2.Multiline = true;
            this.txtLower2.Name = "txtLower2";
            this.txtLower2.Size = new System.Drawing.Size(48, 38);
            this.txtLower2.TabIndex = 20;
            this.txtLower2.Text = "168";
            this.txtLower2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 40);
            this.label2.TabIndex = 19;
            this.label2.Text = "Lower IP Address";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLower1
            // 
            this.txtLower1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLower1.Location = new System.Drawing.Point(215, 77);
            this.txtLower1.Multiline = true;
            this.txtLower1.Name = "txtLower1";
            this.txtLower1.Size = new System.Drawing.Size(48, 38);
            this.txtLower1.TabIndex = 18;
            this.txtLower1.Text = "192";
            this.txtLower1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUpper4
            // 
            this.txtUpper4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpper4.Location = new System.Drawing.Point(377, 33);
            this.txtUpper4.Multiline = true;
            this.txtUpper4.Name = "txtUpper4";
            this.txtUpper4.Size = new System.Drawing.Size(48, 38);
            this.txtUpper4.TabIndex = 17;
            this.txtUpper4.Text = "255";
            this.txtUpper4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUpper3
            // 
            this.txtUpper3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpper3.Location = new System.Drawing.Point(323, 33);
            this.txtUpper3.Multiline = true;
            this.txtUpper3.Name = "txtUpper3";
            this.txtUpper3.Size = new System.Drawing.Size(48, 38);
            this.txtUpper3.TabIndex = 16;
            this.txtUpper3.Text = "1";
            this.txtUpper3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUpper2
            // 
            this.txtUpper2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpper2.Location = new System.Drawing.Point(269, 33);
            this.txtUpper2.Multiline = true;
            this.txtUpper2.Name = "txtUpper2";
            this.txtUpper2.Size = new System.Drawing.Size(48, 38);
            this.txtUpper2.TabIndex = 15;
            this.txtUpper2.Text = "168";
            this.txtUpper2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 38);
            this.label1.TabIndex = 14;
            this.label1.Text = "Upper IP Address";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUpper1
            // 
            this.txtUpper1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpper1.Location = new System.Drawing.Point(215, 33);
            this.txtUpper1.Multiline = true;
            this.txtUpper1.Name = "txtUpper1";
            this.txtUpper1.Size = new System.Drawing.Size(48, 38);
            this.txtUpper1.TabIndex = 13;
            this.txtUpper1.Text = "192";
            this.txtUpper1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnStartNewt
            // 
            this.btnStartNewt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnStartNewt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartNewt.Location = new System.Drawing.Point(32, 386);
            this.btnStartNewt.Name = "btnStartNewt";
            this.btnStartNewt.Size = new System.Drawing.Size(317, 56);
            this.btnStartNewt.TabIndex = 25;
            this.btnStartNewt.Text = "Start AutoNEWT";
            this.btnStartNewt.UseVisualStyleBackColor = false;
            this.btnStartNewt.Click += new System.EventHandler(this.btnStartNewt_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtExcelOutput);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(21, 286);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(674, 91);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Software License";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 40);
            this.label4.TabIndex = 29;
            this.label4.Text = "Output Path";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtExcelOutput
            // 
            this.txtExcelOutput.Location = new System.Drawing.Point(153, 37);
            this.txtExcelOutput.Name = "txtExcelOutput";
            this.txtExcelOutput.Size = new System.Drawing.Size(509, 35);
            this.txtExcelOutput.TabIndex = 28;
            this.txtExcelOutput.Text = "\\\\venus\\temp";
            // 
            // picCompanyLogo
            // 
            this.picCompanyLogo.Image = ((System.Drawing.Image)(resources.GetObject("picCompanyLogo.Image")));
            this.picCompanyLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("picCompanyLogo.InitialImage")));
            this.picCompanyLogo.Location = new System.Drawing.Point(127, 19);
            this.picCompanyLogo.Name = "picCompanyLogo";
            this.picCompanyLogo.Size = new System.Drawing.Size(461, 64);
            this.picCompanyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCompanyLogo.TabIndex = 17;
            this.picCompanyLogo.TabStop = false;
            // 
            // btnGetLic
            // 
            this.btnGetLic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGetLic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetLic.Location = new System.Drawing.Point(386, 386);
            this.btnGetLic.Name = "btnGetLic";
            this.btnGetLic.Size = new System.Drawing.Size(297, 56);
            this.btnGetLic.TabIndex = 26;
            this.btnGetLic.Text = "Get License";
            this.btnGetLic.UseVisualStyleBackColor = false;
            this.btnGetLic.Click += new System.EventHandler(this.btnGetLic_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(711, 454);
            this.Controls.Add(this.btnGetLic);
            this.Controls.Add(this.picCompanyLogo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnStartNewt);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(733, 510);
            this.MinimumSize = new System.Drawing.Size(733, 510);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Inventory & License Extractor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCompanyLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStartNewt;
        private System.Windows.Forms.Button btnNewtPath;
        private System.Windows.Forms.TextBox txtLower4;
        private System.Windows.Forms.TextBox txtLower3;
        private System.Windows.Forms.TextBox txtLower2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLower1;
        private System.Windows.Forms.TextBox txtUpper4;
        private System.Windows.Forms.TextBox txtUpper3;
        private System.Windows.Forms.TextBox txtUpper2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUpper1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picCompanyLogo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewtOutput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtExcelOutput;
        private System.Windows.Forms.Button btnGetLic;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

