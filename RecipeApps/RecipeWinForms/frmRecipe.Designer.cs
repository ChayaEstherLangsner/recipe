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
            this.txtPicture = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtDateArchived = new System.Windows.Forms.TextBox();
            this.txtDatePublished = new System.Windows.Forms.TextBox();
            this.lblCaptionPicture = new System.Windows.Forms.Label();
            this.lblCaptionStatus = new System.Windows.Forms.Label();
            this.lblCaptionDateArchived = new System.Windows.Forms.Label();
            this.lblCaptionDatePublished = new System.Windows.Forms.Label();
            this.lblCaptionDateDrafted = new System.Windows.Forms.Label();
            this.lblCaptionCalories = new System.Windows.Forms.Label();
            this.lblCaptionName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtDateDrafted = new System.Windows.Forms.TextBox();
            this.txtCalories = new System.Windows.Forms.TextBox();
            this.tblMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.txtPicture, 1, 6);
            this.tblMain.Controls.Add(this.txtStatus, 1, 5);
            this.tblMain.Controls.Add(this.txtDateArchived, 1, 4);
            this.tblMain.Controls.Add(this.txtDatePublished, 1, 3);
            this.tblMain.Controls.Add(this.lblCaptionPicture, 0, 6);
            this.tblMain.Controls.Add(this.lblCaptionStatus, 0, 5);
            this.tblMain.Controls.Add(this.lblCaptionDateArchived, 0, 4);
            this.tblMain.Controls.Add(this.lblCaptionDatePublished, 0, 3);
            this.tblMain.Controls.Add(this.lblCaptionDateDrafted, 0, 2);
            this.tblMain.Controls.Add(this.lblCaptionCalories, 0, 1);
            this.tblMain.Controls.Add(this.lblCaptionName, 0, 0);
            this.tblMain.Controls.Add(this.lblName, 1, 0);
            this.tblMain.Controls.Add(this.txtDateDrafted, 1, 2);
            this.tblMain.Controls.Add(this.txtCalories, 1, 1);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 7;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.Size = new System.Drawing.Size(800, 283);
            this.tblMain.TabIndex = 1;
            // 
            // txtPicture
            // 
            this.txtPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPicture.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPicture.Location = new System.Drawing.Point(152, 243);
            this.txtPicture.Name = "txtPicture";
            this.txtPicture.Size = new System.Drawing.Size(645, 34);
            this.txtPicture.TabIndex = 21;
            // 
            // txtStatus
            // 
            this.txtStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStatus.Location = new System.Drawing.Point(152, 203);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(645, 34);
            this.txtStatus.TabIndex = 20;
            // 
            // txtDateArchived
            // 
            this.txtDateArchived.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDateArchived.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDateArchived.Location = new System.Drawing.Point(152, 163);
            this.txtDateArchived.Name = "txtDateArchived";
            this.txtDateArchived.Size = new System.Drawing.Size(645, 34);
            this.txtDateArchived.TabIndex = 19;
            // 
            // txtDatePublished
            // 
            this.txtDatePublished.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDatePublished.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDatePublished.Location = new System.Drawing.Point(152, 123);
            this.txtDatePublished.Name = "txtDatePublished";
            this.txtDatePublished.Size = new System.Drawing.Size(645, 34);
            this.txtDatePublished.TabIndex = 18;
            // 
            // lblCaptionPicture
            // 
            this.lblCaptionPicture.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionPicture.AutoSize = true;
            this.lblCaptionPicture.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCaptionPicture.Location = new System.Drawing.Point(3, 247);
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
            this.lblCaptionStatus.Location = new System.Drawing.Point(3, 206);
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
            this.lblCaptionDateArchived.Location = new System.Drawing.Point(3, 166);
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
            this.lblCaptionDatePublished.Location = new System.Drawing.Point(3, 126);
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
            this.lblCaptionDateDrafted.Location = new System.Drawing.Point(3, 86);
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
            this.lblCaptionCalories.Location = new System.Drawing.Point(3, 46);
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
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(152, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(645, 40);
            this.lblName.TabIndex = 15;
            // 
            // txtDateDrafted
            // 
            this.txtDateDrafted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDateDrafted.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDateDrafted.Location = new System.Drawing.Point(152, 83);
            this.txtDateDrafted.Name = "txtDateDrafted";
            this.txtDateDrafted.Size = new System.Drawing.Size(645, 34);
            this.txtDateDrafted.TabIndex = 17;
            // 
            // txtCalories
            // 
            this.txtCalories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCalories.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCalories.Location = new System.Drawing.Point(152, 43);
            this.txtCalories.Name = "txtCalories";
            this.txtCalories.Size = new System.Drawing.Size(645, 34);
            this.txtCalories.TabIndex = 22;
            // 
            // frmRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 283);
            this.Controls.Add(this.tblMain);
            this.Name = "frmRecipe";
            this.Text = "frmRecipe";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private TextBox txtPicture;
        private TextBox txtStatus;
        private TextBox txtDateArchived;
        private TextBox txtDatePublished;
        private Label lblCaptionPicture;
        private Label lblCaptionStatus;
        private Label lblCaptionDateArchived;
        private Label lblCaptionDatePublished;
        private Label lblCaptionDateDrafted;
        private Label lblCaptionCalories;
        private Label lblCaptionName;
        private Label lblName;
        private TextBox txtDateDrafted;
        private TextBox txtCalories;
    }
}