﻿namespace DBDBDIB
{
    partial class Attend
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
            this.dgvattend = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bLookup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEmp = new System.Windows.Forms.TextBox();
            this.dtpToday = new System.Windows.Forms.DateTimePicker();
            this.bOut = new System.Windows.Forms.Button();
            this.bIn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvattend)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvattend
            // 
            this.dgvattend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvattend.Location = new System.Drawing.Point(12, 118);
            this.dgvattend.Name = "dgvattend";
            this.dgvattend.RowTemplate.Height = 23;
            this.dgvattend.Size = new System.Drawing.Size(582, 259);
            this.dgvattend.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.bLookup);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbEmp);
            this.groupBox1.Controls.Add(this.dtpToday);
            this.groupBox1.Controls.Add(this.bOut);
            this.groupBox1.Controls.Add(this.bIn);
            this.groupBox1.Location = new System.Drawing.Point(12, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 83);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "근태관리";
            // 
            // bLookup
            // 
            this.bLookup.Location = new System.Drawing.Point(498, 48);
            this.bLookup.Name = "bLookup";
            this.bLookup.Size = new System.Drawing.Size(52, 23);
            this.bLookup.TabIndex = 4;
            this.bLookup.Text = "조회";
            this.bLookup.UseVisualStyleBackColor = true;
            this.bLookup.Click += new System.EventHandler(this.bLookup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "사원번호";
            // 
            // tbEmp
            // 
            this.tbEmp.Location = new System.Drawing.Point(385, 49);
            this.tbEmp.Name = "tbEmp";
            this.tbEmp.Size = new System.Drawing.Size(107, 21);
            this.tbEmp.TabIndex = 2;
            // 
            // dtpToday
            // 
            this.dtpToday.Location = new System.Drawing.Point(334, 24);
            this.dtpToday.Name = "dtpToday";
            this.dtpToday.Size = new System.Drawing.Size(215, 21);
            this.dtpToday.TabIndex = 1;
            this.dtpToday.ValueChanged += new System.EventHandler(this.dtpToday_ValueChanged);
            // 
            // bOut
            // 
            this.bOut.Location = new System.Drawing.Point(168, 24);
            this.bOut.Name = "bOut";
            this.bOut.Size = new System.Drawing.Size(143, 45);
            this.bOut.TabIndex = 0;
            this.bOut.Text = "퇴근";
            this.bOut.UseVisualStyleBackColor = true;
            this.bOut.Click += new System.EventHandler(this.bOut_Click);
            // 
            // bIn
            // 
            this.bIn.Location = new System.Drawing.Point(19, 24);
            this.bIn.Name = "bIn";
            this.bIn.Size = new System.Drawing.Size(143, 45);
            this.bIn.TabIndex = 0;
            this.bIn.Text = "출근";
            this.bIn.UseVisualStyleBackColor = true;
            this.bIn.Click += new System.EventHandler(this.bIn_Click);
            // 
            // Attend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 389);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvattend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Attend";
            this.Text = "s";
            ((System.ComponentModel.ISupportInitialize)(this.dgvattend)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvattend;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpToday;
        private System.Windows.Forms.Button bOut;
        private System.Windows.Forms.Button bIn;
        private System.Windows.Forms.Button bLookup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEmp;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}