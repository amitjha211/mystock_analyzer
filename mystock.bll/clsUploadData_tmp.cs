using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace mystock.bll
{
    public class clsUploadData_tmp : NTier.Request.clsRequest
    {

        clsBussinessLogic _oBLLStock;

        clsBussinessLogic oBLLStock
        {

            get
            {
                if (_oBLLStock == null)
                {
                    _oBLLStock = new clsBussinessLogic();
                    _oBLLStock.setTier(_tier);
                }
                return _oBLLStock;
            }
        }

        DataTable _tStockMaster = null;

        private DataTable getStockMaster()
        {
            if (_tStockMaster == null) _tStockMaster = oBLLStock.getStockMaster();
            return _tStockMaster;
        }

        public override clsMsg validate(clsCmd cmd)
        {
            throw new NotImplementedException();
        }


        public clsMsg getBhavDataInDataTable(clsCmd cmd)
        {
            if (cmd.Files.Count == 0)
                return g.msg("Please select csv file.");
            ///////////////////////////

            var oFile = cmd.Files[0];
            string sTmp = System.IO.Path.GetTempFileName();

            System.IO.File.WriteAllBytes(sTmp, oFile.Data);
            /////////////////////////////////////

            DataTable t = null;

            try
            {
                t = g.readCSV(sTmp);
            }
            catch (Exception ex)
            {
                return g.msg("Unable to read csv : " + ex.Message);
            }

            foreach (DataColumn col in t.Columns)
                col.ColumnName = col.ColumnName.Trim();


            System.IO.File.Delete(sTmp);

            return g.msg("", t);
        }


        public clsMsg upload_bhavdata_row(clsCmd cmd)
        {

            int iDaily_PriceID = 0;

            string sDate1 = "";


            string sSymbol = "";
            string sSeries = "";


            sSymbol = cmd.getStringValue("symbol").Trim();
            sSeries = cmd.getStringValue("series").Trim();

            //DataRow[] rowsStock = getStockMaster().Select(string.Format(" symbol ='{0}' and series = '{1}' ", sSymbol, sSeries));

            NTier.CRUD.clsCRUD oCRUD_DailyPrice = _tier.getCRUD("tmp_bhavdata");


            //  iStockID = g.parseInt(rowsStock[0]["id"]);
            sDate1 = cmd.getStringValue("date1").Trim();
            //    iDaily_PriceID = oBLLStock.getDaily_PriceID(iStockID, sDate1);

            //cmd.setValue("mStockID", iStockID);
            cmd.setValue("id", 0);

            clsMsg msg = oCRUD_DailyPrice.save(cmd);

            return msg;

        }

        public clsMsg upload_bhavdata(clsCmd cmd)
        {
         
            
            DataTable t = null;

            var msg = getBhavDataInDataTable(cmd);
            if (msg.Validated) t = msg.Obj as DataTable;

            this._tier.getAdapter().exec("delete from tmp_bhavdata");
            foreach (DataRow r in t.Rows)
            {
                if (r["series"].ToString().ToUpper() != "EQ") continue;
                
                var cmd2 = new clsCmd();
                cmd2.AddValues(r);
                upload_bhavdata_row(cmd2);
            }

            return g.msg();
        }



        public clsMsg upload_bhavdata_old(clsCmd cmd)
        {

            if (cmd.Files.Count == 0)
                return g.msg("Please select csv file");


            ///////////////////////////////////////////////////////
            var oFile = cmd.Files[0];
            string sTmp = System.IO.Path.GetTempFileName();
            System.IO.File.WriteAllBytes(sTmp, oFile.Data);
            ///////////////////////////////////////////////////////

            DataTable tStockMaster = oBLLStock.getStockMaster();
            NTier.CRUD.clsCRUD oCRUD_DailyPrice = _tier.getCRUD("trDaily_Price");

            DataTable t = g.readCSV(sTmp);

            foreach (DataColumn col in t.Columns)
                col.ColumnName = col.ColumnName.Trim();



            foreach (DataRow r in t.Rows)
            {

                var cmd2 = new clsCmd();
                cmd2.AddValues(r);

                int iDaily_PriceID = 0;
                int iStockID = 0;
                string sDate1 = "";

                DataRow[] rowsStock = tStockMaster.Select(string.Format(" symbol ='{0}' and series = '{1}' ", r["symbol"].ToString().Trim(), r["series"].ToString().Trim()));

                if (rowsStock.Length > 0)
                {

                    iStockID = g.parseInt(rowsStock[0]["id"]);
                    sDate1 = r["date1"].ToString().Trim();
                    iDaily_PriceID = oBLLStock.getDaily_PriceID(iStockID, sDate1);

                    cmd2.setValue("mStockID", iStockID);
                    cmd2.setValue("id", iDaily_PriceID);

                    var msg = oCRUD_DailyPrice.save(cmd2);

                    if (msg.Validated == false)
                    {
                        Console.WriteLine("");
                    }

                }

            }

            System.IO.File.Delete(sTmp);

            return g.msg();

        }
    }
}
