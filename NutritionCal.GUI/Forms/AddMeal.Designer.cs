namespace NutritionCal.GUI.Forms
{
    partial class AddMeal
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
            this.components = new System.ComponentModel.Container();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.foodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proteinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carbsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caloriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calCaloriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMealItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbResults = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblMeasuement = new System.Windows.Forms.Label();
            this.txtMeassurment = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMealItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(199, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(79, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Meal Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(285, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(217, 22);
            this.txtName.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.foodNameDataGridViewTextBoxColumn,
            this.measureDataGridViewTextBoxColumn,
            this.proteinDataGridViewTextBoxColumn,
            this.carbsDataGridViewTextBoxColumn,
            this.fatDataGridViewTextBoxColumn,
            this.caloriesDataGridViewTextBoxColumn,
            this.calCaloriesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.iMealItemBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(55, 262);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(744, 159);
            this.dataGridView1.TabIndex = 2;
            // 
            // foodNameDataGridViewTextBoxColumn
            // 
            this.foodNameDataGridViewTextBoxColumn.DataPropertyName = "foodName";
            this.foodNameDataGridViewTextBoxColumn.HeaderText = "foodName";
            this.foodNameDataGridViewTextBoxColumn.Name = "foodNameDataGridViewTextBoxColumn";
            this.foodNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // measureDataGridViewTextBoxColumn
            // 
            this.measureDataGridViewTextBoxColumn.DataPropertyName = "Measure";
            this.measureDataGridViewTextBoxColumn.HeaderText = "Measure";
            this.measureDataGridViewTextBoxColumn.Name = "measureDataGridViewTextBoxColumn";
            // 
            // proteinDataGridViewTextBoxColumn
            // 
            this.proteinDataGridViewTextBoxColumn.DataPropertyName = "Protein";
            this.proteinDataGridViewTextBoxColumn.HeaderText = "Protein";
            this.proteinDataGridViewTextBoxColumn.Name = "proteinDataGridViewTextBoxColumn";
            this.proteinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carbsDataGridViewTextBoxColumn
            // 
            this.carbsDataGridViewTextBoxColumn.DataPropertyName = "Carbs";
            this.carbsDataGridViewTextBoxColumn.HeaderText = "Carbs";
            this.carbsDataGridViewTextBoxColumn.Name = "carbsDataGridViewTextBoxColumn";
            this.carbsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fatDataGridViewTextBoxColumn
            // 
            this.fatDataGridViewTextBoxColumn.DataPropertyName = "Fat";
            this.fatDataGridViewTextBoxColumn.HeaderText = "Fat";
            this.fatDataGridViewTextBoxColumn.Name = "fatDataGridViewTextBoxColumn";
            this.fatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // caloriesDataGridViewTextBoxColumn
            // 
            this.caloriesDataGridViewTextBoxColumn.DataPropertyName = "Calories";
            this.caloriesDataGridViewTextBoxColumn.HeaderText = "Calories";
            this.caloriesDataGridViewTextBoxColumn.Name = "caloriesDataGridViewTextBoxColumn";
            this.caloriesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // calCaloriesDataGridViewTextBoxColumn
            // 
            this.calCaloriesDataGridViewTextBoxColumn.DataPropertyName = "CalCalories";
            this.calCaloriesDataGridViewTextBoxColumn.HeaderText = "CalCalories";
            this.calCaloriesDataGridViewTextBoxColumn.Name = "calCaloriesDataGridViewTextBoxColumn";
            this.calCaloriesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iMealItemBindingSource
            // 
            this.iMealItemBindingSource.DataSource = typeof(NutritionCal.Common.Abstraction.IMealItem);
            // 
            // lbResults
            // 
            this.lbResults.FormattingEnabled = true;
            this.lbResults.ItemHeight = 16;
            this.lbResults.Location = new System.Drawing.Point(231, 115);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(323, 68);
            this.lbResults.TabIndex = 7;
            this.lbResults.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(479, 74);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(287, 75);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(186, 22);
            this.txtSearch.TabIndex = 5;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(228, 80);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(53, 17);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Search";
            // 
            // lblMeasuement
            // 
            this.lblMeasuement.AutoSize = true;
            this.lblMeasuement.Location = new System.Drawing.Point(231, 205);
            this.lblMeasuement.Name = "lblMeasuement";
            this.lblMeasuement.Size = new System.Drawing.Size(94, 17);
            this.lblMeasuement.TabIndex = 8;
            this.lblMeasuement.Text = "Measurement";
            // 
            // txtMeassurment
            // 
            this.txtMeassurment.Location = new System.Drawing.Point(332, 205);
            this.txtMeassurment.Name = "txtMeassurment";
            this.txtMeassurment.Size = new System.Drawing.Size(100, 22);
            this.txtMeassurment.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(452, 204);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(287, 466);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(431, 466);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddMeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 521);
            this.ControlBox = false;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtMeassurment);
            this.Controls.Add(this.lblMeasuement);
            this.Controls.Add(this.lbResults);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AddMeal";
            this.Text = "Nutrition Cal - Add meal";
            this.Load += new System.EventHandler(this.AddMeal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMealItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource iMealItemBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn measureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proteinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carbsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caloriesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calCaloriesDataGridViewTextBoxColumn;
        private System.Windows.Forms.ListBox lbResults;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblMeasuement;
        private System.Windows.Forms.TextBox txtMeassurment;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}