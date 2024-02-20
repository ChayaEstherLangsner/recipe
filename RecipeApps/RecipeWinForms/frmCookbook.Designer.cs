namespace RecipeWinForms
{
    partial class frmCookbook
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
            this.txtCookbookName = new System.Windows.Forms.TextBox();
            this.lblCaptionStatusActive = new System.Windows.Forms.Label();
            this.lblCaptionDateCreated = new System.Windows.Forms.Label();
            this.lblCaptionPrice = new System.Windows.Forms.Label();
            this.lblCaptionName = new System.Windows.Forms.Label();
            this.txtCookbookPrice = new System.Windows.Forms.TextBox();
            this.lblCaptionUser = new System.Windows.Forms.Label();
            this.lstUserName = new System.Windows.Forms.ComboBox();
            this.txtCookbookDateInserted = new System.Windows.Forms.TextBox();
            this.tCookbookRecipes = new System.Windows.Forms.TabControl();
            this.tpRecipes = new System.Windows.Forms.TabPage();
            this.tblRecipes = new System.Windows.Forms.TableLayoutPanel();
            this.btnSaveRecipe = new System.Windows.Forms.Button();
            this.gRecipe = new System.Windows.Forms.DataGridView();
            this.tblButtons = new System.Windows.Forms.TableLayoutPanel();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.ckbIsActive = new System.Windows.Forms.CheckBox();
            this.tblMain.SuspendLayout();
            this.tCookbookRecipes.SuspendLayout();
            this.tpRecipes.SuspendLayout();
            this.tblRecipes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gRecipe)).BeginInit();
            this.tblButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.txtCookbookName, 1, 1);
            this.tblMain.Controls.Add(this.lblCaptionStatusActive, 0, 6);
            this.tblMain.Controls.Add(this.lblCaptionDateCreated, 0, 5);
            this.tblMain.Controls.Add(this.lblCaptionPrice, 0, 4);
            this.tblMain.Controls.Add(this.lblCaptionName, 0, 1);
            this.tblMain.Controls.Add(this.txtCookbookPrice, 1, 4);
            this.tblMain.Controls.Add(this.lblCaptionUser, 0, 2);
            this.tblMain.Controls.Add(this.lstUserName, 1, 2);
            this.tblMain.Controls.Add(this.txtCookbookDateInserted, 1, 5);
            this.tblMain.Controls.Add(this.tCookbookRecipes, 0, 7);
            this.tblMain.Controls.Add(this.tblButtons, 0, 0);
            this.tblMain.Controls.Add(this.ckbIsActive, 1, 6);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 8;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.Size = new System.Drawing.Size(992, 749);
            this.tblMain.TabIndex = 2;
            // 
            // txtCookbookName
            // 
            this.txtCookbookName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCookbookName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCookbookName.Location = new System.Drawing.Point(170, 53);
            this.txtCookbookName.Name = "txtCookbookName";
            this.txtCookbookName.Size = new System.Drawing.Size(819, 34);
            this.txtCookbookName.TabIndex = 25;
            // 
            // lblCaptionStatusActive
            // 
            this.lblCaptionStatusActive.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionStatusActive.AutoSize = true;
            this.lblCaptionStatusActive.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCaptionStatusActive.Location = new System.Drawing.Point(3, 212);
            this.lblCaptionStatusActive.Name = "lblCaptionStatusActive";
            this.lblCaptionStatusActive.Size = new System.Drawing.Size(66, 28);
            this.lblCaptionStatusActive.TabIndex = 6;
            this.lblCaptionStatusActive.Text = "Active";
            // 
            // lblCaptionDateCreated
            // 
            this.lblCaptionDateCreated.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionDateCreated.AutoSize = true;
            this.lblCaptionDateCreated.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCaptionDateCreated.Location = new System.Drawing.Point(3, 178);
            this.lblCaptionDateCreated.Name = "lblCaptionDateCreated";
            this.lblCaptionDateCreated.Size = new System.Drawing.Size(126, 28);
            this.lblCaptionDateCreated.TabIndex = 4;
            this.lblCaptionDateCreated.Text = "Date Created";
            // 
            // lblCaptionPrice
            // 
            this.lblCaptionPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionPrice.AutoSize = true;
            this.lblCaptionPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCaptionPrice.Location = new System.Drawing.Point(3, 138);
            this.lblCaptionPrice.Name = "lblCaptionPrice";
            this.lblCaptionPrice.Size = new System.Drawing.Size(54, 28);
            this.lblCaptionPrice.TabIndex = 2;
            this.lblCaptionPrice.Text = "Price";
            // 
            // lblCaptionName
            // 
            this.lblCaptionName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionName.AutoSize = true;
            this.lblCaptionName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCaptionName.Location = new System.Drawing.Point(3, 56);
            this.lblCaptionName.Name = "lblCaptionName";
            this.lblCaptionName.Size = new System.Drawing.Size(161, 28);
            this.lblCaptionName.TabIndex = 0;
            this.lblCaptionName.Text = "Cookbook Name";
            // 
            // txtCookbookPrice
            // 
            this.txtCookbookPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCookbookPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCookbookPrice.Location = new System.Drawing.Point(170, 135);
            this.txtCookbookPrice.Name = "txtCookbookPrice";
            this.txtCookbookPrice.Size = new System.Drawing.Size(819, 34);
            this.txtCookbookPrice.TabIndex = 22;
            // 
            // lblCaptionUser
            // 
            this.lblCaptionUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionUser.AutoSize = true;
            this.lblCaptionUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCaptionUser.Location = new System.Drawing.Point(3, 97);
            this.lblCaptionUser.Name = "lblCaptionUser";
            this.lblCaptionUser.Size = new System.Drawing.Size(51, 28);
            this.lblCaptionUser.TabIndex = 23;
            this.lblCaptionUser.Text = "User";
            // 
            // lstUserName
            // 
            this.lstUserName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lstUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstUserName.FormattingEnabled = true;
            this.lstUserName.Location = new System.Drawing.Point(170, 93);
            this.lstUserName.Name = "lstUserName";
            this.lstUserName.Size = new System.Drawing.Size(227, 36);
            this.lstUserName.TabIndex = 26;
            // 
            // txtCookbookDateInserted
            // 
            this.txtCookbookDateInserted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCookbookDateInserted.Enabled = false;
            this.txtCookbookDateInserted.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCookbookDateInserted.Location = new System.Drawing.Point(170, 175);
            this.txtCookbookDateInserted.Name = "txtCookbookDateInserted";
            this.txtCookbookDateInserted.Size = new System.Drawing.Size(819, 34);
            this.txtCookbookDateInserted.TabIndex = 36;
            // 
            // tCookbookRecipes
            // 
            this.tblMain.SetColumnSpan(this.tCookbookRecipes, 2);
            this.tCookbookRecipes.Controls.Add(this.tpRecipes);
            this.tCookbookRecipes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tCookbookRecipes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tCookbookRecipes.Location = new System.Drawing.Point(3, 243);
            this.tCookbookRecipes.Name = "tCookbookRecipes";
            this.tCookbookRecipes.SelectedIndex = 0;
            this.tCookbookRecipes.Size = new System.Drawing.Size(986, 503);
            this.tCookbookRecipes.TabIndex = 37;
            // 
            // tpRecipes
            // 
            this.tpRecipes.Controls.Add(this.tblRecipes);
            this.tpRecipes.Location = new System.Drawing.Point(4, 37);
            this.tpRecipes.Name = "tpRecipes";
            this.tpRecipes.Padding = new System.Windows.Forms.Padding(3);
            this.tpRecipes.Size = new System.Drawing.Size(978, 462);
            this.tpRecipes.TabIndex = 0;
            this.tpRecipes.Text = "Recipes";
            this.tpRecipes.UseVisualStyleBackColor = true;
            // 
            // tblRecipes
            // 
            this.tblRecipes.ColumnCount = 1;
            this.tblRecipes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblRecipes.Controls.Add(this.btnSaveRecipe, 0, 0);
            this.tblRecipes.Controls.Add(this.gRecipe, 0, 1);
            this.tblRecipes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblRecipes.Location = new System.Drawing.Point(3, 3);
            this.tblRecipes.Name = "tblRecipes";
            this.tblRecipes.RowCount = 2;
            this.tblRecipes.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblRecipes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblRecipes.Size = new System.Drawing.Size(972, 456);
            this.tblRecipes.TabIndex = 1;
            // 
            // btnSaveRecipe
            // 
            this.btnSaveRecipe.AutoSize = true;
            this.btnSaveRecipe.Location = new System.Drawing.Point(3, 3);
            this.btnSaveRecipe.Name = "btnSaveRecipe";
            this.btnSaveRecipe.Size = new System.Drawing.Size(63, 38);
            this.btnSaveRecipe.TabIndex = 0;
            this.btnSaveRecipe.Text = "Save";
            this.btnSaveRecipe.UseVisualStyleBackColor = true;
            // 
            // gRecipe
            // 
            this.gRecipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gRecipe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gRecipe.Location = new System.Drawing.Point(3, 47);
            this.gRecipe.Name = "gRecipe";
            this.gRecipe.RowHeadersWidth = 51;
            this.gRecipe.RowTemplate.Height = 29;
            this.gRecipe.Size = new System.Drawing.Size(966, 406);
            this.gRecipe.TabIndex = 1;
            // 
            // tblButtons
            // 
            this.tblButtons.AutoSize = true;
            this.tblButtons.ColumnCount = 3;
            this.tblMain.SetColumnSpan(this.tblButtons, 2);
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 99.99999F));
            this.tblButtons.Controls.Add(this.BtnDelete, 1, 0);
            this.tblButtons.Controls.Add(this.btnSave, 0, 0);
            this.tblButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblButtons.Location = new System.Drawing.Point(3, 3);
            this.tblButtons.Name = "tblButtons";
            this.tblButtons.RowCount = 1;
            this.tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblButtons.Size = new System.Drawing.Size(986, 44);
            this.tblButtons.TabIndex = 31;
            // 
            // BtnDelete
            // 
            this.BtnDelete.AutoSize = true;
            this.BtnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnDelete.Location = new System.Drawing.Point(103, 3);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(78, 38);
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
            // ckbIsActive
            // 
            this.ckbIsActive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ckbIsActive.AutoSize = true;
            this.ckbIsActive.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckbIsActive.Location = new System.Drawing.Point(170, 215);
            this.ckbIsActive.Name = "ckbIsActive";
            this.ckbIsActive.Size = new System.Drawing.Size(18, 22);
            this.ckbIsActive.TabIndex = 38;
            this.ckbIsActive.UseVisualStyleBackColor = true;
            // 
            // frmCookbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 749);
            this.Controls.Add(this.tblMain);
            this.Name = "frmCookbook";
            this.Text = "frmCookbook";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tCookbookRecipes.ResumeLayout(false);
            this.tpRecipes.ResumeLayout(false);
            this.tblRecipes.ResumeLayout(false);
            this.tblRecipes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gRecipe)).EndInit();
            this.tblButtons.ResumeLayout(false);
            this.tblButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private TextBox txtCookbookName;
        private Label lblCaptionStatusActive;
        private Label lblCaptionDateCreated;
        private Label lblCaptionPrice;
        private Label lblCaptionName;
        private TextBox txtCookbookPrice;
        private Label lblCaptionUser;
        private ComboBox lstUserName;
        private TextBox txtCookbookDateInserted;
        private TabControl tCookbookRecipes;
        private TabPage tpRecipes;
        private TableLayoutPanel tblRecipes;
        private Button btnSaveRecipe;
        private DataGridView gRecipe;
        private TableLayoutPanel tblButtons;
        private Button BtnDelete;
        private Button btnSave;
        private CheckBox ckbIsActive;
    }
}