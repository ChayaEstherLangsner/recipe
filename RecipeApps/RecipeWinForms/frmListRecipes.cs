namespace RecipeWinForms
{
    public partial class frmListRecipes : Form
    {
        public frmListRecipes()
        {
            InitializeComponent();
            gMain.CellDoubleClick += gRecipe_CellDoubleClick;
            gMain.KeyDown += GMain_KeyDown;
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
                id = (int)gMain.Rows[rowindex].Cells["RecipeId"].Value;
            }
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipe), id);
            }
        }
        private void gRecipe_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowRecipeForm(e.RowIndex);
        }
        private void GMain_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && gMain.SelectedRows.Count > 0)
            {
                ShowRecipeForm(gMain.SelectedRows[0].Index);
                e.SuppressKeyPress = true;
            }
        }
        private void BtnNew_Click(object? sender, EventArgs e)
        {
            ShowRecipeForm(-1);
        }
    }
}

