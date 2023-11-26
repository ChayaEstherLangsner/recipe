namespace RecipeWinForms
{
    partial class frmListMeals
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
            this.gMain = new System.Windows.Forms.DataGridView();
            this.tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gMain)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.Controls.Add(this.gMain, 0, 0);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 1;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.Size = new System.Drawing.Size(597, 509);
            this.tblMain.TabIndex = 1;
            // 
            // gMain
            // 
            this.gMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMain.Location = new System.Drawing.Point(3, 3);
            this.gMain.Name = "gMain";
            this.gMain.RowHeadersWidth = 51;
            this.gMain.RowTemplate.Height = 29;
            this.gMain.Size = new System.Drawing.Size(591, 503);
            this.gMain.TabIndex = 1;
            // 
            // frmListMeals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 509);
            this.Controls.Add(this.tblMain);
            this.Name = "frmListMeals";
            this.Text = "List Meals";
            this.tblMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TableLayoutPanel tblMain;
        private DataGridView gMain;
    }
}