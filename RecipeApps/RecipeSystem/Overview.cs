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
    public class Overview
    {
        public static DataTable GetOverviewCounts()
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("OverviewCountGet");
            return SQLUtility.GetDataTable(cmd);
        }
    }
}
