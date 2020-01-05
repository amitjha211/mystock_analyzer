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
    public partial class frmSYS_UpdateIndex : winui.frmBase
    {
        public frmSYS_UpdateIndex()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            textBox1.Text = ui.showOpenFile("CSV File|*.csv*");
        }

        private void frmSYS_UploadBhavData_Load(object sender, EventArgs e)
        {

            DataTable t = ui.oTier.getData("drp_mIndex", new clsCmd()).Obj as DataTable;
            ui.fillList(t, comboBox1);
        }


        private void btnUpload_Click(object sender, EventArgs e)
        {
            var cmd2 = new clsCmd();

            cmd2.Files.Add(textBox1.Text);
            cmd2.setValue("mIndexID", comboBox1.SelectedValue);
            ui.oTier.exec("update_index_info", cmd2);


            ui.alert("Done");
        }


    }
}
