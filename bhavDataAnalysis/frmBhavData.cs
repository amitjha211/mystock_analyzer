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
    public partial class frmBhavData : winui.frmBase
    {
        public frmBhavData()
        {
            InitializeComponent();
        }

        DataTable t = null;

        clsBhavDataGrid oBhavGrid;


        private void btnOpenCSV_Click(object sender, EventArgs e)
        {
            var oFile = new System.Windows.Forms.OpenFileDialog();
            oFile.Filter = "CSV File|*.csv";
            if (oFile.ShowDialog() == DialogResult.OK)
            {
                lblFilePath.Text = oFile.FileName;
                t = g.readCSV(lblFilePath.Text);
                //dataGridView1.DataSource = getTable();
                t = getTable();
                oBhavGrid.showColumnsInformation(t);
            }
        }

        private DataTable getTable()
        {
            DataTable tTmp = g.readCSV(lblFilePath.Text);
            foreach (DataColumn col in tTmp.Columns) col.ColumnName = col.ColumnName.Trim();


            t = new DataTable();
            t.TableName = "bhavData";


            t.Columns.Add("SYMBOL", typeof(string));
            t.Columns.Add("SERIES", typeof(string));
            t.Columns.Add("DATE1", typeof(string));
            t.Columns.Add("PREV_CLOSE", typeof(decimal));
            t.Columns.Add("OPEN_PRICE", typeof(decimal));
            t.Columns.Add("HIGH_PRICE", typeof(decimal));
            t.Columns.Add("LOW_PRICE", typeof(decimal));
            t.Columns.Add("LAST_PRICE", typeof(decimal));
            t.Columns.Add("CLOSE_PRICE", typeof(decimal));
            t.Columns.Add("AVG_PRICE", typeof(decimal));
            t.Columns.Add("TTL_TRD_QNTY", typeof(decimal));
            t.Columns.Add("TURNOVER_LACS", typeof(decimal));
            t.Columns.Add("NO_OF_TRADES", typeof(decimal));
            t.Columns.Add("DELIV_QTY", typeof(decimal));
            t.Columns.Add("DELIV_PER", typeof(decimal));

            foreach (DataRow rSource in tTmp.Rows)
            {
                DataRow rDestination = t.NewRow();
                rDestination["SYMBOL"] = rSource["SYMBOL"];
                rDestination["SERIES"] = rSource["SERIES"];
                rDestination["DATE1"] = rSource["DATE1"];

                rDestination["PREV_CLOSE"] = g.parseDecimal(rSource["PREV_CLOSE"], 2);
                rDestination["OPEN_PRICE"] = g.parseDecimal(rSource["OPEN_PRICE"], 2);
                rDestination["HIGH_PRICE"] = g.parseDecimal(rSource["HIGH_PRICE"], 2);
                rDestination["LOW_PRICE"] = g.parseDecimal(rSource["LOW_PRICE"], 2);
                rDestination["LAST_PRICE"] = g.parseDecimal(rSource["LAST_PRICE"], 2);
                rDestination["CLOSE_PRICE"] = g.parseDecimal(rSource["CLOSE_PRICE"], 2);
                rDestination["AVG_PRICE"] = g.parseDecimal(rSource["AVG_PRICE"], 2);
                rDestination["TTL_TRD_QNTY"] = g.parseDecimal(rSource["TTL_TRD_QNTY"], 2);
                rDestination["TURNOVER_LACS"] = g.parseDecimal(rSource["TURNOVER_LACS"], 2);
                rDestination["NO_OF_TRADES"] = g.parseDecimal(rSource["NO_OF_TRADES"], 2);
                rDestination["DELIV_QTY"] = g.parseDecimal(rSource["DELIV_QTY"], 2);
                rDestination["DELIV_PER"] = g.parseDecimal(rSource["DELIV_PER"], 2);



                t.Rows.Add(rDestination);
            }

            return t;
        }
        

        private void showData()
        {



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            oBhavGrid = new clsBhavDataGrid(dataGridView1, checkedListBox1);
        }


        private void btnShow_Click(object sender, EventArgs e)
        {
            bindingSource1.DataSource = t;
            string qFilter = "";

            qFilter = " DELIV_PER > " + txtDeliveryPer.Text + " and  DELIV_QTY > " + txtVolume.Text;

            if (txtQuickSearch.Text.isEmpty() == false)
            {
                qFilter += string.Format(" and symbol like '{0}*'", txtQuickSearch.Text);
            }

            bindingSource1.Filter = qFilter;
            oBhavGrid.createColumnsFromCheckListItem();
            dataGridView1.DataSource = bindingSource1;
            oBhavGrid.color_close_price();
        }

        
    }
}
