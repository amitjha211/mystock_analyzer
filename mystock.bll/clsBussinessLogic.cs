using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using NTier;
using NTier.sqlbuilder;

namespace mystock.bll
{

    public class clsBussinessLogic : NTier.Request.clsRequest
    {
        public override clsMsg validate(clsCmd cmd)
        {
            throw new NotImplementedException();
        }


        internal DataTable getStockMaster()
        {
            DataTable t = _tier.getAdapter().getData("select * from mStock");
            return t;
        }

        public int getDaily_PriceID(int iStockID, string sDate)
        {
            int trDaily_Price_id = 0;
            var cmd = new clsCmd();

            cmd.SQL = "select id from trDaily_Price where mStockID = @mStockID and date1 = @date1 ";
            cmd.setValue("mStockID", iStockID);
            cmd.setValue("date1", sDate);

            trDaily_Price_id = g.parseInt(_tier.getAdapter().execScalar(cmd));
            return trDaily_Price_id;
        }



        public clsMsg update_index_info(clsCmd cmd)
        {

            if (cmd.Files.Count == 0)
                return g.msg("Please select csv file");

            ///////////////////////////
            var oFile = cmd.Files[0];
            string sTmp = System.IO.Path.GetTempFileName();

            System.IO.File.WriteAllBytes(sTmp, oFile.Data);
            /////////////////////////////////////

            DataTable t = g.readCSV(sTmp);

            foreach (DataColumn col in t.Columns)
                col.ColumnName = col.ColumnName.Trim();


            int iIndexID = cmd.getIntValue("mIndexID");

            for (int i = 1; i < t.Rows.Count; i++)
            {
                DataRow r = t.Rows[i];
                string sSymbol = r["symbol"].ToString();
                var cmd2 = new clsCmd();
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.SQL = "mIndex_Upload";
                cmd2.setValue("mIndexID", iIndexID);
                cmd2.setValue("symbol", sSymbol);
                _tier.getAdapter().exec(cmd2);
            }
            return g.msg("");
        }


        




        public clsMsg stock_data(clsCmd cmd)
        {
            StringBuilder sb1 = new StringBuilder();

            sb1.Append("select * from vtrDaily_Price where 1=1 ");

            int iDeliv_Per_Above = cmd.getIntValue("deliv_per_above");
            int ino_of_trades = cmd.getIntValue("no_of_trades_above");
            int ideliv_qty_above = cmd.getIntValue("deliv_qty_above");

            int iIndexID = cmd.getIntValue("mIndexID");

            if (iIndexID > 0)
            {
                sb1.AppendFormat(" and mStockID in (select mStockID  from  mIndexStock where mIndexID = " + iIndexID + ")");
            }

            if (iDeliv_Per_Above > 0)
            {
                sb1.AppendFormat(" and deliv_per > {0} ", iDeliv_Per_Above);
            }

            if (ino_of_trades > 0)
            {
                sb1.AppendFormat(" and no_of_trades > {0} ", ino_of_trades);
            }

            if (ideliv_qty_above > 0)
            {
                sb1.AppendFormat(" and deliv_qty > {0} ", ideliv_qty_above);
            }

        

            cmd.SQL = sqlUtility.joinWhereCondition(sb1.ToString(), cmd, "deliv_per_above", "no_of_trades_above", "deliv_qty_above", "mIndexID");

            DataTable t = _tier.getAdapter().getData(cmd);

            return g.msg("", t);
        }

        public clsMsg stock_data_tmp(clsCmd cmd)
        {
            StringBuilder sb1 = new StringBuilder();

            sb1.Append("select * from vtmp_bhavdata where 1=1 ");

            int iDeliv_Per_Above = cmd.getIntValue("deliv_per_above");
            int ino_of_trades = cmd.getIntValue("no_of_trades_above");
            int ideliv_qty_above = cmd.getIntValue("deliv_qty_above");

            string sIndex_name = cmd.getStringValue("index_name");

            if (!string.IsNullOrWhiteSpace(sIndex_name))
            {
                sb1.AppendFormat(" and symbol in (select company_code from mIndex where index_name = '" + sIndex_name + "')");
            }

            if (iDeliv_Per_Above > 0)
            {
                sb1.AppendFormat(" and deliv_per > {0} ", iDeliv_Per_Above);
            }

            if (ino_of_trades > 0)
            {
                sb1.AppendFormat(" and no_of_trades > {0} ", ino_of_trades);
            }

            if (ideliv_qty_above > 0)
            {
                sb1.AppendFormat(" and deliv_qty > {0} ", ideliv_qty_above);
            }

            cmd.SQL = sqlUtility.joinWhereCondition(sb1.ToString(), cmd, "deliv_per_above", "no_of_trades_above", "deliv_qty_above", "index_name");

            DataTable t = _tier.getAdapter().getData(cmd);

            return g.msg("", t);
        }

    }
}
