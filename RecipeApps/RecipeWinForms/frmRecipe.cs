using CPUFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        public frmRecipe()
        {
            InitializeComponent();
        }
        public void ShowForm(int recipeid)
        {
            string sql = "select RecipeName, RecipeCalories, RecipeDateDrafted, RecipeDatePublished, RecipeDateArchived, RecipeStatus, RecipePicture from Recipe where RecipeID= " + recipeid.ToString();
            DataTable dt = SQLUtility.GetDataTable(sql);
            lblName.DataBindings.Add("Text", dt, "RecipeName");
            txtCalories.DataBindings.Add("Text", dt, "RecipeCalories");
            txtDateDrafted.DataBindings.Add("Text", dt, "RecipeDateDrafted");
            txtDatePublished.DataBindings.Add("Text", dt, "RecipeDatePublished");
            txtDateArchived.DataBindings.Add("Text", dt, "RecipeDateArchived");
            txtStatus.DataBindings.Add("Text", dt, "RecipeStatus");
            txtPicture.DataBindings.Add("Text", dt, "RecipePicture");
            this.Show();
        }
    }
}
