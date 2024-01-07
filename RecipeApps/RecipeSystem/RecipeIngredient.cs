﻿using CPUFramework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class RecipeIngredient
    {
        public static DataTable LoadByRecipeId(int recipeid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeIngredientGet");
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
            SQLUtility.SaveDataTable(dt, "RecipeIngredientUpdate");
        }
        public static void Delete(int ingredientid)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeIngredientDelete");
            cmd.Parameters["@IngredientId"].Value = ingredientid;
            SQLUtility.ExecuteSQL(cmd);
        }
    }
}