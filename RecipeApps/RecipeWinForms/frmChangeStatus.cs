namespace RecipeWinForms
{
    public partial class frmChangeStatus : Form
    {
        DataTable dtrecipe;
        string status;
        int recipeid; 
        BindingSource bindsource = new BindingSource();
        public frmChangeStatus(int recipeidval)
        {
            InitializeComponent();
            recipeid = recipeidval;
            LoadForm();
            DisableButtons();
            btnDrafted.Click += Btn_Click;
            btnPublished.Click += Btn_Click;
            btnArchived.Click += Btn_Click;
        }
        public void LoadForm()
        {
            dtrecipe = Recipe.Load(recipeid);
            bindsource.DataSource = dtrecipe;
            status = SQLUtility.GetValueFromFirstRowAsString(dtrecipe, "RecipeStatus");
            WindowsFormsUtility.SetControlBindings(lblRecipeName, bindsource);
            WindowsFormsUtility.SetControlBindings(lblRecipeDateDrafted, bindsource);
            WindowsFormsUtility.SetControlBindings(lblRecipeDatePublished, bindsource);
            WindowsFormsUtility.SetControlBindings(lblRecipeDateArchived, bindsource);
            WindowsFormsUtility.SetControlBindings(lblRecipeStatus, bindsource);
        }
        private void DisableButtons()
        {
            string statusbtnname = "btn" + status;
            foreach (System.Windows.Forms.Button btn in tblBtns.Controls)
            {
                if (btn.Name == statusbtnname)
                    btn.Enabled = false;
                else 
                { btn.Enabled = true; }
            }
        }
        private void Btn_Click(object? sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            status =  btn.Name.Substring(3);
            Save();
        }
        private void Save()
        {
            var result = MessageBox.Show("Are you sure you want to change this recipe to " +status+"?", "Status Change", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                Application.UseWaitCursor = true;
                try
                {
                    RecipeStatus.UpdateStatus(recipeid, status);
                    dtrecipe = Recipe.Load(recipeid);
                    bindsource.DataSource = dtrecipe;
                    DisableButtons();
                    if (this.MdiParent != null && this.MdiParent is frmMain)
                    {
                        ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipe), recipeid);
                    }
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Recipe");
                }
                finally
                {
                    Application.UseWaitCursor = false;
                }
            }
        }
    }
}
