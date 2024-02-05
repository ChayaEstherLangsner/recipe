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
