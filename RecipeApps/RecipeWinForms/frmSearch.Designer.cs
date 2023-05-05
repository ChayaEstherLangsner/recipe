namespace RecipeWinForms
{
    partial class frmSearch
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
            this.tblSearch = new System.Windows.Forms.TableLayoutPanel();
            this.lblRecipeName = new System.Windows.Forms.Label();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.gRecipe = new System.Windows.Forms.DataGridView();
            this.tblSearch.SuspendLayout();
            this.tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gRecipe)).BeginInit();
            this.SuspendLayout();
            // 
            // tblSearch
            // 
            this.tblSearch.AutoSize = true;
            this.tblSearch.ColumnCount = 3;
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tblSearch.Controls.Add(this.lblRecipeName, 0, 0);
            this.tblSearch.Controls.Add(this.txtRecipeName, 1, 0);
            this.tblSearch.Controls.Add(this.btnSearch, 2, 0);
            this.tblSearch.Location = new System.Drawing.Point(3, 3);
            this.tblSearch.Name = "tblSearch";
            this.tblSearch.RowCount = 1;
            this.tblSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblSearch.Size = new System.Drawing.Size(292, 39);
            this.tblSearch.TabIndex = 0;
            // 
            // lblRecipeName
            // 
            this.lblRecipeName.AutoSize = true;
            this.lblRecipeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecipeName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRecipeName.Location = new System.Drawing.Point(3, 0);
            this.lblRecipeName.Name = "lblRecipeName";
            this.lblRecipeName.Size = new System.Drawing.Size(91, 40);
            this.lblRecipeName.TabIndex = 0;
            this.lblRecipeName.Text = "Recipe:";
            this.lblRecipeName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtRecipeName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRecipeName.Location = new System.Drawing.Point(100, 3);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(91, 34);
            this.txtRecipeName.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(197, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 34);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Controls.Add(this.tblSearch, 0, 0);
            this.tblMain.Controls.Add(this.gRecipe, 0, 1);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 2;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.840864F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.15913F));
            this.tblMain.Size = new System.Drawing.Size(597, 509);
            this.tblMain.TabIndex = 1;
            // 
            // gRecipe
            // 
            this.gRecipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblMain.SetColumnSpan(this.gRecipe, 2);
            this.gRecipe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gRecipe.Location = new System.Drawing.Point(3, 48);
            this.gRecipe.Name = "gRecipe";
            this.gRecipe.RowHeadersWidth = 51;
            this.gRecipe.RowTemplate.Height = 29;
            this.gRecipe.Size = new System.Drawing.Size(591, 458);
            this.gRecipe.TabIndex = 1;
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 509);
            this.Controls.Add(this.tblMain);
            this.Name = "frmSearch";
            this.Text = "frmSearch";
            this.tblSearch.ResumeLayout(false);
            this.tblSearch.PerformLayout();
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gRecipe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblSearch;
        private Label lblRecipeName;
        private TextBox txtRecipeName;
        private Button btnSearch;
        private TableLayoutPanel tblMain;
        private DataGridView gRecipe;
    }
}