namespace RecipeWinForms
{
    partial class frmAutoCreateCookbook
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
            this.lstUsers = new System.Windows.Forms.ComboBox();
            this.btnAutoCreate = new System.Windows.Forms.Button();
            this.tblMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Controls.Add(this.lstUsers, 0, 0);
            this.tblMain.Controls.Add(this.btnAutoCreate, 0, 1);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 2;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Size = new System.Drawing.Size(800, 450);
            this.tblMain.TabIndex = 4;
            // 
            // lstUsers
            // 
            this.lstUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.Location = new System.Drawing.Point(217, 98);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(365, 28);
            this.lstUsers.TabIndex = 2;
            // 
            // btnAutoCreate
            // 
            this.btnAutoCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAutoCreate.Location = new System.Drawing.Point(258, 303);
            this.btnAutoCreate.Name = "btnAutoCreate";
            this.btnAutoCreate.Size = new System.Drawing.Size(283, 68);
            this.btnAutoCreate.TabIndex = 3;
            this.btnAutoCreate.Text = "Clone";
            this.btnAutoCreate.UseVisualStyleBackColor = true;
            // 
            // frmAutoCreateCookbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tblMain);
            this.Name = "frmAutoCreateCookbook";
            this.Text = "Hearty Health - Auto-Create a Cookbook";
            this.tblMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private ComboBox lstUsers;
        private Button btnAutoCreate;
    }
}