namespace RecipeWinForms
{
    partial class frmDataMaintenance
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
            this.btnSave = new System.Windows.Forms.Button();
            this.gData = new System.Windows.Forms.DataGridView();
            this.pnlOptionButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.optUsers = new System.Windows.Forms.RadioButton();
            this.optCuisine = new System.Windows.Forms.RadioButton();
            this.optIngredient = new System.Windows.Forms.RadioButton();
            this.optMeasurement = new System.Windows.Forms.RadioButton();
            this.optCourse = new System.Windows.Forms.RadioButton();
            this.tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gData)).BeginInit();
            this.pnlOptionButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.45455F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.54546F));
            this.tblMain.Controls.Add(this.btnSave, 0, 0);
            this.tblMain.Controls.Add(this.gData, 1, 1);
            this.tblMain.Controls.Add(this.pnlOptionButtons, 0, 1);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Margin = new System.Windows.Forms.Padding(4);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 2;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.Size = new System.Drawing.Size(800, 450);
            this.tblMain.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Location = new System.Drawing.Point(4, 4);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(50, 41);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // gData
            // 
            this.gData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gData.Location = new System.Drawing.Point(174, 52);
            this.gData.Name = "gData";
            this.gData.RowHeadersWidth = 51;
            this.gData.RowTemplate.Height = 29;
            this.gData.Size = new System.Drawing.Size(623, 575);
            this.gData.TabIndex = 1;
            // 
            // pnlOptionButtons
            // 
            this.pnlOptionButtons.Controls.Add(this.optUsers);
            this.pnlOptionButtons.Controls.Add(this.optCuisine);
            this.pnlOptionButtons.Controls.Add(this.optIngredient);
            this.pnlOptionButtons.Controls.Add(this.optMeasurement);
            this.pnlOptionButtons.Controls.Add(this.optCourse);
            this.pnlOptionButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOptionButtons.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlOptionButtons.Location = new System.Drawing.Point(3, 52);
            this.pnlOptionButtons.Name = "pnlOptionButtons";
            this.pnlOptionButtons.Size = new System.Drawing.Size(165, 575);
            this.pnlOptionButtons.TabIndex = 2;
            // 
            // optUsers
            // 
            this.optUsers.AutoSize = true;
            this.optUsers.Checked = true;
            this.optUsers.Location = new System.Drawing.Point(3, 3);
            this.optUsers.Name = "optUsers";
            this.optUsers.Size = new System.Drawing.Size(65, 24);
            this.optUsers.TabIndex = 0;
            this.optUsers.TabStop = true;
            this.optUsers.Text = "Users";
            this.optUsers.UseVisualStyleBackColor = true;
            // 
            // optCuisine
            // 
            this.optCuisine.AutoSize = true;
            this.optCuisine.Location = new System.Drawing.Point(3, 33);
            this.optCuisine.Name = "optCuisine";
            this.optCuisine.Size = new System.Drawing.Size(83, 24);
            this.optCuisine.TabIndex = 1;
            this.optCuisine.Text = "Cuisines";
            this.optCuisine.UseVisualStyleBackColor = true;
            // 
            // optIngredient
            // 
            this.optIngredient.AutoSize = true;
            this.optIngredient.Location = new System.Drawing.Point(3, 63);
            this.optIngredient.Name = "optIngredient";
            this.optIngredient.Size = new System.Drawing.Size(104, 24);
            this.optIngredient.TabIndex = 2;
            this.optIngredient.Text = "Ingredients";
            this.optIngredient.UseVisualStyleBackColor = true;
            // 
            // optMeasurement
            // 
            this.optMeasurement.AutoSize = true;
            this.optMeasurement.Location = new System.Drawing.Point(3, 93);
            this.optMeasurement.Name = "optMeasurement";
            this.optMeasurement.Size = new System.Drawing.Size(126, 24);
            this.optMeasurement.TabIndex = 3;
            this.optMeasurement.Text = "Measurements";
            this.optMeasurement.UseVisualStyleBackColor = true;
            // 
            // optCourse
            // 
            this.optCourse.AutoSize = true;
            this.optCourse.Location = new System.Drawing.Point(3, 123);
            this.optCourse.Name = "optCourse";
            this.optCourse.Size = new System.Drawing.Size(81, 24);
            this.optCourse.TabIndex = 4;
            this.optCourse.Text = "Courses";
            this.optCourse.UseVisualStyleBackColor = true;
            // 
            // frmDataMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tblMain);
            this.Name = "frmDataMaintenance";
            this.Text = "Data Maintenance";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gData)).EndInit();
            this.pnlOptionButtons.ResumeLayout(false);
            this.pnlOptionButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private Button btnSave;
        private DataGridView gData;
        private FlowLayoutPanel pnlOptionButtons;
        private RadioButton optUsers;
        private RadioButton optCuisine;
        private RadioButton optIngredient;
        private RadioButton optMeasurement;
        private RadioButton optCourse;
    }
}