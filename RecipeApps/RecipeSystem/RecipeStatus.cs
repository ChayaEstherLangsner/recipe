namespace RecipeSystem
{
    public class RecipeStatus
    {
        public static void UpdateStatus(int recipeid, string status)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("CurrentRecipeStatusUpdate");
            cmd.Parameters["@RecipeId"].Value = recipeid;
            cmd.Parameters["@Status"].Value = status;
            SQLUtility.ExecuteSQL(cmd);
        }
    }
}
