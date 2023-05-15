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
            WindowsFormsUtility.SetListBinding(lstUser, dtusers, dtrecipe, "Users");
            WindowsFormsUtility.SetListBinding(lstCuisine, dtcuisine, dtrecipe, "Cuisine");
            WindowsFormsUtility.SetControlBindings(txtName, dtrecipe);
            WindowsFormsUtility.SetControlBindings(txtCalories, dtrecipe);
            WindowsFormsUtility.SetControlBindings(dtpDateDrafted, dtrecipe);
            WindowsFormsUtility.SetControlBindings(dtpDatePublished, dtrecipe);
            WindowsFormsUtility.SetControlBindings(dtpDateArchived, dtrecipe);
            WindowsFormsUtility.SetControlBindings(txtStatus, dtrecipe);
            WindowsFormsUtility.SetControlBindings(txtPicture, dtrecipe);
            this.Show();
        }
        private void Delete()
        {
            int id = (int)dtrecipe.Rows[0]["RecipeID"];
            string sql = "delete recipe where RecipeID = " + id;
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
                    $"RecipeDateDrafted = '{r["RecipeDateDrafted"]}',",
                    $"RecipeDatePublished = '{r["RecipeDatePublished"]}'",
                    $"RecipeDateArchived = '{r["RecipeDateArchived"]}'",
                    $"RecipeStatus = '{r["RecipeStatus"]}'",
                    $"RecipePicture = '{r["RecipePicture"]}'",
                    $" where RecipeID = {r["RecipeID"]}");
            }
            else
            {
                sql = "insert recipe(UsersID, CuisineID, RecipeName, RecipeCalories, RecipeDateDrafted, RecipeDatePublished, RecipeDateArchived, RecipeStatus, RecipePicture)";
                sql += $"select '{r["UsersID"]}', {r["CuisineID"]}, '{r["RecipeName"]}', '{r["RecipeCalories"]}', '{r["RecipeDateDrafted"]}', '{r["RecipeDatePublished"]}', '{r["RecipeDateArchived"]}', '{r["RecipeStatus"]}', '{r["RecipePicture"]}'";
            }
            SQLUtility.ExecuteSQL(sql);
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
    }
}
