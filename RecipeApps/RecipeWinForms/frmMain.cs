﻿namespace RecipeWinForms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            mnuDashboard.Click += MnuDashboard_Click;
            mnuRecipeList.Click += MnuRecipeList_Click;
            mnuCookbookList.Click += MnuCookbookList_Click;
            mnuMealList.Click += MnuMealList_Click;
            mnuNewRecipe.Click += MnuNewRecipe_Click;
            mnuNewCookbook.Click += MnuNewCookbook_Click;
            mnuEditData.Click += MnuEditData_Click;
            mnuCloneRecipe.Click += MnuCloneRecipe_Click;
            mnuAutoCreate.Click += MnuAutoCreate_Click;
            mnuWindowTile.Click += MnuWindowTile_Click;
            mnuWindowCascade.Click += MnuWindowCascade_Click;
            this.Shown += FrmMain_Shown;
        }
        private void MnuAutoCreate_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmAutoCreateCookbook));
        }
        private void MnuCloneRecipe_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCloneRecipe));
        }
        private void MnuEditData_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDataMaintenance));
        }
        private void MnuNewCookbook_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCookbook));
        }
        private void MnuNewRecipe_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmRecipe));
        }
        private void MnuDashboard_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDashboard));
        }
        private void MnuMealList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmListMeals));
        }
        private void MnuCookbookList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmListCookbooks));
        }
        private void MnuRecipeList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmListRecipes));
        }
        private void FrmMain_Shown(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDashboard));
        }
        public void OpenForm(Type frmtype, int pkvalue = 0)
        {
            bool b = WindowsFormsUtility.IsFormOpen(frmtype);
            if (b == false)
            {
                Form? newfrm = null;
                if (frmtype == typeof(frmListRecipes))
                {
                    frmListRecipes f = new frmListRecipes();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmListCookbooks))
                {
                    frmListCookbooks f = new frmListCookbooks();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmListMeals))
                {
                    frmListMeals f = new frmListMeals();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmDashboard))
                {
                    frmDashboard f = new frmDashboard();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmDataMaintenance))
                {
                    frmDataMaintenance f = new frmDataMaintenance();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmCloneRecipe))
                {
                    frmCloneRecipe f = new frmCloneRecipe();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmAutoCreateCookbook))
                {
                    frmAutoCreateCookbook f = new frmAutoCreateCookbook();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmRecipe))
                {
                    frmRecipe f = new frmRecipe();
                    newfrm = f;
                    f.LoadForm(pkvalue);
                }
                else if (frmtype == typeof(frmCookbook))
                {
                    frmCookbook f = new frmCookbook();
                    newfrm = f;
                    f.LoadForm(pkvalue);
                }
                else if (frmtype == typeof(frmChangeStatus))
                {
                    frmChangeStatus f = new frmChangeStatus(pkvalue);
                    newfrm = f;
                }
                if (newfrm != null )
                {
                    newfrm.MdiParent = this;
                    newfrm.WindowState = FormWindowState.Maximized;
                    newfrm.FormClosed += Frm_FormClosed;
                    newfrm.TextChanged += Newfrm_TextChanged;
                    newfrm.Show();
                }
                WindowsFormsUtility.SetUpNav(tsMain);
            }
        }
        private void Newfrm_TextChanged(object? sender, EventArgs e)
        {
            WindowsFormsUtility.SetUpNav(tsMain);
        }
        private void Frm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            WindowsFormsUtility.SetUpNav(tsMain);
        }
        private void MnuWindowCascade_Click(object? sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }
        private void MnuWindowTile_Click(object? sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
