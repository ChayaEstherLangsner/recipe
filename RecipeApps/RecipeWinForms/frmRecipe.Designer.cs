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
            this.lblCaptionDateArchived = new System.Windows.Forms.Label();
            this.lblCaptionDatePublished = new System.Windows.Forms.Label();
            this.lblCaptionDateDrafted = new System.Windows.Forms.Label();
            this.lblCaptionCalories = new System.Windows.Forms.Label();
            this.lblCaptionName = new System.Windows.Forms.Label();
            this.txtRecipeCalories = new System.Windows.Forms.TextBox();
            this.lblCaptionUser = new System.Windows.Forms.Label();
            this.lblCaptionCuisine = new System.Windows.Forms.Label();
            this.lstUserName = new System.Windows.Forms.ComboBox();
            this.lstCuisineType = new System.Windows.Forms.ComboBox();
            this.dtpRecipeDateDrafted = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtRecipeDatePublished = new System.Windows.Forms.TextBox();
            this.txtRecipeDateArchived = new System.Windows.Forms.TextBox();
            this.tblMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.txtRecipeName, 1, 0);
            this.tblMain.Controls.Add(this.lblCaptionDateArchived, 0, 6);
            this.tblMain.Controls.Add(this.lblCaptionDatePublished, 0, 5);
            this.tblMain.Controls.Add(this.lblCaptionDateDrafted, 0, 4);
            this.tblMain.Controls.Add(this.lblCaptionCalories, 0, 3);
            this.tblMain.Controls.Add(this.lblCaptionName, 0, 0);
            this.tblMain.Controls.Add(this.txtRecipeCalories, 1, 3);
            this.tblMain.Controls.Add(this.lblCaptionUser, 0, 1);
            this.tblMain.Controls.Add(this.lblCaptionCuisine, 0, 2);
            this.tblMain.Controls.Add(this.lstUserName, 1, 1);
            this.tblMain.Controls.Add(this.lstCuisineType, 1, 2);
            this.tblMain.Controls.Add(this.dtpRecipeDateDrafted, 1, 4);
            this.tblMain.Controls.Add(this.tableLayoutPanel1, 1, 7);
            this.tblMain.Controls.Add(this.txtRecipeDatePublished, 1, 5);
            this.tblMain.Controls.Add(this.txtRecipeDateArchived, 1, 6);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 8;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.Size = new System.Drawing.Size(587, 360);
            this.tblMain.TabIndex = 1;
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecipeName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRecipeName.Location = new System.Drawing.Point(152, 3);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(432, 34);
            this.txtRecipeName.TabIndex = 25;
            // 
            // lblCaptionDateArchived
            // 
            this.lblCaptionDateArchived.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionDateArchived.AutoSize = true;
            this.lblCaptionDateArchived.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCaptionDateArchived.Location = new System.Drawing.Point(3, 246);
            this.lblCaptionDateArchived.Name = "lblCaptionDateArchived";
            this.lblCaptionDateArchived.Size = new System.Drawing.Size(135, 28);
            this.lblCaptionDateArchived.TabIndex = 8;
            this.lblCaptionDateArchived.Text = "Date Archived";
            // 
            // lblCaptionDatePublished
            // 
            this.lblCaptionDatePublished.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionDatePublished.AutoSize = true;
            this.lblCaptionDatePublished.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCaptionDatePublished.Location = new System.Drawing.Point(3, 206);
            this.lblCaptionDatePublished.Name = "lblCaptionDatePublished";
            this.lblCaptionDatePublished.Size = new System.Drawing.Size(143, 28);
            this.lblCaptionDatePublished.TabIndex = 6;
            this.lblCaptionDatePublished.Text = "Date Published";
            // 
            // lblCaptionDateDrafted
            // 
            this.lblCaptionDateDrafted.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionDateDrafted.AutoSize = true;
            this.lblCaptionDateDrafted.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCaptionDateDrafted.Location = new System.Drawing.Point(3, 166);
            this.lblCaptionDateDrafted.Name = "lblCaptionDateDrafted";
            this.lblCaptionDateDrafted.Size = new System.Drawing.Size(124, 28);
            this.lblCaptionDateDrafted.TabIndex = 4;
            this.lblCaptionDateDrafted.Text = "Date Drafted";
            // 
            // lblCaptionCalories
            // 
            this.lblCaptionCalories.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionCalories.AutoSize = true;
            this.lblCaptionCalories.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCaptionCalories.Location = new System.Drawing.Point(3, 126);
            this.lblCaptionCalories.Name = "lblCaptionCalories";
            this.lblCaptionCalories.Size = new System.Drawing.Size(81, 28);
            this.lblCaptionCalories.TabIndex = 2;
            this.lblCaptionCalories.Text = "Calories";
            // 
            // lblCaptionName
            // 
            this.lblCaptionName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionName.AutoSize = true;
            this.lblCaptionName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCaptionName.Location = new System.Drawing.Point(3, 6);
            this.lblCaptionName.Name = "lblCaptionName";
            this.lblCaptionName.Size = new System.Drawing.Size(64, 28);
            this.lblCaptionName.TabIndex = 0;
            this.lblCaptionName.Text = "Name";
            // 
            // txtRecipeCalories
            // 
            this.txtRecipeCalories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecipeCalories.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRecipeCalories.Location = new System.Drawing.Point(152, 123);
            this.txtRecipeCalories.Name = "txtRecipeCalories";
            this.txtRecipeCalories.Size = new System.Drawing.Size(432, 34);
            this.txtRecipeCalories.TabIndex = 22;
            // 
            // lblCaptionUser
            // 
            this.lblCaptionUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionUser.AutoSize = true;
            this.lblCaptionUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCaptionUser.Location = new System.Drawing.Point(3, 46);
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
            this.lblCaptionCuisine.Location = new System.Drawing.Point(3, 86);
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
            this.lstUserName.Location = new System.Drawing.Point(152, 43);
            this.lstUserName.Name = "lstUserName";
            this.lstUserName.Size = new System.Drawing.Size(227, 36);
            this.lstUserName.TabIndex = 26;
            // 
            // lstCuisineType
            // 
            this.lstCuisineType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lstCuisineType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstCuisineType.FormattingEnabled = true;
            this.lstCuisineType.Location = new System.Drawing.Point(152, 83);
            this.lstCuisineType.Name = "lstCuisineType";
            this.lstCuisineType.Size = new System.Drawing.Size(227, 36);
            this.lstCuisineType.TabIndex = 27;
            // 
            // dtpRecipeDateDrafted
            // 
            this.dtpRecipeDateDrafted.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpRecipeDateDrafted.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRecipeDateDrafted.Location = new System.Drawing.Point(152, 163);
            this.dtpRecipeDateDrafted.Name = "dtpRecipeDateDrafted";
            this.dtpRecipeDateDrafted.Size = new System.Drawing.Size(130, 34);
            this.dtpRecipeDateDrafted.TabIndex = 28;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.BtnDelete, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(384, 313);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 44);
            this.tableLayoutPanel1.TabIndex = 31;
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
            // txtRecipeDatePublished
            // 
            this.txtRecipeDatePublished.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecipeDatePublished.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRecipeDatePublished.Location = new System.Drawing.Point(152, 203);
            this.txtRecipeDatePublished.Name = "txtRecipeDatePublished";
            this.txtRecipeDatePublished.Size = new System.Drawing.Size(432, 34);
            this.txtRecipeDatePublished.TabIndex = 32;
            // 
            // txtRecipeDateArchived
            // 
            this.txtRecipeDateArchived.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecipeDateArchived.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRecipeDateArchived.Location = new System.Drawing.Point(152, 243);
            this.txtRecipeDateArchived.Name = "txtRecipeDateArchived";
            this.txtRecipeDateArchived.Size = new System.Drawing.Size(432, 34);
            this.txtRecipeDateArchived.TabIndex = 33;
            // 
            // frmRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 360);
            this.Controls.Add(this.tblMain);
            this.Name = "frmRecipe";
            this.Text = "frmRecipe";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblCaptionDateArchived;
        private Label lblCaptionDatePublished;
        private Label lblCaptionDateDrafted;
        private Label lblCaptionCalories;
        private Label lblCaptionName;
        private TextBox txtRecipeCalories;
        private TextBox txtRecipeName;
        private Label lblCaptionUser;
        private Label lblCaptionCuisine;
        private ComboBox lstUserName;
        private ComboBox lstCuisineType;
        private DateTimePicker dtpRecipeDateDrafted;
        private TableLayoutPanel tableLayoutPanel1;
        private Button BtnDelete;
        private Button btnSave;
        private TextBox txtRecipeDatePublished;
        private TextBox txtRecipeDateArchived;
    }
}