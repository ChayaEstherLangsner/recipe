using CPUFramework;
using CPUWindowsFormFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        DataTable dtrecipe;
        public frmRecipe()
        { 
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            BtnDelete.Click += BtnDelete_Click;
        }

        public void ShowForm(int recipeid)
        {
            string sql = "select s.CuisineType, u.UserName, r.* from recipe r join Cuisine s on s.CuisineID = r.CuisineID join Users u on u.UsersID = r.UsersID where RecipeID= " + recipeid.ToString();
            dtrecipe = SQLUtility.GetDataTable(sql);
            if (recipeid == 0)
            {
                dtrecipe.Rows.Add();
            }
            DataTable dtusers = SQLUtility.GetDataTable("select * from Users");
            DataTable dtcuisine = SQLUtility.GetDataTable("select * from Cuisine");
            WindowsFormsUtility.SetListBinding(lstUserName, dtusers, dtrecipe, "Users");
            WindowsFormsUtility.SetListBinding(lstCuisineType, dtcuisine, dtrecipe, "Cuisine");
            WindowsFormsUtility.SetControlBindings(txtRecipeName, dtrecipe);
            WindowsFormsUtility.SetControlBindings(txtRecipeCalories, dtrecipe);
            WindowsFormsUtility.SetControlBindings(dtpRecipeDateDrafted, dtrecipe);
            WindowsFormsUtility.SetControlBindings(txtRecipeDatePublished, dtrecipe);
            WindowsFormsUtility.SetControlBindings(txtRecipeDateArchived, dtrecipe);
            this.Show();
        }
        private void Delete()
        {
            int id = (int)dtrecipe.Rows[0]["RecipeID"];
            string sql = "delete recipe where RecipeID = " + id;
            Debug.Print(sql);
            SQLUtility.ExecuteSQL(sql);
            this.Close();
        }
        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }
        private void Save()
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
                    $" where RecipeID = {r["RecipeID"]}") ;
            }
            else
            {
                sql = "insert recipe(UsersID, CuisineID, RecipeName, RecipeCalories, RecipeDateDrafted)";
                sql += $"select '{r["UsersID"]}', {r["CuisineID"]}, '{r["RecipeName"]}', '{r["RecipeCalories"]}', '{r["RecipeDateDrafted"]}'";
            }
            Debug.Print(sql);
            SQLUtility.ExecuteSQL(sql);
            this.Close();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
    }
}
