﻿namespace DBDBDIB
{
    partial class Chatting
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
            this.txtBoxMsg = new System.Windows.Forms.RichTextBox();
            this.txtUserMsg = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.RoomNum = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.RoomNum)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxMsg
            // 
            this.txtBoxMsg.Location = new System.Drawing.Point(12, 33);
            this.txtBoxMsg.Name = "txtBoxMsg";
            this.txtBoxMsg.ReadOnly = true;
            this.txtBoxMsg.Size = new System.Drawing.Size(389, 298);
            this.txtBoxMsg.TabIndex = 0;
            this.txtBoxMsg.Text = "";
            // 
            // txtUserMsg
            // 
            this.txtUserMsg.Location = new System.Drawing.Point(12, 337);
            this.txtUserMsg.Name = "txtUserMsg";
            this.txtUserMsg.Size = new System.Drawing.Size(308, 21);
            this.txtUserMsg.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(326, 336);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "보내기";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "방 번호";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(345, 4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(56, 23);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "연결";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // RoomNum
            // 
            this.RoomNum.Location = new System.Drawing.Point(300, 6);
            this.RoomNum.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.RoomNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RoomNum.Name = "RoomNum";
            this.RoomNum.ReadOnly = true;
            this.RoomNum.Size = new System.Drawing.Size(39, 21);
            this.RoomNum.TabIndex = 6;
            this.RoomNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Chatting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 362);
            this.Controls.Add(this.RoomNum);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtUserMsg);
            this.Controls.Add(this.txtBoxMsg);
            this.Name = "Chatting";
            this.Text = "Chatting";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Chatting_FormClosed);
            this.Load += new System.EventHandler(this.Chatting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RoomNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtBoxMsg;
        private System.Windows.Forms.TextBox txtUserMsg;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.NumericUpDown RoomNum;
    }
}