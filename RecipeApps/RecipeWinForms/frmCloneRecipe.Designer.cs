namespace RecipeWinForms
{
    partial class frmCloneRecipe
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
            this.lstRecipe = new System.Windows.Forms.ComboBox();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.btnClone = new System.Windows.Forms.Button();
            this.tblMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstRecipe
            // 
            this.lstRecipe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstRecipe.FormattingEnabled = true;
            this.lstRecipe.Location = new System.Drawing.Point(203, 98);
            this.lstRecipe.Name = "lstRecipe";
            this.lstRecipe.Size = new System.Drawing.Size(365, 28);
            this.lstRecipe.TabIndex = 2;
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Controls.Add(this.lstRecipe, 0, 0);
            this.tblMain.Controls.Add(this.btnClone, 0, 1);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 2;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Size = new System.Drawing.Size(772, 450);
            this.tblMain.TabIndex = 3;
            // 
            // btnClone
            // 
            this.btnClone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClone.Location = new System.Drawing.Point(244, 303);
            this.btnClone.Name = "btnClone";
            this.btnClone.Size = new System.Drawing.Size(283, 68);
            this.btnClone.TabIndex = 3;
            this.btnClone.Text = "Clone";
            this.btnClone.UseVisualStyleBackColor = true;
            // 
            // frmCloneRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 450);
            this.Controls.Add(this.tblMain);
            this.Name = "frmCloneRecipe";
            this.Text = "Hearty Health - Clone a Recipe";
            this.tblMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox lstRecipe;
        private TableLayoutPanel tblMain;
        private Button btnClone;
    }
}