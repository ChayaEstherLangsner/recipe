namespace RecipeWinForms
{
    partial class frmChangeStatus
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
            this.lblRecipeName = new System.Windows.Forms.Label();
            this.tblStatusDisplay = new System.Windows.Forms.TableLayoutPanel();
            this.lblRecipeDateDrafted = new System.Windows.Forms.Label();
            this.lblPublished = new System.Windows.Forms.Label();
            this.lblDrafted = new System.Windows.Forms.Label();
            this.lblArchived = new System.Windows.Forms.Label();
            this.lblStatusDates = new System.Windows.Forms.Label();
            this.lblRecipeDatePublished = new System.Windows.Forms.Label();
            this.lblRecipeDateArchived = new System.Windows.Forms.Label();
            this.tblBtns = new System.Windows.Forms.TableLayoutPanel();
            this.btnDrafted = new System.Windows.Forms.Button();
            this.btnPublished = new System.Windows.Forms.Button();
            this.btnArchived = new System.Windows.Forms.Button();
            this.tblCurrentStatus = new System.Windows.Forms.TableLayoutPanel();
            this.lblCurrentStatusCaption = new System.Windows.Forms.Label();
            this.lblRecipeStatus = new System.Windows.Forms.Label();
            this.tblMain.SuspendLayout();
            this.tblStatusDisplay.SuspendLayout();
            this.tblBtns.SuspendLayout();
            this.tblCurrentStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.Controls.Add(this.lblRecipeName, 0, 0);
            this.tblMain.Controls.Add(this.tblStatusDisplay, 0, 2);
            this.tblMain.Controls.Add(this.tblBtns, 0, 3);
            this.tblMain.Controls.Add(this.tblCurrentStatus, 0, 1);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 4;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.55556F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.44444F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.44444F));
            this.tblMain.Size = new System.Drawing.Size(800, 450);
            this.tblMain.TabIndex = 0;
            // 
            // lblRecipeName
            // 
            this.lblRecipeName.AutoSize = true;
            this.lblRecipeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecipeName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRecipeName.Location = new System.Drawing.Point(3, 0);
            this.lblRecipeName.Name = "lblRecipeName";
            this.lblRecipeName.Size = new System.Drawing.Size(794, 98);
            this.lblRecipeName.TabIndex = 0;
            this.lblRecipeName.Text = "Recipe Name";
            this.lblRecipeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblStatusDisplay
            // 
            this.tblStatusDisplay.ColumnCount = 5;
            this.tblStatusDisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblStatusDisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblStatusDisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblStatusDisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblStatusDisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblStatusDisplay.Controls.Add(this.lblRecipeDateDrafted, 1, 1);
            this.tblStatusDisplay.Controls.Add(this.lblPublished, 2, 0);
            this.tblStatusDisplay.Controls.Add(this.lblDrafted, 1, 0);
            this.tblStatusDisplay.Controls.Add(this.lblArchived, 3, 0);
            this.tblStatusDisplay.Controls.Add(this.lblStatusDates, 0, 1);
            this.tblStatusDisplay.Controls.Add(this.lblRecipeDatePublished, 2, 1);
            this.tblStatusDisplay.Controls.Add(this.lblRecipeDateArchived, 3, 1);
            this.tblStatusDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblStatusDisplay.Location = new System.Drawing.Point(3, 170);
            this.tblStatusDisplay.Name = "tblStatusDisplay";
            this.tblStatusDisplay.RowCount = 2;
            this.tblStatusDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.53846F));
            this.tblStatusDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.46154F));
            this.tblStatusDisplay.Size = new System.Drawing.Size(794, 130);
            this.tblStatusDisplay.TabIndex = 2;
            // 
            // lblRecipeDateDrafted
            // 
            this.lblRecipeDateDrafted.AutoSize = true;
            this.lblRecipeDateDrafted.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblRecipeDateDrafted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRecipeDateDrafted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecipeDateDrafted.Location = new System.Drawing.Point(168, 77);
            this.lblRecipeDateDrafted.Margin = new System.Windows.Forms.Padding(10);
            this.lblRecipeDateDrafted.Name = "lblRecipeDateDrafted";
            this.lblRecipeDateDrafted.Size = new System.Drawing.Size(138, 43);
            this.lblRecipeDateDrafted.TabIndex = 6;
            this.lblRecipeDateDrafted.Text = " ";
            this.lblRecipeDateDrafted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPublished
            // 
            this.lblPublished.AutoSize = true;
            this.lblPublished.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPublished.Location = new System.Drawing.Point(319, 0);
            this.lblPublished.Name = "lblPublished";
            this.lblPublished.Size = new System.Drawing.Size(152, 67);
            this.lblPublished.TabIndex = 2;
            this.lblPublished.Text = "Published";
            this.lblPublished.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDrafted
            // 
            this.lblDrafted.AutoSize = true;
            this.lblDrafted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDrafted.Location = new System.Drawing.Point(161, 0);
            this.lblDrafted.Name = "lblDrafted";
            this.lblDrafted.Size = new System.Drawing.Size(152, 67);
            this.lblDrafted.TabIndex = 0;
            this.lblDrafted.Text = "Drafted";
            this.lblDrafted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArchived
            // 
            this.lblArchived.AutoSize = true;
            this.lblArchived.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblArchived.Location = new System.Drawing.Point(477, 0);
            this.lblArchived.Name = "lblArchived";
            this.lblArchived.Size = new System.Drawing.Size(152, 67);
            this.lblArchived.TabIndex = 1;
            this.lblArchived.Text = "Archived";
            this.lblArchived.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatusDates
            // 
            this.lblStatusDates.AutoSize = true;
            this.lblStatusDates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatusDates.Location = new System.Drawing.Point(3, 67);
            this.lblStatusDates.Name = "lblStatusDates";
            this.lblStatusDates.Size = new System.Drawing.Size(152, 63);
            this.lblStatusDates.TabIndex = 3;
            this.lblStatusDates.Text = "Status Dates";
            this.lblStatusDates.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRecipeDatePublished
            // 
            this.lblRecipeDatePublished.AutoSize = true;
            this.lblRecipeDatePublished.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblRecipeDatePublished.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRecipeDatePublished.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecipeDatePublished.Location = new System.Drawing.Point(326, 77);
            this.lblRecipeDatePublished.Margin = new System.Windows.Forms.Padding(10);
            this.lblRecipeDatePublished.Name = "lblRecipeDatePublished";
            this.lblRecipeDatePublished.Size = new System.Drawing.Size(138, 43);
            this.lblRecipeDatePublished.TabIndex = 4;
            this.lblRecipeDatePublished.Text = " ";
            this.lblRecipeDatePublished.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRecipeDateArchived
            // 
            this.lblRecipeDateArchived.AutoSize = true;
            this.lblRecipeDateArchived.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblRecipeDateArchived.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRecipeDateArchived.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecipeDateArchived.Location = new System.Drawing.Point(484, 77);
            this.lblRecipeDateArchived.Margin = new System.Windows.Forms.Padding(10);
            this.lblRecipeDateArchived.Name = "lblRecipeDateArchived";
            this.lblRecipeDateArchived.Size = new System.Drawing.Size(138, 43);
            this.lblRecipeDateArchived.TabIndex = 5;
            this.lblRecipeDateArchived.Text = " ";
            this.lblRecipeDateArchived.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblBtns
            // 
            this.tblBtns.ColumnCount = 3;
            this.tblBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblBtns.Controls.Add(this.btnDrafted, 0, 0);
            this.tblBtns.Controls.Add(this.btnPublished, 1, 0);
            this.tblBtns.Controls.Add(this.btnArchived, 2, 0);
            this.tblBtns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblBtns.Location = new System.Drawing.Point(3, 306);
            this.tblBtns.Name = "tblBtns";
            this.tblBtns.RowCount = 1;
            this.tblBtns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblBtns.Size = new System.Drawing.Size(794, 141);
            this.tblBtns.TabIndex = 3;
            // 
            // btnDrafted
            // 
            this.btnDrafted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDrafted.Location = new System.Drawing.Point(40, 40);
            this.btnDrafted.Margin = new System.Windows.Forms.Padding(40);
            this.btnDrafted.Name = "btnDrafted";
            this.btnDrafted.Size = new System.Drawing.Size(184, 61);
            this.btnDrafted.TabIndex = 0;
            this.btnDrafted.Text = "Draft";
            this.btnDrafted.UseVisualStyleBackColor = true;
            // 
            // btnPublished
            // 
            this.btnPublished.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPublished.Location = new System.Drawing.Point(304, 40);
            this.btnPublished.Margin = new System.Windows.Forms.Padding(40);
            this.btnPublished.Name = "btnPublished";
            this.btnPublished.Size = new System.Drawing.Size(184, 61);
            this.btnPublished.TabIndex = 1;
            this.btnPublished.Text = "Publish";
            this.btnPublished.UseVisualStyleBackColor = true;
            // 
            // btnArchived
            // 
            this.btnArchived.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnArchived.Location = new System.Drawing.Point(568, 40);
            this.btnArchived.Margin = new System.Windows.Forms.Padding(40);
            this.btnArchived.Name = "btnArchived";
            this.btnArchived.Size = new System.Drawing.Size(186, 61);
            this.btnArchived.TabIndex = 2;
            this.btnArchived.Text = "Archive";
            this.btnArchived.UseVisualStyleBackColor = true;
            // 
            // tblCurrentStatus
            // 
            this.tblCurrentStatus.ColumnCount = 2;
            this.tblCurrentStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCurrentStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCurrentStatus.Controls.Add(this.lblCurrentStatusCaption, 0, 0);
            this.tblCurrentStatus.Controls.Add(this.lblRecipeStatus, 1, 0);
            this.tblCurrentStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCurrentStatus.Location = new System.Drawing.Point(3, 101);
            this.tblCurrentStatus.Name = "tblCurrentStatus";
            this.tblCurrentStatus.RowCount = 1;
            this.tblCurrentStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCurrentStatus.Size = new System.Drawing.Size(794, 63);
            this.tblCurrentStatus.TabIndex = 4;
            // 
            // lblCurrentStatusCaption
            // 
            this.lblCurrentStatusCaption.AutoSize = true;
            this.lblCurrentStatusCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurrentStatusCaption.Location = new System.Drawing.Point(3, 0);
            this.lblCurrentStatusCaption.Name = "lblCurrentStatusCaption";
            this.lblCurrentStatusCaption.Size = new System.Drawing.Size(391, 63);
            this.lblCurrentStatusCaption.TabIndex = 0;
            this.lblCurrentStatusCaption.Text = "Current Status:";
            this.lblCurrentStatusCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRecipeStatus
            // 
            this.lblRecipeStatus.AutoSize = true;
            this.lblRecipeStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecipeStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRecipeStatus.Location = new System.Drawing.Point(400, 0);
            this.lblRecipeStatus.Name = "lblRecipeStatus";
            this.lblRecipeStatus.Size = new System.Drawing.Size(391, 63);
            this.lblRecipeStatus.TabIndex = 1;
            this.lblRecipeStatus.Text = "hi";
            this.lblRecipeStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmChangeStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tblMain);
            this.Name = "frmChangeStatus";
            this.Text = "Recipe - Change Status";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tblStatusDisplay.ResumeLayout(false);
            this.tblStatusDisplay.PerformLayout();
            this.tblBtns.ResumeLayout(false);
            this.tblCurrentStatus.ResumeLayout(false);
            this.tblCurrentStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblRecipeName;
        private TableLayoutPanel tblStatusDisplay;
        private Label lblRecipeDateDrafted;
        private Label lblPublished;
        private Label lblDrafted;
        private Label lblArchived;
        private Label lblStatusDates;
        private Label lblRecipeDatePublished;
        private Label lblRecipeDateArchived;
        private TableLayoutPanel tblBtns;
        private Button btnDrafted;
        private Button btnPublished;
        private Button btnArchived;
        private TableLayoutPanel tblCurrentStatus;
        private Label lblCurrentStatusCaption;
        private Label lblRecipeStatus;
    }
}