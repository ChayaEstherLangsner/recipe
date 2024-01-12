namespace RecipeWinForms
{
    partial class frmDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnRecipeList = new System.Windows.Forms.Button();
            this.btnMealList = new System.Windows.Forms.Button();
            this.btnCookbookList = new System.Windows.Forms.Button();
            this.gOverview = new System.Windows.Forms.DataGridView();
            this.tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gOverview)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 3;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblMain.Controls.Add(this.lblAppName, 0, 0);
            this.tblMain.Controls.Add(this.lblDesc, 0, 1);
            this.tblMain.Controls.Add(this.btnRecipeList, 0, 3);
            this.tblMain.Controls.Add(this.btnMealList, 1, 3);
            this.tblMain.Controls.Add(this.btnCookbookList, 2, 3);
            this.tblMain.Controls.Add(this.gOverview, 1, 2);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 4;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMain.Size = new System.Drawing.Size(842, 581);
            this.tblMain.TabIndex = 0;
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.tblMain.SetColumnSpan(this.lblAppName, 3);
            this.lblAppName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAppName.Location = new System.Drawing.Point(3, 0);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(836, 145);
            this.lblAppName.TabIndex = 0;
            this.lblAppName.Text = "Hearty Hearth Desktop App";
            this.lblAppName.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.tblMain.SetColumnSpan(this.lblDesc, 3);
            this.lblDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDesc.Location = new System.Drawing.Point(3, 145);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(836, 145);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "Welcome to the Hearty Hearth desktop app. In this app you can create recipes and " +
    "cookbooks. You can also....";
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRecipeList
            // 
            this.btnRecipeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRecipeList.Location = new System.Drawing.Point(25, 460);
            this.btnRecipeList.Margin = new System.Windows.Forms.Padding(25);
            this.btnRecipeList.Name = "btnRecipeList";
            this.btnRecipeList.Size = new System.Drawing.Size(230, 96);
            this.btnRecipeList.TabIndex = 3;
            this.btnRecipeList.Text = "Recipe List";
            this.btnRecipeList.UseVisualStyleBackColor = true;
            // 
            // btnMealList
            // 
            this.btnMealList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMealList.Location = new System.Drawing.Point(305, 460);
            this.btnMealList.Margin = new System.Windows.Forms.Padding(25);
            this.btnMealList.Name = "btnMealList";
            this.btnMealList.Size = new System.Drawing.Size(230, 96);
            this.btnMealList.TabIndex = 4;
            this.btnMealList.Text = "Meal List";
            this.btnMealList.UseVisualStyleBackColor = true;
            // 
            // btnCookbookList
            // 
            this.btnCookbookList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCookbookList.Location = new System.Drawing.Point(585, 460);
            this.btnCookbookList.Margin = new System.Windows.Forms.Padding(25);
            this.btnCookbookList.Name = "btnCookbookList";
            this.btnCookbookList.Size = new System.Drawing.Size(232, 96);
            this.btnCookbookList.TabIndex = 5;
            this.btnCookbookList.Text = "Cookbook List";
            this.btnCookbookList.UseVisualStyleBackColor = true;
            // 
            // gOverview
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gOverview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gOverview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gOverview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gOverview.DefaultCellStyle = dataGridViewCellStyle3;
            this.gOverview.Location = new System.Drawing.Point(280, 290);
            this.gOverview.Margin = new System.Windows.Forms.Padding(0);
            this.gOverview.Name = "gOverview";
            this.gOverview.RowHeadersWidth = 51;
            this.gOverview.RowTemplate.Height = 29;
            this.gOverview.Size = new System.Drawing.Size(280, 145);
            this.gOverview.TabIndex = 2;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 581);
            this.Controls.Add(this.tblMain);
            this.Name = "frmDashboard";
            this.Text = "Hearty Hearth - Dashboard";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gOverview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblAppName;
        private Label lblDesc;
        private Button btnRecipeList;
        private Button btnMealList;
        private Button btnCookbookList;
        private DataGridView gOverview;
    }
}