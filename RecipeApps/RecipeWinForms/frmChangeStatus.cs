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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RecipeWinForms
{
    
    public partial class frmChangeStatus : Form
    {
        DataTable dtrecipe;
        string recipename;
        string status;
        string datedrafted;
        string datepublished;
        string datearchived;
        int recipeid;
        BindingSource bindsource = new BindingSource();


        public frmChangeStatus(int recipeidval)
        {
            InitializeComponent();
            recipeid = recipeidval;
            LoadForm();
            GetRecipeValues();
            SetUpLabels();


        }
        private void GetRecipeValues()
        {
            recipeid = SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeId");
            if (recipeid > 0)
            {
                recipename = SQLUtility.GetValueFromFirstRowAsString(dtrecipe, "RecipeName");
        //        status = SQLUtility.GetValueFromFirstRowAsString(dtrecipe, "RecipeStatus");
                datedrafted = SQLUtility.GetValueFromFirstRowAsStringFromDate(dtrecipe, "RecipeDateDrafted");
                datepublished = SQLUtility.GetValueFromFirstRowAsStringFromDate(dtrecipe, "RecipeDatePublished");
                datearchived = SQLUtility.GetValueFromFirstRowAsStringFromDate(dtrecipe, "RecipeDateArchived");
            }
          
        }
        public void LoadForm()
        {
            dtrecipe = Recipe.Load(recipeid);
            bindsource.DataSource = dtrecipe;
            WindowsFormsUtility.SetControlBindings(lblRecipeName, bindsource);
            WindowsFormsUtility.SetControlBindings(lblRecipeDateDrafted, bindsource);
            WindowsFormsUtility.SetControlBindings(lblRecipeDatePublished, bindsource);
            WindowsFormsUtility.SetControlBindings(lblRecipeDateArchived, bindsource);
           // WindowsFormsUtility.SetControlBindings(lblRecipeStatus, bindsource);
        }
        private void SetUpLabels()
        {
            lblRecipeName.Text = recipename;
            //lblCurrentStatus.Text = lblCurrentStatus.Text + " " + status;
            ////string statusbtnname = "btn" + status;
           //foreach (System.Windows.Forms.Button btn in tblBtns.Controls)
           // {
           //     if (btn.Name == statusbtnname)
           //         btn.Enabled = false;
           // }
            //lblRecipeDateDrafted.Text = datedrafted;
            //lblRecipeDatePublished.Text = datepublished;
            //lblRecipeDateArchived.Text = datearchived;

        }
        private void Save()
        {
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Save(dtrecipe);
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
