namespace RecipeWinForms
{
    public partial class frmCloneRecipe : Form
    {
        public frmCloneRecipe()
        {
            InitializeComponent();
            btnClone.Click += BtnClone_Click;
            BindForm();
        }
        private void BtnClone_Click(object? sender, EventArgs e)
        {
            int recipeid = 0;
            if (lstRecipe.SelectedValue != null && lstRecipe.SelectedValue is int)
            {
                try
                {
                    recipeid = (int)lstRecipe.SelectedValue;
                    DataTable dt = new DataTable();
                    dt = CloneRecipe.CloneRecipeById(recipeid);
                    int id = SQLUtility.GetValueFromFirstRowAsInt(dt, "RecipeId");
                    if (this.MdiParent != null && this.MdiParent is frmMain)
                    {
                        ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipe), id);
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
            lstRecipe.DataSource = RecipeSystem.CloneRecipe.GetRecipeList();
            lstRecipe.DisplayMember = "RecipeName";
            lstRecipe.ValueMember = "RecipeId";
        }
    }
}
