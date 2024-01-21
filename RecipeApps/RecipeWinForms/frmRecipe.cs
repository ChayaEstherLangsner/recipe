using CPUFramework;
using CPUWindowsFormFramework;
using RecipeSystem;
using System.Data;

namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        DataTable dtrecipe;
        DataTable dtRecipeIngredient = new();
        DataTable dtRecipeStep = new();
        BindingSource bindsource = new BindingSource();
        int recipeid = 0;
        string deletecolname = "deletecol";
        public frmRecipe()
        { 
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            BtnDelete.Click += BtnDelete_Click;
            gIngredient.CellContentClick += GIngredient_CellContentClick;
            gSteps.CellContentClick += GSteps_CellContentClick;
            btnSaveIngredient.Click += BtnSaveIngredient_Click;
            BtnSaveSteps.Click += BtnSaveSteps_Click;
            btnChangeStatus.Click += BtnChangeStatus_Click;
            this.Activated += FrmRecipe_Activated;
        }
        private void FrmRecipe_Activated(object? sender, EventArgs e)
        {
            LoadRecipeSteps(recipeid);
            LoadRecipeIngredients(recipeid);
        }
        private string GetRecipeDesc()
        {
            string value = "New Recipe";
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeId");
            if (pkvalue > 0)
            {
                value = "Recipe - " + SQLUtility.GetValueFromFirstRowAsString(dtrecipe, "RecipeName"); 
            }
            return value;
        }
        private void BtnSaveIngredient_Click(object? sender, EventArgs e)
        {
            SaveRecipeIngredient();
        }
        private void BtnSaveSteps_Click(object? sender, EventArgs e)
        {
            SaveRecipeStep();
        }
        private void LoadRecipeIngredients(int recipeid)
        {
            dtRecipeIngredient = RecipeIngredient.LoadByRecipeId(recipeid);
            gIngredient.Columns.Clear();
            gIngredient.DataSource = dtRecipeIngredient;
            WindowsFormsUtility.AddComboboxToGrid(gIngredient, DataMaintenance.GetDataList("Ingredient"), "Ingredient", "IngredientName");
            WindowsFormsUtility.AddComboboxToGrid(gIngredient, DataMaintenance.GetDataList("Measurement"), "Measurement", "MeasurementType");
            WindowsFormsUtility.AddDeleteButtonToGrid(gIngredient, deletecolname);
            WindowsFormsUtility.FormatGridForEdit(gIngredient, "RecipeIngredient");
        }
        private void LoadRecipeSteps(int recipeid)
        {
            dtRecipeStep = RecipeStep.LoadByRecipeId(recipeid);
            gSteps.Columns.Clear();
            gSteps.DataSource = dtRecipeStep;
            WindowsFormsUtility.AddDeleteButtonToGrid(gSteps, deletecolname);
            WindowsFormsUtility.FormatGridForEdit(gSteps, "RecipeStep");
        }
        private void GIngredient_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8 && e.RowIndex != -1 )
            {
                var response = MessageBox.Show("Are you sure you want to delete this ingredient?", "Ingredients", MessageBoxButtons.YesNo);
                if (response == DialogResult.Yes)
                {
                    DeleteRecipeIngredient(e.RowIndex);
                }
             
            }
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
            int id = WindowsFormsUtility.GetIdFromGrid(gIngredient, rowIndex, "RecipeIngredientId");
            if (id > 0)
            {
                try
                {
                    RecipeIngredient.Delete(id);
                    LoadRecipeIngredients(recipeid);
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
        private void GSteps_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1 )
            {
                var response = MessageBox.Show("Are you sure you want to delete this step?", "Steps", MessageBoxButtons.YesNo);
                if (response == DialogResult.Yes)
                {
                    DeleteRecipeStep(e.RowIndex);
                }
            }
        }
        private void SaveRecipeStep()
        {
            try
            {
                RecipeStep.SaveTable(dtRecipeStep, recipeid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }
        private void DeleteRecipeStep(int rowIndex)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gSteps, rowIndex, "RecipeStepId");
            if (id > 0)
            {
                try
                {
                    RecipeStep.Delete(id);
                    LoadRecipeSteps(recipeid);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id < gSteps.Rows.Count)
            {
                gSteps.Rows.RemoveAt(rowIndex);
            }
        }
        public void LoadForm(int recipeidval)
        {
            recipeid = recipeidval;
            this.Tag = recipeid;
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
            WindowsFormsUtility.SetControlBindings(txtRecipeStatus, bindsource);
            WindowsFormsUtility.SetControlBindings(txtRecipeDateDrafted, bindsource);
            WindowsFormsUtility.SetControlBindings(txtRecipeDatePublished, bindsource);
            WindowsFormsUtility.SetControlBindings(txtRecipeDateArchived, bindsource);
            this.Text = GetRecipeDesc();
            SetButtonsEnabledBasedOnNewRecord();
            this.Show();
        }
        private void SetButtonsEnabledBasedOnNewRecord()
        {
            bool b = recipeid == 0 ? false : true;
            BtnDelete.Enabled = b;
            btnSaveIngredient.Enabled = b;
            btnChangeStatus.Enabled = b;
            BtnSaveSteps.Enabled = b;
        }
        private void BtnChangeStatus_Click(object? sender, EventArgs e)
        {
            ((frmMain)this.MdiParent).OpenForm(typeof(frmChangeStatus), recipeid);
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
        private bool Save()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Save(dtrecipe);
                b = true;
                bindsource.ResetBindings(false);
                recipeid = SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeId");
                SetButtonsEnabledBasedOnNewRecord();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Recipe");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
            return b;
        }
        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
    }
}
