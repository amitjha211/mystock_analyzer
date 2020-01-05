using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mystock_win
{
    public partial class frmRPT_SingleStockAnalysis : winui.frmBase
    {
        public frmRPT_SingleStockAnalysis()
        {
            InitializeComponent();
        }

        clsBhavDataGrid oGRID_BhavData;
        private void frmTR_DailyAnalysis_Load(object sender, EventArgs e)
        {
            oGRID_BhavData = new clsBhavDataGrid(grdData, checkedListBox1);

        }

        int iStockID = 0;


        private void obtain_data()
        {
            
            var cmd = new clsCmd();

            cmd.setValue("mStockID", iStockID);

            if (chkVolume_Above.Checked)
                cmd.setValue("deliv_qty_above", txtVolumeAbove.Text);

            if (chkDeliveryPerAbove.Checked)
                cmd.setValue("deliv_per_above", txtDeliveryPerAbove.Text);

            if (chkNoOfTradesAbove.Checked)
                cmd.setValue("no_of_trades_above", txtNoOfTradesAbove.Text);
            


            var t = ui.oTier.getData("stock_data", cmd).Obj as DataTable;

            oGRID_BhavData.createColumnsFromCheckListItem();
            grdData.DataSource = t;
            oGRID_BhavData.color_close_price();

        }


        private void btnShow_Click(object sender, EventArgs e)
        {
            obtain_data();
        }


        public void callMe(DataRowView r)
        {
            lblInfo.Text = r["company_Name"].ToString();

            iStockID = g.parseInt(r["mStockID"].ToString());

            obtain_data();
        }


    }
}
