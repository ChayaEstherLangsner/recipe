namespace RecipeWinForms
{
    public partial class frmListMeals : Form
    {
        public frmListMeals()
        {
            InitializeComponent();
            this.Activated += FrmListMeals_Activated;
        }
        private void BindData()
        {
            gMain.DataSource = Meal.GetMealSummary();
            WindowsFormsUtility.FormatGridForSearchResults(gMain, "Meal");
        }
        private void FrmListMeals_Activated(object? sender, EventArgs e)
        {
            BindData();
        }
    }
}

