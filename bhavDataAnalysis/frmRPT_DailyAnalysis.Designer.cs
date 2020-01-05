namespace mystock_win
{
    partial class frmRPT_DailyAnalysis
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.chkNoOfTradesAbove = new System.Windows.Forms.CheckBox();
            this.chkDeliveryPerAbove = new System.Windows.Forms.CheckBox();
            this.chkVolume_Above = new System.Windows.Forms.CheckBox();
            this.txtNoOfTradesAbove = new System.Windows.Forms.TextBox();
            this.txtDeliveryPerAbove = new System.Windows.Forms.TextBox();
            this.txtVolumeAbove = new System.Windows.Forms.TextBox();
            this.drpIndex = new System.Windows.Forms.ComboBox();
            this.chkIndex = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnShow = new System.Windows.Forms.Button();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.test = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkedListBox1);
            this.panel1.Controls.Add(this.chkNoOfTradesAbove);
            this.panel1.Controls.Add(this.chkDeliveryPerAbove);
            this.panel1.Controls.Add(this.chkVolume_Above);
            this.panel1.Controls.Add(this.txtNoOfTradesAbove);
            this.panel1.Controls.Add(this.txtDeliveryPerAbove);
            this.panel1.Controls.Add(this.txtVolumeAbove);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 533);
            this.panel1.TabIndex = 0;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "dsds"});
            this.checkedListBox1.Location = new System.Drawing.Point(12, 141);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(220, 388);
            this.checkedListBox1.TabIndex = 10;
            // 
            // chkNoOfTradesAbove
            // 
            this.chkNoOfTradesAbove.AutoSize = true;
            this.chkNoOfTradesAbove.Checked = true;
            this.chkNoOfTradesAbove.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNoOfTradesAbove.Location = new System.Drawing.Point(12, 95);
            this.chkNoOfTradesAbove.Name = "chkNoOfTradesAbove";
            this.chkNoOfTradesAbove.Size = new System.Drawing.Size(122, 17);
            this.chkNoOfTradesAbove.TabIndex = 9;
            this.chkNoOfTradesAbove.Text = "No of Trades Above";
            this.chkNoOfTradesAbove.UseVisualStyleBackColor = true;
            // 
            // chkDeliveryPerAbove
            // 
            this.chkDeliveryPerAbove.AutoSize = true;
            this.chkDeliveryPerAbove.Checked = true;
            this.chkDeliveryPerAbove.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDeliveryPerAbove.Location = new System.Drawing.Point(12, 51);
            this.chkDeliveryPerAbove.Name = "chkDeliveryPerAbove";
            this.chkDeliveryPerAbove.Size = new System.Drawing.Size(140, 17);
            this.chkDeliveryPerAbove.TabIndex = 8;
            this.chkDeliveryPerAbove.Text = "Delivery Per (%) Above";
            this.chkDeliveryPerAbove.UseVisualStyleBackColor = true;
            // 
            // chkVolume_Above
            // 
            this.chkVolume_Above.AutoSize = true;
            this.chkVolume_Above.Checked = true;
            this.chkVolume_Above.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVolume_Above.Location = new System.Drawing.Point(12, 7);
            this.chkVolume_Above.Name = "chkVolume_Above";
            this.chkVolume_Above.Size = new System.Drawing.Size(94, 17);
            this.chkVolume_Above.TabIndex = 7;
            this.chkVolume_Above.Text = "Volume Above";
            this.chkVolume_Above.UseVisualStyleBackColor = true;
            // 
            // txtNoOfTradesAbove
            // 
            this.txtNoOfTradesAbove.Location = new System.Drawing.Point(12, 114);
            this.txtNoOfTradesAbove.Name = "txtNoOfTradesAbove";
            this.txtNoOfTradesAbove.Size = new System.Drawing.Size(220, 21);
            this.txtNoOfTradesAbove.TabIndex = 6;
            this.txtNoOfTradesAbove.Text = "200";
            // 
            // txtDeliveryPerAbove
            // 
            this.txtDeliveryPerAbove.Location = new System.Drawing.Point(12, 70);
            this.txtDeliveryPerAbove.Name = "txtDeliveryPerAbove";
            this.txtDeliveryPerAbove.Size = new System.Drawing.Size(220, 21);
            this.txtDeliveryPerAbove.TabIndex = 4;
            this.txtDeliveryPerAbove.Text = "42";
            // 
            // txtVolumeAbove
            // 
            this.txtVolumeAbove.Location = new System.Drawing.Point(12, 24);
            this.txtVolumeAbove.Name = "txtVolumeAbove";
            this.txtVolumeAbove.Size = new System.Drawing.Size(220, 21);
            this.txtVolumeAbove.TabIndex = 2;
            this.txtVolumeAbove.Text = "150000";
            // 
            // drpIndex
            // 
            this.drpIndex.FormattingEnabled = true;
            this.drpIndex.Location = new System.Drawing.Point(100, 7);
            this.drpIndex.Name = "drpIndex";
            this.drpIndex.Size = new System.Drawing.Size(220, 21);
            this.drpIndex.TabIndex = 12;
            // 
            // chkIndex
            // 
            this.chkIndex.AutoSize = true;
            this.chkIndex.Location = new System.Drawing.Point(8, 11);
            this.chkIndex.Name = "chkIndex";
            this.chkIndex.Size = new System.Drawing.Size(86, 17);
            this.chkIndex.TabIndex = 11;
            this.chkIndex.Text = "Select Index";
            this.chkIndex.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.drpIndex);
            this.panel2.Controls.Add(this.chkIndex);
            this.panel2.Controls.Add(this.btnShow);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(240, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(736, 35);
            this.panel2.TabIndex = 1;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(337, 6);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "&Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // grdData
            // 
            this.grdData.AllowUserToAddRows = false;
            this.grdData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.test});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            
            this.grdData.Location = new System.Drawing.Point(248, 41);
            this.grdData.Name = "grdData";
            this.grdData.Size = new System.Drawing.Size(719, 480);
            this.grdData.TabIndex = 2;
            // 
            // test
            // 
            this.test.HeaderText = "Column1";
            this.test.Name = "test";
            // 
            // frmRPT_DailyAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 533);
            this.Controls.Add(this.grdData);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmRPT_DailyAnalysis";
            this.Text = "Daily Bhavdata Analysis";
            this.Load += new System.EventHandler(this.frmTR_DailyAnalysis_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.TextBox txtDeliveryPerAbove;
        private System.Windows.Forms.TextBox txtVolumeAbove;
        private System.Windows.Forms.TextBox txtNoOfTradesAbove;
        private System.Windows.Forms.CheckBox chkVolume_Above;
        private System.Windows.Forms.CheckBox chkDeliveryPerAbove;
        private System.Windows.Forms.CheckBox chkNoOfTradesAbove;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ComboBox drpIndex;
        private System.Windows.Forms.CheckBox chkIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn test;
    }
}