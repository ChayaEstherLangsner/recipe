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
    public class AutoCreateCookbook
    {
        public static DataTable AutoCreateCookbookByUserId(int userid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("AutoCreateCookbook");
            cmd.Parameters["@UserId"].Value = userid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }
    }
}
