namespace RecipeWinForms
{
    public partial class frmListCookbooks : Form
    {
        public frmListCookbooks()
        {
            InitializeComponent();
            gMain.CellDoubleClick += gMain_CellDoubleClick;
            gMain.KeyDown += GMain_KeyDown;
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
        private void ShowCookbookForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = (int)gMain.Rows[rowindex].Cells["CookbookId"].Value;
            }
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbook), id);
            }
        }
        private void gMain_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowCookbookForm(e.RowIndex);
        }
        private void GMain_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && gMain.SelectedRows.Count > 0)
            {
                ShowCookbookForm(gMain.SelectedRows[0].Index);
                e.SuppressKeyPress = true;
            }
        }
        private void BtnNew_Click(object? sender, EventArgs e)
        {
            ShowCookbookForm(-1);
        }
    }
}

