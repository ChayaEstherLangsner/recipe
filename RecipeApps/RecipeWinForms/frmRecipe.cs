using CPUWindowsFormFramework;
using RecipeSystem;
using System.Data;

namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        DataTable dtrecipe;
        DataTable dtRecipeIngredient = new();
        BindingSource bindsource = new BindingSource();
        int recipeid = 0;
        string deletecolname = "deletecol";
        
        public frmRecipe()
        { 
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            BtnDelete.Click += BtnDelete_Click;
            gIngredient.CellContentClick += GIngredient_CellContentClick;
            btnSaveIngredient.Click += BtnSaveIngredient_Click;
            //txtRecipeName.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
        }

        private void BtnSaveIngredient_Click(object? sender, EventArgs e)
        {
            SaveRecipeIngredient();
        }

        private void LoadRecipeIngredients()
        {
            dtRecipeIngredient = RecipeIngredient.LoadByRecipeId(recipeid);
            gIngredient.Columns.Clear();
            gIngredient.DataSource = dtRecipeIngredient;
            WindowsFormsUtility.AddComboboxToGrid(gIngredient, DataMaintenance.GetDataList("Ingredient"), "Ingredient", "IngredientName");
            WindowsFormsUtility.AddComboboxToGrid(gIngredient, DataMaintenance.GetDataList("Measurement"), "Measurement", "MeasurementType");
            WindowsFormsUtility.AddDeleteButtonToGrid(gIngredient, deletecolname);
            WindowsFormsUtility.FormatGridForEdit(gIngredient, "RecipeIngredient");
        }

        private void GIngredient_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            DeleteRecipeIngredient(e.RowIndex);
        }
        private void SaveRecipeIngredient()
        {
            try
            {
                RecipeIngredient.SaveTable(dtRecipeIngredient, recipeid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void DeleteRecipeIngredient(int rowIndex)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gIngredient, rowIndex, "RecipeIngredientID");
            if (id > 0)
            {
                try
                {
                    RecipeIngredient.Delete(id);
                    LoadRecipeIngredients();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id < gIngredient.Rows.Count)
            {
                gIngredient.Rows.RemoveAt(rowIndex);
            }
        }
        public void ShowForm(int recipeid)
        {
            dtrecipe = Recipe.Load(recipeid);
            bindsource.DataSource = dtrecipe;
            if (recipeid == 0)
            {
                dtrecipe.Rows.Add();
            }
            DataTable dtusers = Recipe.GetUserList();
            DataTable dtcuisine = Recipe.GetCuisineList();
            WindowsFormsUtility.SetListBinding(lstUserName, dtusers, dtrecipe, "Users");
            WindowsFormsUtility.SetListBinding(lstCuisineType, dtcuisine, dtrecipe, "Cuisine");
            WindowsFormsUtility.SetControlBindings(txtRecipeName, bindsource);
            WindowsFormsUtility.SetControlBindings(txtRecipeCalories, bindsource);
            //WindowsFormsUtility.SetControlBindings(txtDateDrafted, bindsource);
            //WindowsFormsUtility.SetControlBindings(txtDatePublished, bindsource);
            //WindowsFormsUtility.SetControlBindings(txtDateArchived, bindsource);
            LoadRecipeIngredients();
            this.Show();
        }
        private void Delete()
        {
            var response = MessageBox.Show("Are you sure you want to delete this Recipe?", "Recipe", MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }

            Application.UseWaitCursor = true;
            try
            {
                Recipe.Delete(dtrecipe);
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
        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }
        private void Save()
        {
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Save(dtrecipe);

                bindsource.ResetBindings(false);
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

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
    }
}
