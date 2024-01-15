using CPUWindowsFormFramework;
using RecipeSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeWinForms
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            btnRecipeList.Click += BtnRecipeList_Click;
            btnCookbookList.Click += BtnCookbookList_Click;
            btnMealList.Click += BtnMealList_Click;
            this.Activated += FrmDashboard_Activated;
        }
        private void FrmDashboard_Activated(object? sender, EventArgs e)
        {
            BindData();
        }
        private void BindData()
        {
            gOverview.DataSource = Overview.GetOverviewCounts();
            WindowsFormsUtility.FormatGridForSearchResults(gOverview, "Overview");
        }
        private void BtnMealList_Click(object? sender, EventArgs e)
        {
            ((frmMain)this.MdiParent).OpenForm(typeof(frmListMeals));
        }
        private void BtnCookbookList_Click(object? sender, EventArgs e)
        {
            ((frmMain)this.MdiParent).OpenForm(typeof(frmListCookbooks));
        }
        private void BtnRecipeList_Click(object? sender, EventArgs e)
        {
            ((frmMain)this.MdiParent).OpenForm(typeof(frmListRecipes));
        }
    }
}
