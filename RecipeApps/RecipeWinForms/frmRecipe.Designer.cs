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
            this.dtpDateArchived = new System.Windows.Forms.DateTimePicker();
            this.dtpDatePublished = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPicture = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblCaptionPicture = new System.Windows.Forms.Label();
            this.lblCaptionStatus = new System.Windows.Forms.Label();
            this.lblCaptionDateArchived = new System.Windows.Forms.Label();
            this.lblCaptionDatePublished = new System.Windows.Forms.Label();
            this.lblCaptionDateDrafted = new System.Windows.Forms.Label();
            this.lblCaptionCalories = new System.Windows.Forms.Label();
            this.lblCaptionName = new System.Windows.Forms.Label();
            this.txtCalories = new System.Windows.Forms.TextBox();
            this.lblCaptionUser = new System.Windows.Forms.Label();
            this.lblCaptionCuisine = new System.Windows.Forms.Label();
            this.lstUser = new System.Windows.Forms.ComboBox();
            this.lstCuisine = new System.Windows.Forms.ComboBox();
            this.dtpDateDrafted = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tblMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.dtpDateArchived, 1, 6);
            this.tblMain.Controls.Add(this.dtpDatePublished, 1, 5);
            this.tblMain.Controls.Add(this.txtName, 1, 0);
            this.tblMain.Controls.Add(this.txtPicture, 1, 8);
            this.tblMain.Controls.Add(this.txtStatus, 1, 7);
            this.tblMain.Controls.Add(this.lblCaptionPicture, 0, 8);
            this.tblMain.Controls.Add(this.lblCaptionStatus, 0, 7);
            this.tblMain.Controls.Add(this.lblCaptionDateArchived, 0, 6);
            this.tblMain.Controls.Add(this.lblCaptionDatePublished, 0, 5);
            this.tblMain.Controls.Add(this.lblCaptionDateDrafted, 0, 4);
            this.tblMain.Controls.Add(this.lblCaptionCalories, 0, 3);
            this.tblMain.Controls.Add(this.lblCaptionName, 0, 0);
            this.tblMain.Controls.Add(this.txtCalories, 1, 3);
            this.tblMain.Controls.Add(this.lblCaptionUser, 0, 1);
            this.tblMain.Controls.Add(this.lblCaptionCuisine, 0, 2);
            this.tblMain.Controls.Add(this.lstUser, 1, 1);
            this.tblMain.Controls.Add(this.lstCuisine, 1, 2);
            this.tblMain.Controls.Add(this.dtpDateDrafted, 1, 4);
            this.tblMain.Controls.Add(this.tableLayoutPanel1, 1, 9);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 10;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.Size = new System.Drawing.Size(587, 426);
            this.tblMain.TabIndex = 1;
            // 
            // dtpDateArchived
            // 
            this.dtpDateArchived.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDateArchived.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateArchived.Location = new System.Drawing.Point(152, 243);
            this.dtpDateArchived.Name = "dtpDateArchived";
            this.dtpDateArchived.Size = new System.Drawing.Size(130, 34);
            this.dtpDateArchived.TabIndex = 30;
            // 
            // dtpDatePublished
            // 
            this.dtpDatePublished.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDatePublished.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatePublished.Location = new System.Drawing.Point(152, 203);
            this.dtpDatePublished.Name = "dtpDatePublished";
            this.dtpDatePublished.Size = new System.Drawing.Size(130, 34);
            this.dtpDatePublished.TabIndex = 29;
            // 
            // txtName
            // 
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(152, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(432, 34);
            this.txtName.TabIndex = 25;
            // 
            // txtPicture
            // 
            this.txtPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPicture.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPicture.Location = new System.Drawing.Point(152, 323);
            this.txtPicture.Name = "txtPicture";
            this.txtPicture.Size = new System.Drawing.Size(432, 34);
            this.txtPicture.TabIndex = 21;
            // 
            // txtStatus
            // 
            this.txtStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStatus.Location = new System.Drawing.Point(152, 283);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(432, 34);
            this.txtStatus.TabIndex = 20;
            // 
            // lblCaptionPicture
            // 
            this.lblCaptionPicture.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionPicture.AutoSize = true;
            this.lblCaptionPicture.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCaptionPicture.Location = new System.Drawing.Point(3, 326);
            this.lblCaptionPicture.Name = "lblCaptionPicture";
            this.lblCaptionPicture.Size = new System.Drawing.Size(72, 28);
            this.lblCaptionPicture.TabIndex = 12;
            this.lblCaptionPicture.Text = "Picture";
            // 
            // lblCaptionStatus
            // 
            this.lblCaptionStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionStatus.AutoSize = true;
            this.lblCaptionStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCaptionStatus.Location = new System.Drawing.Point(3, 286);
            this.lblCaptionStatus.Name = "lblCaptionStatus";
            this.lblCaptionStatus.Size = new System.Drawing.Size(65, 28);
            this.lblCaptionStatus.TabIndex = 10;
            this.lblCaptionStatus.Text = "Status";
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
            // txtCalories
            // 
            this.txtCalories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCalories.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCalories.Location = new System.Drawing.Point(152, 123);
            this.txtCalories.Name = "txtCalories";
            this.txtCalories.Size = new System.Drawing.Size(432, 34);
            this.txtCalories.TabIndex = 22;
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
            // lstUser
            // 
            this.lstUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lstUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstUser.FormattingEnabled = true;
            this.lstUser.Location = new System.Drawing.Point(152, 43);
            this.lstUser.Name = "lstUser";
            this.lstUser.Size = new System.Drawing.Size(227, 36);
            this.lstUser.TabIndex = 26;
            // 
            // lstCuisine
            // 
            this.lstCuisine.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lstCuisine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstCuisine.FormattingEnabled = true;
            this.lstCuisine.Location = new System.Drawing.Point(152, 83);
            this.lstCuisine.Name = "lstCuisine";
            this.lstCuisine.Size = new System.Drawing.Size(227, 36);
            this.lstCuisine.TabIndex = 27;
            // 
            // dtpDateDrafted
            // 
            this.dtpDateDrafted.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDateDrafted.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateDrafted.Location = new System.Drawing.Point(152, 163);
            this.dtpDateDrafted.Name = "dtpDateDrafted";
            this.dtpDateDrafted.Size = new System.Drawing.Size(130, 34);
            this.dtpDateDrafted.TabIndex = 28;
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(384, 379);
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
            // frmRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 426);
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
        private TextBox txtPicture;
        private TextBox txtStatus;
        private Label lblCaptionPicture;
        private Label lblCaptionStatus;
        private Label lblCaptionDateArchived;
        private Label lblCaptionDatePublished;
        private Label lblCaptionDateDrafted;
        private Label lblCaptionCalories;
        private Label lblCaptionName;
        private TextBox txtCalories;
        private TextBox txtName;
        private Label lblCaptionUser;
        private Label lblCaptionCuisine;
        private ComboBox lstUser;
        private ComboBox lstCuisine;
        private DateTimePicker dtpDateArchived;
        private DateTimePicker dtpDatePublished;
        private DateTimePicker dtpDateDrafted;
        private TableLayoutPanel tableLayoutPanel1;
        private Button BtnDelete;
        private Button btnSave;
    }
}