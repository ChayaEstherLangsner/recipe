namespace RecipeWinForms
{
    partial class frmRecipe
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
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.lblCaptionStatusDates = new System.Windows.Forms.Label();
            this.lblCaptionCurrentStatus = new System.Windows.Forms.Label();
            this.lblCaptionCalories = new System.Windows.Forms.Label();
            this.lblCaptionName = new System.Windows.Forms.Label();
            this.txtRecipeCalories = new System.Windows.Forms.TextBox();
            this.lblCaptionUser = new System.Windows.Forms.Label();
            this.lblCaptionCuisine = new System.Windows.Forms.Label();
            this.lstUserName = new System.Windows.Forms.ComboBox();
            this.lstCuisineType = new System.Windows.Forms.ComboBox();
            this.tblStatusDates = new System.Windows.Forms.TableLayoutPanel();
            this.lblCaptionDrafted = new System.Windows.Forms.Label();
            this.lblCaptionPublished = new System.Windows.Forms.Label();
            this.lblCaptionArchived = new System.Windows.Forms.Label();
            this.txtRecipeDateArchived = new System.Windows.Forms.TextBox();
            this.txtRecipeDateDrafted = new System.Windows.Forms.TextBox();
            this.txtRecipeDatePublished = new System.Windows.Forms.TextBox();
            this.txtRecipeStatus = new System.Windows.Forms.TextBox();
            this.tRecipeDetails = new System.Windows.Forms.TabControl();
            this.tpIngredients = new System.Windows.Forms.TabPage();
            this.tblIngredients = new System.Windows.Forms.TableLayoutPanel();
            this.btnSaveIngredient = new System.Windows.Forms.Button();
            this.gIngredient = new System.Windows.Forms.DataGridView();
            this.tpSteps = new System.Windows.Forms.TabPage();
            this.tblSteps = new System.Windows.Forms.TableLayoutPanel();
            this.BtnSaveSteps = new System.Windows.Forms.Button();
            this.gSteps = new System.Windows.Forms.DataGridView();
            this.tblButtons = new System.Windows.Forms.TableLayoutPanel();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnChangeStatus = new System.Windows.Forms.Button();
            this.tblMain.SuspendLayout();
            this.tblStatusDates.SuspendLayout();
            this.tRecipeDetails.SuspendLayout();
            this.tpIngredients.SuspendLayout();
            this.tblIngredients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gIngredient)).BeginInit();
            this.tpSteps.SuspendLayout();
            this.tblSteps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gSteps)).BeginInit();
            this.tblButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.txtRecipeName, 1, 1);
            this.tblMain.Controls.Add(this.lblCaptionStatusDates, 0, 6);
            this.tblMain.Controls.Add(this.lblCaptionCurrentStatus, 0, 5);
            this.tblMain.Controls.Add(this.lblCaptionCalories, 0, 4);
            this.tblMain.Controls.Add(this.lblCaptionName, 0, 1);
            this.tblMain.Controls.Add(this.txtRecipeCalories, 1, 4);
            this.tblMain.Controls.Add(this.lblCaptionUser, 0, 2);
            this.tblMain.Controls.Add(this.lblCaptionCuisine, 0, 3);
            this.tblMain.Controls.Add(this.lstUserName, 1, 2);
            this.tblMain.Controls.Add(this.lstCuisineType, 1, 3);
            this.tblMain.Controls.Add(this.tblStatusDates, 1, 6);
            this.tblMain.Controls.Add(this.txtRecipeStatus, 1, 5);
            this.tblMain.Controls.Add(this.tRecipeDetails, 0, 7);
            this.tblMain.Controls.Add(this.tblButtons, 0, 0);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 8;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.Size = new System.Drawing.Size(587, 693);
            this.tblMain.TabIndex = 1;
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecipeName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRecipeName.Location = new System.Drawing.Point(144, 53);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(440, 34);
            this.txtRecipeName.TabIndex = 25;
            // 
            // lblCaptionStatusDates
            // 
            this.lblCaptionStatusDates.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionStatusDates.AutoSize = true;
            this.lblCaptionStatusDates.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCaptionStatusDates.Location = new System.Drawing.Point(3, 263);
            this.lblCaptionStatusDates.Name = "lblCaptionStatusDates";
            this.lblCaptionStatusDates.Size = new System.Drawing.Size(119, 28);
            this.lblCaptionStatusDates.TabIndex = 6;
            this.lblCaptionStatusDates.Text = "Status Dates";
            // 
            // lblCaptionCurrentStatus
            // 
            this.lblCaptionCurrentStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionCurrentStatus.AutoSize = true;
            this.lblCaptionCurrentStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCaptionCurrentStatus.Location = new System.Drawing.Point(3, 206);
            this.lblCaptionCurrentStatus.Name = "lblCaptionCurrentStatus";
            this.lblCaptionCurrentStatus.Size = new System.Drawing.Size(135, 28);
            this.lblCaptionCurrentStatus.TabIndex = 4;
            this.lblCaptionCurrentStatus.Text = "Current Status";
            // 
            // lblCaptionCalories
            // 
            this.lblCaptionCalories.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionCalories.AutoSize = true;
            this.lblCaptionCalories.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCaptionCalories.Location = new System.Drawing.Point(3, 166);
            this.lblCaptionCalories.Name = "lblCaptionCalories";
            this.lblCaptionCalories.Size = new System.Drawing.Size(129, 28);
            this.lblCaptionCalories.TabIndex = 2;
            this.lblCaptionCalories.Text = "Num Calories";
            // 
            // lblCaptionName
            // 
            this.lblCaptionName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionName.AutoSize = true;
            this.lblCaptionName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCaptionName.Location = new System.Drawing.Point(3, 51);
            this.lblCaptionName.Name = "lblCaptionName";
            this.lblCaptionName.Size = new System.Drawing.Size(126, 28);
            this.lblCaptionName.TabIndex = 0;
            this.lblCaptionName.Text = "Recipe Name";
            // 
            // txtRecipeCalories
            // 
            this.txtRecipeCalories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecipeCalories.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRecipeCalories.Location = new System.Drawing.Point(144, 163);
            this.txtRecipeCalories.Name = "txtRecipeCalories";
            this.txtRecipeCalories.Size = new System.Drawing.Size(440, 34);
            this.txtRecipeCalories.TabIndex = 22;
            // 
            // lblCaptionUser
            // 
            this.lblCaptionUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionUser.AutoSize = true;
            this.lblCaptionUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCaptionUser.Location = new System.Drawing.Point(3, 86);
            this.lblCaptionUser.Name = "lblCaptionUser";
            this.lblCaptionUser.Size = new System.Drawing.Size(51, 28);
            this.lblCaptionUser.TabIndex = 23;
            this.lblCaptionUser.Text = "User";
            // 
            // lblCaptionCuisine
            // 
            this.lblCaptionCuisine.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionCuisine.AutoSize = true;
            this.lblCaptionCuisine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCaptionCuisine.Location = new System.Drawing.Point(3, 126);
            this.lblCaptionCuisine.Name = "lblCaptionCuisine";
            this.lblCaptionCuisine.Size = new System.Drawing.Size(74, 28);
            this.lblCaptionCuisine.TabIndex = 24;
            this.lblCaptionCuisine.Text = "Cuisine";
            // 
            // lstUserName
            // 
            this.lstUserName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lstUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstUserName.FormattingEnabled = true;
            this.lstUserName.Location = new System.Drawing.Point(144, 83);
            this.lstUserName.Name = "lstUserName";
            this.lstUserName.Size = new System.Drawing.Size(227, 36);
            this.lstUserName.TabIndex = 26;
            // 
            // lstCuisineType
            // 
            this.lstCuisineType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lstCuisineType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstCuisineType.FormattingEnabled = true;
            this.lstCuisineType.Location = new System.Drawing.Point(144, 123);
            this.lstCuisineType.Name = "lstCuisineType";
            this.lstCuisineType.Size = new System.Drawing.Size(227, 36);
            this.lstCuisineType.TabIndex = 27;
            // 
            // tblStatusDates
            // 
            this.tblStatusDates.AutoSize = true;
            this.tblStatusDates.ColumnCount = 3;
            this.tblStatusDates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblStatusDates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblStatusDates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblStatusDates.Controls.Add(this.lblCaptionDrafted, 0, 0);
            this.tblStatusDates.Controls.Add(this.lblCaptionPublished, 1, 0);
            this.tblStatusDates.Controls.Add(this.lblCaptionArchived, 2, 0);
            this.tblStatusDates.Controls.Add(this.txtRecipeDateArchived, 2, 1);
            this.tblStatusDates.Controls.Add(this.txtRecipeDateDrafted, 0, 1);
            this.tblStatusDates.Controls.Add(this.txtRecipeDatePublished, 1, 1);
            this.tblStatusDates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblStatusDates.Location = new System.Drawing.Point(144, 243);
            this.tblStatusDates.Name = "tblStatusDates";
            this.tblStatusDates.RowCount = 2;
            this.tblStatusDates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblStatusDates.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblStatusDates.Size = new System.Drawing.Size(440, 68);
            this.tblStatusDates.TabIndex = 35;
            // 
            // lblCaptionDrafted
            // 
            this.lblCaptionDrafted.AutoSize = true;
            this.lblCaptionDrafted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCaptionDrafted.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCaptionDrafted.Location = new System.Drawing.Point(3, 0);
            this.lblCaptionDrafted.Name = "lblCaptionDrafted";
            this.lblCaptionDrafted.Size = new System.Drawing.Size(140, 28);
            this.lblCaptionDrafted.TabIndex = 0;
            this.lblCaptionDrafted.Text = "Drafted";
            this.lblCaptionDrafted.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblCaptionPublished
            // 
            this.lblCaptionPublished.AutoSize = true;
            this.lblCaptionPublished.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCaptionPublished.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCaptionPublished.Location = new System.Drawing.Point(149, 0);
            this.lblCaptionPublished.Name = "lblCaptionPublished";
            this.lblCaptionPublished.Size = new System.Drawing.Size(140, 28);
            this.lblCaptionPublished.TabIndex = 1;
            this.lblCaptionPublished.Text = "Published";
            this.lblCaptionPublished.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblCaptionArchived
            // 
            this.lblCaptionArchived.AutoSize = true;
            this.lblCaptionArchived.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCaptionArchived.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCaptionArchived.Location = new System.Drawing.Point(295, 0);
            this.lblCaptionArchived.Name = "lblCaptionArchived";
            this.lblCaptionArchived.Size = new System.Drawing.Size(142, 28);
            this.lblCaptionArchived.TabIndex = 2;
            this.lblCaptionArchived.Text = "Archived";
            this.lblCaptionArchived.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtRecipeDateArchived
            // 
            this.txtRecipeDateArchived.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRecipeDateArchived.Enabled = false;
            this.txtRecipeDateArchived.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRecipeDateArchived.Location = new System.Drawing.Point(295, 31);
            this.txtRecipeDateArchived.Name = "txtRecipeDateArchived";
            this.txtRecipeDateArchived.Size = new System.Drawing.Size(142, 34);
            this.txtRecipeDateArchived.TabIndex = 5;
            // 
            // txtRecipeDateDrafted
            // 
            this.txtRecipeDateDrafted.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRecipeDateDrafted.Enabled = false;
            this.txtRecipeDateDrafted.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRecipeDateDrafted.Location = new System.Drawing.Point(3, 31);
            this.txtRecipeDateDrafted.Name = "txtRecipeDateDrafted";
            this.txtRecipeDateDrafted.Size = new System.Drawing.Size(140, 34);
            this.txtRecipeDateDrafted.TabIndex = 4;
            // 
            // txtRecipeDatePublished
            // 
            this.txtRecipeDatePublished.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRecipeDatePublished.Enabled = false;
            this.txtRecipeDatePublished.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRecipeDatePublished.Location = new System.Drawing.Point(149, 31);
            this.txtRecipeDatePublished.Name = "txtRecipeDatePublished";
            this.txtRecipeDatePublished.Size = new System.Drawing.Size(140, 34);
            this.txtRecipeDatePublished.TabIndex = 3;
            // 
            // txtRecipeStatus
            // 
            this.txtRecipeStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecipeStatus.Enabled = false;
            this.txtRecipeStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRecipeStatus.Location = new System.Drawing.Point(144, 203);
            this.txtRecipeStatus.Name = "txtRecipeStatus";
            this.txtRecipeStatus.Size = new System.Drawing.Size(440, 34);
            this.txtRecipeStatus.TabIndex = 36;
            // 
            // tRecipeDetails
            // 
            this.tblMain.SetColumnSpan(this.tRecipeDetails, 2);
            this.tRecipeDetails.Controls.Add(this.tpIngredients);
            this.tRecipeDetails.Controls.Add(this.tpSteps);
            this.tRecipeDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tRecipeDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tRecipeDetails.Location = new System.Drawing.Point(3, 317);
            this.tRecipeDetails.Name = "tRecipeDetails";
            this.tRecipeDetails.SelectedIndex = 0;
            this.tRecipeDetails.Size = new System.Drawing.Size(581, 373);
            this.tRecipeDetails.TabIndex = 37;
            // 
            // tpIngredients
            // 
            this.tpIngredients.Controls.Add(this.tblIngredients);
            this.tpIngredients.Location = new System.Drawing.Point(4, 37);
            this.tpIngredients.Name = "tpIngredients";
            this.tpIngredients.Padding = new System.Windows.Forms.Padding(3);
            this.tpIngredients.Size = new System.Drawing.Size(573, 332);
            this.tpIngredients.TabIndex = 0;
            this.tpIngredients.Text = "Ingredients";
            this.tpIngredients.UseVisualStyleBackColor = true;
            // 
            // tblIngredients
            // 
            this.tblIngredients.ColumnCount = 1;
            this.tblIngredients.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblIngredients.Controls.Add(this.btnSaveIngredient, 0, 0);
            this.tblIngredients.Controls.Add(this.gIngredient, 0, 1);
            this.tblIngredients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblIngredients.Location = new System.Drawing.Point(3, 3);
            this.tblIngredients.Name = "tblIngredients";
            this.tblIngredients.RowCount = 2;
            this.tblIngredients.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblIngredients.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblIngredients.Size = new System.Drawing.Size(567, 326);
            this.tblIngredients.TabIndex = 1;
            // 
            // btnSaveIngredient
            // 
            this.btnSaveIngredient.AutoSize = true;
            this.btnSaveIngredient.Location = new System.Drawing.Point(3, 3);
            this.btnSaveIngredient.Name = "btnSaveIngredient";
            this.btnSaveIngredient.Size = new System.Drawing.Size(94, 38);
            this.btnSaveIngredient.TabIndex = 0;
            this.btnSaveIngredient.Text = "Save";
            this.btnSaveIngredient.UseVisualStyleBackColor = true;
            // 
            // gIngredient
            // 
            this.gIngredient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gIngredient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gIngredient.Location = new System.Drawing.Point(3, 47);
            this.gIngredient.Name = "gIngredient";
            this.gIngredient.RowHeadersWidth = 51;
            this.gIngredient.RowTemplate.Height = 29;
            this.gIngredient.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gIngredient.Size = new System.Drawing.Size(561, 276);
            this.gIngredient.TabIndex = 1;
            // 
            // tpSteps
            // 
            this.tpSteps.Controls.Add(this.tblSteps);
            this.tpSteps.Location = new System.Drawing.Point(4, 37);
            this.tpSteps.Name = "tpSteps";
            this.tpSteps.Padding = new System.Windows.Forms.Padding(3);
            this.tpSteps.Size = new System.Drawing.Size(573, 332);
            this.tpSteps.TabIndex = 1;
            this.tpSteps.Text = "Steps";
            this.tpSteps.UseVisualStyleBackColor = true;
            // 
            // tblSteps
            // 
            this.tblSteps.ColumnCount = 1;
            this.tblSteps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblSteps.Controls.Add(this.BtnSaveSteps, 0, 0);
            this.tblSteps.Controls.Add(this.gSteps, 0, 1);
            this.tblSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblSteps.Location = new System.Drawing.Point(3, 3);
            this.tblSteps.Name = "tblSteps";
            this.tblSteps.RowCount = 2;
            this.tblSteps.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblSteps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblSteps.Size = new System.Drawing.Size(567, 326);
            this.tblSteps.TabIndex = 1;
            // 
            // BtnSaveSteps
            // 
            this.BtnSaveSteps.AutoSize = true;
            this.BtnSaveSteps.Location = new System.Drawing.Point(3, 3);
            this.BtnSaveSteps.Name = "BtnSaveSteps";
            this.BtnSaveSteps.Size = new System.Drawing.Size(94, 38);
            this.BtnSaveSteps.TabIndex = 0;
            this.BtnSaveSteps.Text = "Save";
            this.BtnSaveSteps.UseVisualStyleBackColor = true;
            // 
            // gSteps
            // 
            this.gSteps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gSteps.Location = new System.Drawing.Point(3, 47);
            this.gSteps.Name = "gSteps";
            this.gSteps.RowHeadersWidth = 51;
            this.gSteps.RowTemplate.Height = 29;
            this.gSteps.Size = new System.Drawing.Size(561, 276);
            this.gSteps.TabIndex = 1;
            // 
            // tblButtons
            // 
            this.tblButtons.AutoSize = true;
            this.tblButtons.ColumnCount = 3;
            this.tblMain.SetColumnSpan(this.tblButtons, 2);
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblButtons.Controls.Add(this.BtnDelete, 1, 0);
            this.tblButtons.Controls.Add(this.btnSave, 0, 0);
            this.tblButtons.Controls.Add(this.btnChangeStatus, 2, 0);
            this.tblButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblButtons.Location = new System.Drawing.Point(3, 3);
            this.tblButtons.Name = "tblButtons";
            this.tblButtons.RowCount = 1;
            this.tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblButtons.Size = new System.Drawing.Size(581, 44);
            this.tblButtons.TabIndex = 31;
            // 
            // BtnDelete
            // 
            this.BtnDelete.AutoSize = true;
            this.BtnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnDelete.Location = new System.Drawing.Point(103, 3);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(94, 38);
            this.BtnDelete.TabIndex = 0;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 38);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnChangeStatus
            // 
            this.btnChangeStatus.AutoSize = true;
            this.btnChangeStatus.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnChangeStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChangeStatus.Location = new System.Drawing.Point(404, 3);
            this.btnChangeStatus.Name = "btnChangeStatus";
            this.btnChangeStatus.Size = new System.Drawing.Size(174, 38);
            this.btnChangeStatus.TabIndex = 2;
            this.btnChangeStatus.Text = "Change Status...";
            this.btnChangeStatus.UseVisualStyleBackColor = true;
            // 
            // frmRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 693);
            this.Controls.Add(this.tblMain);
            this.Name = "frmRecipe";
            this.Text = "Recipe";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tblStatusDates.ResumeLayout(false);
            this.tblStatusDates.PerformLayout();
            this.tRecipeDetails.ResumeLayout(false);
            this.tpIngredients.ResumeLayout(false);
            this.tblIngredients.ResumeLayout(false);
            this.tblIngredients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gIngredient)).EndInit();
            this.tpSteps.ResumeLayout(false);
            this.tblSteps.ResumeLayout(false);
            this.tblSteps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gSteps)).EndInit();
            this.tblButtons.ResumeLayout(false);
            this.tblButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblCaptionStatusDates;
        private Label lblCaptionCurrentStatus;
        private Label lblCaptionCalories;
        private Label lblCaptionName;
        private TextBox txtRecipeCalories;
        private TextBox txtRecipeName;
        private Label lblCaptionUser;
        private Label lblCaptionCuisine;
        private ComboBox lstUserName;
        private ComboBox lstCuisineType;
        private TableLayoutPanel tblButtons;
        private Button BtnDelete;
        private Button btnSave;
        private Button btnChangeStatus;
        private TableLayoutPanel tblStatusDates;
        private Label lblCaptionDrafted;
        private Label lblCaptionPublished;
        private Label lblCaptionArchived;
        private TextBox txtRecipeDatePublished;
        private TextBox txtRecipeDateDrafted;
        private TextBox txtRecipeDateArchived;
        private TabControl tRecipeDetails;
        private TabPage tpIngredients;
        private TableLayoutPanel tblIngredients;
        private Button btnSaveIngredient;
        private DataGridView gIngredient;
        private TabPage tpSteps;
        private TableLayoutPanel tblSteps;
        private Button BtnSaveSteps;
        private DataGridView gSteps;
        private TextBox txtRecipeStatus;
    }
}