﻿namespace DBDBDIB
{
    partial class ApprovalListForm
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
            this.dgv_MyApprList = new System.Windows.Forms.DataGridView();
            this.combo_Appr = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MyApprList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_MyApprList
            // 
            this.dgv_MyApprList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_MyApprList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MyApprList.Location = new System.Drawing.Point(12, 66);
            this.dgv_MyApprList.Name = "dgv_MyApprList";
            this.dgv_MyApprList.RowHeadersWidth = 51;
            this.dgv_MyApprList.RowTemplate.Height = 27;
            this.dgv_MyApprList.Size = new System.Drawing.Size(865, 428);
            this.dgv_MyApprList.TabIndex = 0;
            // 
            // combo_Appr
            // 
            this.combo_Appr.FormattingEnabled = true;
            this.combo_Appr.Items.AddRange(new object[] {
            "모든 결재 내역",
            "결재 중 내역",
            "결재 완료 내역",
            "결재할 내역"});
            this.combo_Appr.Location = new System.Drawing.Point(95, 23);
            this.combo_Appr.Name = "combo_Appr";
            this.combo_Appr.Size = new System.Drawing.Size(195, 23);
            this.combo_Appr.TabIndex = 1;
            this.combo_Appr.SelectedIndexChanged += new System.EventHandler(this.combo_Appr_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "모아보기";
            // 
            // ApprovalListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 506);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_Appr);
            this.Controls.Add(this.dgv_MyApprList);
            this.Name = "ApprovalListForm";
            this.Text = "ApprovalListForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MyApprList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_MyApprList;
        private System.Windows.Forms.ComboBox combo_Appr;
        private System.Windows.Forms.Label label1;
    }
}