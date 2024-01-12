namespace RecipeWinForms
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDashboard = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRecipe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRecipeList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewRecipe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCloneRecipe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMeals = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMealList = new System.Windows.Forms.ToolStripMenuItem();
            this.cookbooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCookbookList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewCookbook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAutoCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataMaintenance = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditData = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindowTile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindowCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuRecipe,
            this.mnuMeals,
            this.cookbooksToolStripMenuItem,
            this.mnuDataMaintenance,
            this.mnuWindow});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.mnuMain.Size = new System.Drawing.Size(1122, 30);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDashboard});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(46, 24);
            this.mnuFile.Text = "&File";
            // 
            // mnuDashboard
            // 
            this.mnuDashboard.Name = "mnuDashboard";
            this.mnuDashboard.Size = new System.Drawing.Size(165, 26);
            this.mnuDashboard.Text = "Dashboard";
            // 
            // mnuRecipe
            // 
            this.mnuRecipe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRecipeList,
            this.mnuNewRecipe,
            this.mnuCloneRecipe});
            this.mnuRecipe.Name = "mnuRecipe";
            this.mnuRecipe.Size = new System.Drawing.Size(74, 24);
            this.mnuRecipe.Text = "&Recipes";
            // 
            // mnuRecipeList
            // 
            this.mnuRecipeList.Name = "mnuRecipeList";
            this.mnuRecipeList.Size = new System.Drawing.Size(193, 26);
            this.mnuRecipeList.Text = "List";
            // 
            // mnuNewRecipe
            // 
            this.mnuNewRecipe.Name = "mnuNewRecipe";
            this.mnuNewRecipe.Size = new System.Drawing.Size(193, 26);
            this.mnuNewRecipe.Text = "New Recipe";
            // 
            // mnuCloneRecipe
            // 
            this.mnuCloneRecipe.Name = "mnuCloneRecipe";
            this.mnuCloneRecipe.Size = new System.Drawing.Size(193, 26);
            this.mnuCloneRecipe.Text = "Clone A Recipe";
            // 
            // mnuMeals
            // 
            this.mnuMeals.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMealList});
            this.mnuMeals.Name = "mnuMeals";
            this.mnuMeals.Size = new System.Drawing.Size(62, 24);
            this.mnuMeals.Text = "&Meals";
            // 
            // mnuMealList
            // 
            this.mnuMealList.Name = "mnuMealList";
            this.mnuMealList.Size = new System.Drawing.Size(114, 26);
            this.mnuMealList.Text = "List";
            // 
            // cookbooksToolStripMenuItem
            // 
            this.cookbooksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCookbookList,
            this.mnuNewCookbook,
            this.mnuAutoCreate});
            this.cookbooksToolStripMenuItem.Name = "cookbooksToolStripMenuItem";
            this.cookbooksToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.cookbooksToolStripMenuItem.Text = "&Cookbooks";
            // 
            // mnuCookbookList
            // 
            this.mnuCookbookList.Name = "mnuCookbookList";
            this.mnuCookbookList.Size = new System.Drawing.Size(194, 26);
            this.mnuCookbookList.Text = "List";
            // 
            // mnuNewCookbook
            // 
            this.mnuNewCookbook.Name = "mnuNewCookbook";
            this.mnuNewCookbook.Size = new System.Drawing.Size(194, 26);
            this.mnuNewCookbook.Text = "New Cookbook";
            // 
            // mnuAutoCreate
            // 
            this.mnuAutoCreate.Name = "mnuAutoCreate";
            this.mnuAutoCreate.Size = new System.Drawing.Size(194, 26);
            this.mnuAutoCreate.Text = "Auto-Create";
            // 
            // mnuDataMaintenance
            // 
            this.mnuDataMaintenance.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditData});
            this.mnuDataMaintenance.Name = "mnuDataMaintenance";
            this.mnuDataMaintenance.Size = new System.Drawing.Size(144, 24);
            this.mnuDataMaintenance.Text = "&Data Maintenance";
            // 
            // mnuEditData
            // 
            this.mnuEditData.Name = "mnuEditData";
            this.mnuEditData.Size = new System.Drawing.Size(154, 26);
            this.mnuEditData.Text = "Edit Data";
            // 
            // mnuWindow
            // 
            this.mnuWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuWindowTile,
            this.mnuWindowCascade});
            this.mnuWindow.Name = "mnuWindow";
            this.mnuWindow.Size = new System.Drawing.Size(84, 24);
            this.mnuWindow.Text = "&Windows";
            // 
            // mnuWindowTile
            // 
            this.mnuWindowTile.Name = "mnuWindowTile";
            this.mnuWindowTile.Size = new System.Drawing.Size(147, 26);
            this.mnuWindowTile.Text = "Tile";
            // 
            // mnuWindowCascade
            // 
            this.mnuWindowCascade.Name = "mnuWindowCascade";
            this.mnuWindowCascade.Size = new System.Drawing.Size(147, 26);
            this.mnuWindowCascade.Text = "Cascade";
            // 
            // tsMain
            // 
            this.tsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsMain.Location = new System.Drawing.Point(0, 30);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(1122, 25);
            this.tsMain.TabIndex = 1;
            this.tsMain.Text = "toolStrip1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 679);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.mnuMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "Recipe";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip mnuMain;
        private ToolStrip tsMain;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuDashboard;
        private ToolStripMenuItem mnuRecipe;
        private ToolStripMenuItem mnuRecipeList;
        private ToolStripMenuItem mnuNewRecipe;
        private ToolStripMenuItem mnuCloneRecipe;
        private ToolStripMenuItem mnuMeals;
        private ToolStripMenuItem mnuMealList;
        private ToolStripMenuItem cookbooksToolStripMenuItem;
        private ToolStripMenuItem mnuCookbookList;
        private ToolStripMenuItem mnuNewCookbook;
        private ToolStripMenuItem mnuAutoCreate;
        private ToolStripMenuItem mnuDataMaintenance;
        private ToolStripMenuItem mnuEditData;
        private ToolStripMenuItem mnuWindow;
        private ToolStripMenuItem mnuWindowTile;
        private ToolStripMenuItem mnuWindowCascade;
    }
}