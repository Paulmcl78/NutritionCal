namespace NutritionCal.GUI.Forms
{
    partial class EditFood
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
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbResults = new System.Windows.Forms.ListBox();
            this.tlpFood = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSave = new System.Windows.Forms.Button();
            this.lblCalories = new System.Windows.Forms.Label();
            this.lblMessure = new System.Windows.Forms.Label();
            this.lblFats = new System.Windows.Forms.Label();
            this.lblProtein = new System.Windows.Forms.Label();
            this.lblCarbs = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMeasure = new System.Windows.Forms.TextBox();
            this.txtProtein = new System.Windows.Forms.TextBox();
            this.txtFats = new System.Windows.Forms.TextBox();
            this.txtCarbs = new System.Windows.Forms.TextBox();
            this.txtCalories = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.tlpFood.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(8, 14);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(52, 10);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(140, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(196, 9);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 19);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbResults
            // 
            this.lbResults.FormattingEnabled = true;
            this.lbResults.Location = new System.Drawing.Point(10, 42);
            this.lbResults.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(243, 56);
            this.lbResults.TabIndex = 3;
            this.lbResults.Visible = false;
            this.lbResults.SelectedIndexChanged += new System.EventHandler(this.lbResults_SelectedIndexChanged);
            // 
            // tlpFood
            // 
            this.tlpFood.ColumnCount = 2;
            this.tlpFood.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.34973F));
            this.tlpFood.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.65027F));
            this.tlpFood.Controls.Add(this.lblName, 0, 0);
            this.tlpFood.Controls.Add(this.lblSave, 1, 7);
            this.tlpFood.Controls.Add(this.lblCalories, 0, 5);
            this.tlpFood.Controls.Add(this.lblMessure, 0, 1);
            this.tlpFood.Controls.Add(this.lblFats, 0, 4);
            this.tlpFood.Controls.Add(this.lblProtein, 0, 2);
            this.tlpFood.Controls.Add(this.lblCarbs, 0, 3);
            this.tlpFood.Controls.Add(this.txtName, 1, 0);
            this.tlpFood.Controls.Add(this.txtMeasure, 1, 1);
            this.tlpFood.Controls.Add(this.txtProtein, 1, 2);
            this.tlpFood.Controls.Add(this.txtFats, 1, 4);
            this.tlpFood.Controls.Add(this.txtCarbs, 1, 3);
            this.tlpFood.Controls.Add(this.txtCalories, 1, 5);
            this.tlpFood.Controls.Add(this.btDelete, 0, 7);
            this.tlpFood.Location = new System.Drawing.Point(10, 114);
            this.tlpFood.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlpFood.Name = "tlpFood";
            this.tlpFood.RowCount = 8;
            this.tlpFood.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFood.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFood.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFood.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFood.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFood.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFood.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpFood.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFood.Size = new System.Drawing.Size(242, 198);
            this.tlpFood.TabIndex = 9;
            this.tlpFood.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(2, 0);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name :";
            // 
            // lblSave
            // 
            this.lblSave.Location = new System.Drawing.Point(104, 162);
            this.lblSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(56, 19);
            this.lblSave.TabIndex = 1;
            this.lblSave.Text = "Save";
            this.lblSave.UseVisualStyleBackColor = true;
            this.lblSave.Click += new System.EventHandler(this.lblSave_Click);
            // 
            // lblCalories
            // 
            this.lblCalories.AutoSize = true;
            this.lblCalories.Location = new System.Drawing.Point(2, 120);
            this.lblCalories.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(50, 13);
            this.lblCalories.TabIndex = 7;
            this.lblCalories.Text = "Calories :";
            // 
            // lblMessure
            // 
            this.lblMessure.AutoSize = true;
            this.lblMessure.Location = new System.Drawing.Point(2, 24);
            this.lblMessure.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMessure.Name = "lblMessure";
            this.lblMessure.Size = new System.Drawing.Size(76, 13);
            this.lblMessure.TabIndex = 3;
            this.lblMessure.Text = "Messurement :";
            // 
            // lblFats
            // 
            this.lblFats.AutoSize = true;
            this.lblFats.Location = new System.Drawing.Point(2, 96);
            this.lblFats.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFats.Name = "lblFats";
            this.lblFats.Size = new System.Drawing.Size(33, 13);
            this.lblFats.TabIndex = 6;
            this.lblFats.Text = "Fats :";
            // 
            // lblProtein
            // 
            this.lblProtein.AutoSize = true;
            this.lblProtein.Location = new System.Drawing.Point(2, 48);
            this.lblProtein.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProtein.Name = "lblProtein";
            this.lblProtein.Size = new System.Drawing.Size(46, 13);
            this.lblProtein.TabIndex = 4;
            this.lblProtein.Text = "Protien :";
            // 
            // lblCarbs
            // 
            this.lblCarbs.AutoSize = true;
            this.lblCarbs.Location = new System.Drawing.Point(2, 72);
            this.lblCarbs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCarbs.Name = "lblCarbs";
            this.lblCarbs.Size = new System.Drawing.Size(40, 13);
            this.lblCarbs.TabIndex = 5;
            this.lblCarbs.Text = "Carbs :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(104, 2);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(136, 20);
            this.txtName.TabIndex = 8;
            // 
            // txtMeasure
            // 
            this.txtMeasure.Location = new System.Drawing.Point(104, 26);
            this.txtMeasure.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMeasure.Name = "txtMeasure";
            this.txtMeasure.Size = new System.Drawing.Size(76, 20);
            this.txtMeasure.TabIndex = 9;
            // 
            // txtProtein
            // 
            this.txtProtein.Location = new System.Drawing.Point(104, 50);
            this.txtProtein.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProtein.Name = "txtProtein";
            this.txtProtein.Size = new System.Drawing.Size(76, 20);
            this.txtProtein.TabIndex = 10;
            // 
            // txtFats
            // 
            this.txtFats.Location = new System.Drawing.Point(104, 98);
            this.txtFats.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFats.Name = "txtFats";
            this.txtFats.Size = new System.Drawing.Size(76, 20);
            this.txtFats.TabIndex = 12;
            // 
            // txtCarbs
            // 
            this.txtCarbs.Location = new System.Drawing.Point(104, 74);
            this.txtCarbs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCarbs.Name = "txtCarbs";
            this.txtCarbs.Size = new System.Drawing.Size(76, 20);
            this.txtCarbs.TabIndex = 11;
            // 
            // txtCalories
            // 
            this.txtCalories.Location = new System.Drawing.Point(104, 122);
            this.txtCalories.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCalories.Name = "txtCalories";
            this.txtCalories.Size = new System.Drawing.Size(76, 20);
            this.txtCalories.TabIndex = 13;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(257, 9);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(56, 19);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(3, 163);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(56, 19);
            this.btDelete.TabIndex = 14;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // EditFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(362, 344);
            this.ControlBox = false;
            this.Controls.Add(this.tlpFood);
            this.Controls.Add(this.lbResults);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EditFood";
            this.Text = "Nutrition Cal - Edit food";
            this.Load += new System.EventHandler(this.EditFood_Load);
            this.tlpFood.ResumeLayout(false);
            this.tlpFood.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lbResults;
        private System.Windows.Forms.TableLayoutPanel tlpFood;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button lblSave;
        private System.Windows.Forms.Label lblCalories;
        private System.Windows.Forms.Label lblMessure;
        private System.Windows.Forms.Label lblFats;
        private System.Windows.Forms.Label lblProtein;
        private System.Windows.Forms.Label lblCarbs;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMeasure;
        private System.Windows.Forms.TextBox txtProtein;
        private System.Windows.Forms.TextBox txtFats;
        private System.Windows.Forms.TextBox txtCarbs;
        private System.Windows.Forms.TextBox txtCalories;
        private System.Windows.Forms.Button btDelete;
    }
}