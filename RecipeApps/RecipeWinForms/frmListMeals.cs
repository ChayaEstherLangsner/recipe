
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
    public partial class frmListMeals : Form
    {
        public frmListMeals()
        {
            InitializeComponent();
            FormatGrid();
            this.Activated += FrmSearch_Activated;
        }
        private void BindData()
        {
                gMain.DataSource = Recipe.GetRecipeSummary();
                WindowsFormsUtility.FormatGridForSearchResults(gMain, "Meal");
        }

        private void FrmSearch_Activated(object? sender, EventArgs e)
        {
            BindData(); 
        }
        private void FormatGrid()
        {
            gMain.AllowUserToAddRows = false; 
            gMain.ReadOnly = true;
            gMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

    }

}

