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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        
        private void treeDesignerToolStripMenuItem_Click(object sender, EventArgs e)
        {


            ui.showForm("tree", new clsCmd());
            //ui.showForm
        }


        private void testFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ui.showForm("test", new clsCmd());
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ui.oForms.setMainForm(this);
            ui.oForms.showForm("upload_bhavdata", new clsCmd());
        }

        private void uploadBhavDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ui.oForms.showForm("upload_bhavdata", new clsCmd());
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            ui.oForms.showForm("upload_index_info", new clsCmd());
        }

        private void analyzeCSVFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ui.oForms.showForm("tool_analyze_bhavdata", new clsCmd());
        }

        private void dailyAnalyzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ui.oForms.showForm("rpt_analyze_daily", new clsCmd());
        }

        

    }
}
