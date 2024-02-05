namespace RecipeSystem
{
    public class RecipeStep
    {
        public static DataTable LoadByRecipeId(int recipeid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeStepGet");
            cmd.Parameters["@RecipeId"].Value = recipeid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }
        public static void SaveTable(DataTable dt, int recipeid)
        {
            foreach (DataRow r in dt.Select("", "", DataViewRowState.Added))
            {
                r["RecipeId"] = recipeid;
            }
            SQLUtility.SaveDataTable(dt, "RecipeStepUpdate");
        }
        public static void Delete(int ingredientid)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeStepDelete");
            cmd.Parameters["@StepId"].Value = ingredientid;
            SQLUtility.ExecuteSQL(cmd);
        }
    }
}

