using CPUFramework;
using CPUWindowsFormFramework;
using RecipeSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeWinForms
{
    public partial class frmCookbook : Form
    {
        DataTable dtcookbook;
        DataTable dtcookbookrecipe = new();
        BindingSource bindsource = new BindingSource();
        int Cookbookid = 0;
        string deletecolname = "deletecol";

        public frmCookbook()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            BtnDelete.Click += BtnDelete_Click;
            gRecipe.CellContentClick += GRecipe_CellContentClick;
            btnSaveRecipe.Click += BtnSaveRecipe_Click;
            this.Shown += FrmCookbook_Shown;
        }

        private string GetCookbookDesc()
        {
            string value = "New Cookbook";
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dtcookbook, "CookbookId");
            if (pkvalue > 0)
            {
                value = "Cookbook - " + SQLUtility.GetValueFromFirstRowAsString(dtcookbook, "CookbookName");
            }
            return value;
        }
        private void BtnSaveRecipe_Click(object? sender, EventArgs e)
        {
            SaveCookbookRecipe();
        }

        private void LoadCookbookRecipes(int Cookbookid)
        {
            dtcookbookrecipe = CookbookRecipe.LoadByCookbookId(Cookbookid);
            gRecipe.Columns.Clear();
            gRecipe.DataSource = dtcookbookrecipe;
            WindowsFormsUtility.AddComboboxToGrid(gRecipe, DataMaintenance.GetDataList("Recipe"), "Recipe", "RecipeName");
            WindowsFormsUtility.AddDeleteButtonToGrid(gRecipe, deletecolname);
            WindowsFormsUtility.FormatGridForEdit(gRecipe, "CookbookRecipe");
        }
        private void FrmCookbook_Shown(object? sender, EventArgs e)
        {

            LoadCookbookRecipes(Cookbookid);


        }
        private void GRecipe_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                DeleteCookbookRecipe(e.RowIndex);
            }
        }
        private void SaveCookbookRecipe()
        {
            try
            {
                CookbookRecipe.SaveTable(dtcookbookrecipe, Cookbookid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void DeleteCookbookRecipe(int rowIndex)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gRecipe, rowIndex, "RecipeCookbookId");
            if (id > 0)
            {
                try
                {
                    CookbookRecipe.Delete(id);
                    LoadCookbookRecipes(Cookbookid);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id < gRecipe.Rows.Count)
            {
                gRecipe.Rows.RemoveAt(rowIndex);
            }
        }
    
        public void LoadForm(int Cookbookidval)
        {
            Cookbookid = Cookbookidval;
            this.Tag = Cookbookid;
            dtcookbook = Cookbook.Load(Cookbookid);
            bindsource.DataSource = dtcookbook;
            if (Cookbookid == 0)
            {
                dtcookbook.Rows.Add();
            }
            DataTable dtusers = Recipe.GetUserList();
            WindowsFormsUtility.SetListBinding(lstUserName, dtusers, dtcookbook, "Users");
            WindowsFormsUtility.SetControlBindings(txtCookbookName, bindsource);
            WindowsFormsUtility.SetControlBindings(txtCookbookPrice, bindsource);
            WindowsFormsUtility.SetControlBindings(txtCookbookDateInserted, bindsource);
            WindowsFormsUtility.SetControlBindings(ckbIsActive, bindsource);
            this.Text = GetCookbookDesc();
            LoadCookbookRecipes(Cookbookid);
            SetButtonsEnabledBasedOnNewRecord();
            this.Show();
        }
        private void SetButtonsEnabledBasedOnNewRecord()
        {
            bool b = Cookbookid == 0 ? false : true;
            BtnDelete.Enabled = b;
            btnSaveRecipe.Enabled = b;
        }
        private void Delete()
        {
            var response = MessageBox.Show("Are you sure you want to delete this Cookbook?", "Cookbook", MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }

            Application.UseWaitCursor = true;
            try
            {
                Cookbook.Delete(dtcookbook);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cookbook");
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
                Cookbook.Save(dtcookbook);
                b = true;
                bindsource.ResetBindings(false);
                Cookbookid = SQLUtility.GetValueFromFirstRowAsInt(dtcookbook, "CookbookId");
                SetButtonsEnabledBasedOnNewRecord();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cookbook");
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
