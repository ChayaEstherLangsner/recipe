﻿using CPUWindowsFormFramework;
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
    public partial class frmMain : Form
    {
        string listtype = "";
        public frmMain()
        {
            InitializeComponent();
            mnuRecipeList.Click += MnuRecipeList_Click;
            mnuWindowTile.Click += MnuWindowTile_Click;
            mnuWindowCascade.Click += MnuWindowCascade_Click;
            this.Shown += FrmMain_Shown;
        }

        private void MnuRecipeList_Click(object? sender, EventArgs e)
        {
            listtype = "recipe";
            OpenForm(typeof(frmSearch));
        }

        private void FrmMain_Shown(object? sender, EventArgs e)
        {
            //OpenForm(typeof(frmDashboard));
        }
        public void OpenForm(Type frmtype, int pkvalue = 0)
        {
            bool b = WindowsFormsUtility.IsFormOpen(frmtype);

            if (b == false)
            {
                Form? newfrm = null;
                if (frmtype == typeof(frmSearch) && listtype == "recipe")
                {
                    frmSearch f = new frmSearch(listtype);
                    newfrm = f;
                   // f.LoadForm(pkvalue);
                }
                if (frmtype == typeof(frmRecipe))
                {
                    frmRecipe f = new frmRecipe();
                    newfrm = f;

                }

                if (newfrm != null)
                {
                    newfrm.MdiParent = this;
                    newfrm.WindowState = FormWindowState.Maximized;
                    newfrm.FormClosed += Frm_FormClosed;
                    newfrm.TextChanged += Newfrm_TextChanged;
                    newfrm.Show();
                }
                WindowsFormsUtility.SetUpNav(tsMain);
            }
        }
        private void Newfrm_TextChanged(object? sender, EventArgs e)
        {
            WindowsFormsUtility.SetUpNav(tsMain);
        }

        private void Frm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            WindowsFormsUtility.SetUpNav(tsMain);
        }

        private void MnuWindowCascade_Click(object? sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void MnuWindowTile_Click(object? sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

    }
}
