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
        
    }
}
