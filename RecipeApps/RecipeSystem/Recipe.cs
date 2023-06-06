using System;
using System.Collections.Generic;
using System.Data;
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
            string sql = "select RecipeID, RecipeName from Recipe where RecipeName like '%" + RecipeName + "%'";
            DataTable dt = SQLUtility.GetDataTable(sql);
            return dt;
        }
        public static DataTable Load(int recipeid)
        {
            string sql = "select s.CuisineType, u.UserName, r.* from recipe r join Cuisine s on s.CuisineID = r.CuisineID join Users u on u.UsersID = r.UsersID where RecipeID= " + recipeid.ToString();
            return SQLUtility.GetDataTable(sql);
        }
        public static DataTable GetUserList()
        {
            return SQLUtility.GetDataTable("select * from Users");

            
        }
        public static DataTable GetCuisineList()
        {
            return SQLUtility.GetDataTable("select * from Cuisine");
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
            string sql = "delete recipe where RecipeID = " + id;
            Debug.Print(sql);
            SQLUtility.ExecuteSQL(sql);
        }

    }
}
