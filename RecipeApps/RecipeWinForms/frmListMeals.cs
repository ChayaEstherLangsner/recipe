
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CPUWindowsFormFramework;
using System.Xml.Linq;
using RecipeSystem;

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

