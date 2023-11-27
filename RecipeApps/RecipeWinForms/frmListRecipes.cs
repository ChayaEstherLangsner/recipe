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
using CPUWindowsFormFramework;
using System.Xml.Linq;
using RecipeSystem;

namespace RecipeWinForms
{
    public partial class frmListRecipes : Form
    {
        public frmListRecipes()
        {
            InitializeComponent();
            gMain.CellDoubleClick += gRecipe_CellDoubleClick;
            btnNew.Click += BtnNew_Click;
            this.Activated += FrmListRecipes_Activated;
        }

        private void BindData()
        {
                gMain.DataSource = Recipe.GetRecipeSummary();
                WindowsFormsUtility.FormatGridForSearchResults(gMain, "Recipe");
        }

        private void FrmListRecipes_Activated(object? sender, EventArgs e)
        {
            BindData();
        }


        private void ShowRecipeForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = (int)gMain.Rows[rowindex].Cells["RecipeID"].Value;
            }
            frmRecipe frm = new frmRecipe();
            frm.ShowForm(id);
        }
        private void gRecipe_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowRecipeForm(e.RowIndex);
        }

        private void BtnNew_Click(object? sender, EventArgs e)
        {
            ShowRecipeForm(-1);
        }

    }

}

