namespace mystock_win
{
    partial class frmRPT_SingleStockAnalysis
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.chkNoOfTradesAbove = new System.Windows.Forms.CheckBox();
            this.chkDeliveryPerAbove = new System.Windows.Forms.CheckBox();
            this.chkVolume_Above = new System.Windows.Forms.CheckBox();
            this.txtNoOfTradesAbove = new System.Windows.Forms.TextBox();
            this.txtDeliveryPerAbove = new System.Windows.Forms.TextBox();
            this.txtVolumeAbove = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.grdData = new System.Windows.Forms.DataGridView();
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
            this.checkedListBox1.Location = new System.Drawing.Point(12, 319);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(220, 196);
            this.checkedListBox1.TabIndex = 10;
            // 
            // chkNoOfTradesAbove
            // 
            this.chkNoOfTradesAbove.AutoSize = true;
            this.chkNoOfTradesAbove.Location = new System.Drawing.Point(12, 266);
            this.chkNoOfTradesAbove.Name = "chkNoOfTradesAbove";
            this.chkNoOfTradesAbove.Size = new System.Drawing.Size(122, 17);
            this.chkNoOfTradesAbove.TabIndex = 9;
            this.chkNoOfTradesAbove.Text = "No of Trades Above";
            this.chkNoOfTradesAbove.UseVisualStyleBackColor = true;
            // 
            // chkDeliveryPerAbove
            // 
            this.chkDeliveryPerAbove.AutoSize = true;
            this.chkDeliveryPerAbove.Location = new System.Drawing.Point(12, 222);
            this.chkDeliveryPerAbove.Name = "chkDeliveryPerAbove";
            this.chkDeliveryPerAbove.Size = new System.Drawing.Size(140, 17);
            this.chkDeliveryPerAbove.TabIndex = 8;
            this.chkDeliveryPerAbove.Text = "Delivery Per (%) Above";
            this.chkDeliveryPerAbove.UseVisualStyleBackColor = true;
            // 
            // chkVolume_Above
            // 
            this.chkVolume_Above.AutoSize = true;
            this.chkVolume_Above.Location = new System.Drawing.Point(12, 178);
            this.chkVolume_Above.Name = "chkVolume_Above";
            this.chkVolume_Above.Size = new System.Drawing.Size(94, 17);
            this.chkVolume_Above.TabIndex = 7;
            this.chkVolume_Above.Text = "Volume Above";
            this.chkVolume_Above.UseVisualStyleBackColor = true;
            // 
            // txtNoOfTradesAbove
            // 
            this.txtNoOfTradesAbove.Location = new System.Drawing.Point(12, 285);
            this.txtNoOfTradesAbove.Name = "txtNoOfTradesAbove";
            this.txtNoOfTradesAbove.Size = new System.Drawing.Size(220, 21);
            this.txtNoOfTradesAbove.TabIndex = 6;
            this.txtNoOfTradesAbove.Text = "200";
            // 
            // txtDeliveryPerAbove
            // 
            this.txtDeliveryPerAbove.Location = new System.Drawing.Point(12, 241);
            this.txtDeliveryPerAbove.Name = "txtDeliveryPerAbove";
            this.txtDeliveryPerAbove.Size = new System.Drawing.Size(220, 21);
            this.txtDeliveryPerAbove.TabIndex = 4;
            this.txtDeliveryPerAbove.Text = "49";
            // 
            // txtVolumeAbove
            // 
            this.txtVolumeAbove.Location = new System.Drawing.Point(12, 195);
            this.txtVolumeAbove.Name = "txtVolumeAbove";
            this.txtVolumeAbove.Size = new System.Drawing.Size(220, 21);
            this.txtVolumeAbove.TabIndex = 2;
            this.txtVolumeAbove.Text = "150000";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnShow);
            this.panel2.Controls.Add(this.lblInfo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(240, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(549, 35);
            this.panel2.TabIndex = 1;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(254, 7);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "&Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(9, 10);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(55, 18);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "label1";
            // 
            // grdData
            // 
            this.grdData.AllowUserToAddRows = false;
            this.grdData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Location = new System.Drawing.Point(248, 41);
            this.grdData.Name = "grdData";
            this.grdData.Size = new System.Drawing.Size(532, 480);
            this.grdData.TabIndex = 2;
            // 
            // frmRPT_SingleStockAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 533);
            this.Controls.Add(this.grdData);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmRPT_SingleStockAnalysis";
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
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtDeliveryPerAbove;
        private System.Windows.Forms.TextBox txtVolumeAbove;
        private System.Windows.Forms.TextBox txtNoOfTradesAbove;
        private System.Windows.Forms.CheckBox chkVolume_Above;
        private System.Windows.Forms.CheckBox chkDeliveryPerAbove;
        private System.Windows.Forms.CheckBox chkNoOfTradesAbove;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnShow;
    }
}