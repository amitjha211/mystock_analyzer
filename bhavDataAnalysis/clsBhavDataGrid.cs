using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace mystock_win
{
    internal class clsBhavDataGrid
    {


        
        private DataGridView dataGridView1;
        private CheckedListBox checkedListBox1;

        public clsBhavDataGrid(DataGridView _dataGridView1
            , CheckedListBox _checkedListBox1)
        {
            dataGridView1 = _dataGridView1;
            checkedListBox1 = _checkedListBox1;


            _checkedListBox1.Items.Clear();

            checkedListBox1.Items.Add("nameofcompany", true);
            checkedListBox1.Items.Add("deliv_per", true);
            checkedListBox1.Items.Add("symbol", true);
            checkedListBox1.Items.Add("series", false);
            checkedListBox1.Items.Add("date1", false);
            checkedListBox1.Items.Add("prev_close", true);
            checkedListBox1.Items.Add("open_price", false);
            checkedListBox1.Items.Add("high_price", false);
            checkedListBox1.Items.Add("low_price", false);
            checkedListBox1.Items.Add("last_price", false);
            checkedListBox1.Items.Add("close_price", true);
            checkedListBox1.Items.Add("avg_price", false);
            checkedListBox1.Items.Add("ttl_trd_qnty", true);
            checkedListBox1.Items.Add("turnover_lacs", false);
            checkedListBox1.Items.Add("no_of_trades", true);
            checkedListBox1.Items.Add("deliv_qty", true);
            checkedListBox1.Items.Add("remarks", false);


            dataGridView1.Sorted += new EventHandler(dataGridView1_Sorted);


        }

        void dataGridView1_Sorted(object sender, EventArgs e)
        {
            color_close_price();
        }


        public void showColumnsInformation(DataTable t)
        {
            foreach (DataColumn col in t.Columns)
            {
                checkedListBox1.Items.Add(col.ColumnName, true);
            }
        }
        public void createColumnsFromCheckListItem()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i) == true)
                {
                    string sField = checkedListBox1.GetItemText(checkedListBox1.Items[i]);

                    dataGridView1.Columns.Add(sField, sField);
                    dataGridView1.Columns[dataGridView1.Columns.Count - 1].DataPropertyName = sField;

                }
            }

        }

        public void color_close_price()
        {
            int iCol = 0;

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (col.DataPropertyName.ToUpper() == "CLOSE_PRICE")
                {
                    iCol = col.Index;
                }
            }
            if (iCol == 0) return;

            for (int iRow = 0; iRow < dataGridView1.Rows.Count; iRow++)
            {
                DataRowView r = dataGridView1.Rows[iRow].DataBoundItem as DataRowView;
                //if (r == null) return;

                double pre_close = Convert.ToDouble( r["PREV_CLOSE"]);

                double close_price = Convert.ToDouble( r["CLOSE_PRICE"]);


                if (close_price > pre_close)
                {
                    dataGridView1.Rows[iRow].Cells[iCol].Style.BackColor = Color.YellowGreen;
                    dataGridView1.Rows[iRow].Cells[iCol].Style.Font = new Font(dataGridView1.Font, FontStyle.Bold);
                }

                if (close_price < pre_close)
                {
                    dataGridView1.Rows[iRow].Cells[iCol].Style.BackColor = Color.Red;
                    dataGridView1.Rows[iRow].Cells[iCol].Style.Font = new Font(dataGridView1.Font, FontStyle.Bold);
                }
            }

        }




    }
}
