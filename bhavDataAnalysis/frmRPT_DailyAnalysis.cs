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
    public partial class frmRPT_DailyAnalysis : winui.frmBase
    {
        public frmRPT_DailyAnalysis()
        {
            InitializeComponent();
        }

        clsBhavDataGrid oGRID_BhavData;
        private void frmTR_DailyAnalysis_Load(object sender, EventArgs e)
        {
            oGRID_BhavData = new clsBhavDataGrid(grdData, checkedListBox1);

            DataTable t = ui.oTier.getData("drp_mIndex", new clsCmd()).Obj as DataTable;
            ui.fillList(t, drpIndex);

        }



        private void obtain_data()
        {
            
            var cmd = new clsCmd();

            //cmd.setValue("date1", monthCalendar1.SelectionRange.Start.ToString("dd/MMM/yyyy"));

            if (chkVolume_Above.Checked)
                cmd.setValue("deliv_qty_above", txtVolumeAbove.Text);

            if (chkDeliveryPerAbove.Checked)
                cmd.setValue("deliv_per_above", txtDeliveryPerAbove.Text);

            if (chkNoOfTradesAbove.Checked)
                cmd.setValue("no_of_trades_above", txtNoOfTradesAbove.Text);

            if (chkIndex.Checked)
                cmd.setValue("index_name", drpIndex.SelectedValue);

            var t = ui.oTier.getData("stock_data_tmp", cmd).Obj as DataTable;

            oGRID_BhavData.createColumnsFromCheckListItem();
            grdData.DataSource = t;
            oGRID_BhavData.color_close_price();

        }


        private void btnShow_Click(object sender, EventArgs e)
        {
            obtain_data();
        }

        private void btnAnalyzeSingleStock_Click(object sender, EventArgs e)
        {
            if (grdData.CurrentRow == null) return;
            DataRowView r = grdData.CurrentRow.DataBoundItem as DataRowView;
            var frm1 = new frmRPT_SingleStockAnalysis();
            frm1.MdiParent = this.MdiParent;
            frm1.Show();
            frm1.Activate();
            frm1.callMe(r);
        }


    }
}
