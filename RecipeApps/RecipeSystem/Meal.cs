namespace RecipeSystem
{
    public class Meal
    {
        public static DataTable GetMealSummary()
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("MealSummaryGet");
            return SQLUtility.GetDataTable(cmd);
        }
    }
}
