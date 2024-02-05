namespace RecipeWinForms
{
    public partial class frmAutoCreateCookbook : Form
    {
        public frmAutoCreateCookbook()
        {
            InitializeComponent();
            btnAutoCreate.Click += BtnAutoCreate_Click;
            BindForm();
        }
        private void BtnAutoCreate_Click(object? sender, EventArgs e)
        {
            int userid = 0;
            if (lstUsers.SelectedValue != null && lstUsers.SelectedValue is int)
            {
                try
                {
                    userid = (int)lstUsers.SelectedValue;
                    DataTable dt = new DataTable();
                    dt = AutoCreateCookbook.AutoCreateCookbookByUserId(userid);
                    int id = SQLUtility.GetValueFromFirstRowAsInt(dt, "CookbookId");
                    if (this.MdiParent != null && this.MdiParent is frmMain)
                    {
                        ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbook), id);
                    }
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
                finally
                {
                    Cursor = Cursors.Default;
                }
            }
        }
        private void BindForm()
        {
            lstUsers.DataSource = RecipeSystem.Recipe.GetUserList();
            lstUsers.DisplayMember = "UserName";
            lstUsers.ValueMember = "UsersId";
        }
    }
}
