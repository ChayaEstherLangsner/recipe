
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
    public partial class frmListCookbooks : Form
    {
        public frmListCookbooks()
        {
            InitializeComponent();
            gMain.CellDoubleClick += gRecipe_CellDoubleClick;
            btnNew.Click += BtnNew_Click;
            this.Activated += FrmListCookbooks_Activated;
        }

        private void FrmListCookbooks_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            gMain.DataSource = Cookbook.GetCookookSummary();
            WindowsFormsUtility.FormatGridForSearchResults(gMain, "Cookbook");
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

