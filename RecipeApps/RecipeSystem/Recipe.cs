using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPUFramework;

namespace RecipeSystem
{
    public class Recipe
    {
        public static DataTable SearchforRecipes(string RecipeName)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeGet");
            cmd.Parameters["@RecipeName"].Value = RecipeName;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }
        public static DataTable Load(int recipeid)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeGet");
            cmd.Parameters["@RecipeID"].Value = recipeid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }
        public static DataTable GetUserList()
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("UsersGet");
            cmd.Parameters["@All"].Value = 1;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }
        public static DataTable GetCuisineList()
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("CuisineGet");
            cmd.Parameters["@All"].Value = 1;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }
        public static void Save(DataTable dtrecipe)
        {
            DataRow r = dtrecipe.Rows[0];
            int id = (int)r["RecipeID"];
            string sql = "";
            if (id > 0)
            {
                sql = string.Join(Environment.NewLine, "update recipe set",
                    $"UsersID = '{r["UsersID"]}',",
                    $"CuisineID = '{r["CuisineID"]}',",
                    $"RecipeName = '{r["RecipeName"]}',",
                    $"RecipeCalories = '{r["RecipeCalories"]}',",
                    $"RecipeDateDrafted = '{r["RecipeDateDrafted"]}'",
                    $" where RecipeID = {r["RecipeID"]}");
            }
            else
            {
                sql = "insert recipe(UsersID, CuisineID, RecipeName, RecipeCalories, RecipeDateDrafted)";
                sql += $"select '{r["UsersID"]}', {r["CuisineID"]}, '{r["RecipeName"]}', '{r["RecipeCalories"]}', '{r["RecipeDateDrafted"]}'";
            }
            Debug.Print(sql);
            SQLUtility.ExecuteSQL(sql);
        }
        public static void Delete(DataTable dtrecipe)
        {
            int id = (int)dtrecipe.Rows[0]["RecipeID"];
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeDelete");
            SQLUtility.SetParamValue(cmd, "@RecipeID", id);
            SQLUtility.ExecuteSQL(cmd);
        }

    }
}
