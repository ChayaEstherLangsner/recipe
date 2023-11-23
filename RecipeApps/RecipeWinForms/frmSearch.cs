
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
    public partial class frmSearch : Form
    {
        string formtype = "";
        public frmSearch(string datasource)
        {
            InitializeComponent();
            gMain.CellDoubleClick += gRecipe_CellDoubleClick;
            btnNew.Click += BtnNew_Click;
            FormatGrid();
            formtype = datasource;
            SetBtnText(formtype);
            this.Activated += FrmSearch_Activated;
        }
        private void BindData()
        {
            if (formtype == "recipe")
            {
                gMain.DataSource = Recipe.GetRecipeSummary();
                WindowsFormsUtility.FormatGridForSearchResults(gMain, "Recipe");
            }
        }

        private void FrmSearch_Activated(object? sender, EventArgs e)
        {
            BindData(); 
        }

        private void SetBtnText(string datasource)
        { btnNew.Text = (datasource == "recipe") ? "New Recipe" : "New Cookbook"; }

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
        private void FormatGrid()
        {
            gMain.AllowUserToAddRows = false; 
            gMain.ReadOnly = true;
            gMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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

