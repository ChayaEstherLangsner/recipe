
using CPUWindowsFormFramework;
using RecipeSystem;
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
            dtrecipe = Recipe.Load(recipeid);
            if (recipeid == 0)
            {
                dtrecipe.Rows.Add();
            }
            DataTable dtusers = Recipe.GetUserList();
            DataTable dtcuisine = Recipe.GetCuisineList();
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
            Recipe.Delete(dtrecipe);
            this.Close();
        }
        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }
        private void Save()
        {
            Recipe.Save(dtrecipe);
            this.Close();
           
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
    }
}
