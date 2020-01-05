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
    public partial class frmSYS_UploadBhavData : winui.frmBase
    {
        public frmSYS_UploadBhavData()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            textBox1.Text = ui.showOpenFile("CSV File|*.csv*");
        }

        private void frmSYS_UploadBhavData_Load(object sender, EventArgs e)
        {

        }


        private void btnUpload_Click(object sender, EventArgs e)
        {
            //var cmd2 = new clsCmd();
            //cmd2.Files.Add(textBox1.Text);

            //ui.oTier.exec("upload_bhavdata", cmd2);
            //ui.alert("Done");
            //Validation start 


            btnOpenFile.Enabled = false;
            btnUpload.Enabled = false;
            button1.Enabled = false;
            


            var cmd = new clsCmd();

            cmd.Files.Add(textBox1.Text);
            var msg = _Tier.getData("getBhavDataInDataTable", cmd);

            if (msg.Validated)
            {
                DataTable t = msg.Obj as DataTable;
                progressBar1.Maximum = t.Rows.Count;    
                int i=0;
                _Tier.getAdapter().exec("delete from tmp_bhavdata");
                foreach (DataRow r in t.Rows)
                {
                    i++;
                    if (r["series"].ToString().ToUpper().Trim() != "EQ") continue;

                    var oCRUD = _Tier.getCRUD("tmp_bhavdata");
                    
                    ////////////////////////////
                    var cmd2 = new clsCmd();
                    cmd2.AddValues(r);
                    var msg2 = oCRUD.save(cmd2); //_Tier.exec("upload_bhavdata_row_tmp", cmd2);
                    if (msg2.Validated==false) ui.warn(msg2.Message);

                    progressBar1.Value = i;
                }

                ui.alert("Record uploaded successfully");
                ui.oForms.showForm("rpt_analyze_daily", new clsCmd());
            }
            else
            {
                ui.warn(msg.Message);
            }



            btnOpenFile.Enabled = true;
            btnUpload.Enabled = true;
            button1.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ui.oForms.showForm("rpt_analyze_daily", new clsCmd());
        }


    }
}
