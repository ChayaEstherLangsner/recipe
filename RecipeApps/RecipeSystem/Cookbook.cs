using CPUFramework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class Cookbook
    {
        public static DataTable GetCookookSummary()
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("CookbookSummaryGet");
            return SQLUtility.GetDataTable(cmd);
        }
        public static DataTable Load(int cookbookid)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = SQLUtility.GetSQLCommand("CookbookGet");
            cmd.Parameters["@CookbookId"].Value = cookbookid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }
        public static void Save(DataTable dtrecipe)
        {
            if (dtrecipe.Rows.Count == 0)
            {
                throw new Exception("Cannot call Cookbook Save method because there are no rows in the table");
            }

            DataRow r = dtrecipe.Rows[0];
            SQLUtility.SaveDataRow(r, "CookbookUpdate");
        }
        public static void Delete(DataTable dtcookbook)
        {
            int id = (int)dtcookbook.Rows[0]["CookbookId"];
            SqlCommand cmd = SQLUtility.GetSQLCommand("CookbookDelete");
            SQLUtility.SetParamValue(cmd, "@CookbookId", id);
            SQLUtility.ExecuteSQL(cmd);
        }

    }
}
