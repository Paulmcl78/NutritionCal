namespace NutritionCal.GUI.Forms
{
    partial class EditMeal
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
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbResults = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.foodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proteinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carbsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caloriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calCaloriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMealItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlItems = new System.Windows.Forms.Panel();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblMealName = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMealItemBindingSource)).BeginInit();
            this.pnlItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(113, 33);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(153, 28);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(104, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(261, 28);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
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
            this.lbResults.Location = new System.Drawing.Point(102, 65);
            this.lbResults.Margin = new System.Windows.Forms.Padding(2);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(262, 69);
            this.lbResults.TabIndex = 3;
            this.lbResults.Visible = false;
            this.lbResults.SelectedIndexChanged += new System.EventHandler(this.lbResults_SelectedIndexChanged);
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
            this.dataGridView1.Location = new System.Drawing.Point(14, 43);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(517, 164);
            this.dataGridView1.TabIndex = 4;
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
            // pnlItems
            // 
            this.pnlItems.Controls.Add(this.btDelete);
            this.pnlItems.Controls.Add(this.btnAddFood);
            this.pnlItems.Controls.Add(this.btSave);
            this.pnlItems.Controls.Add(this.txtName);
            this.pnlItems.Controls.Add(this.lblMealName);
            this.pnlItems.Controls.Add(this.dataGridView1);
            this.pnlItems.Location = new System.Drawing.Point(11, 139);
            this.pnlItems.Name = "pnlItems";
            this.pnlItems.Size = new System.Drawing.Size(579, 254);
            this.pnlItems.TabIndex = 5;
            this.pnlItems.Visible = false;
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(311, 13);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(75, 23);
            this.btnAddFood.TabIndex = 8;
            this.btnAddFood.Text = "Add Food";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(278, 228);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 7;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(179, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 6;
            // 
            // lblMealName
            // 
            this.lblMealName.AutoSize = true;
            this.lblMealName.Location = new System.Drawing.Point(105, 13);
            this.lblMealName.Name = "lblMealName";
            this.lblMealName.Size = new System.Drawing.Size(67, 13);
            this.lblMealName.TabIndex = 5;
            this.lblMealName.Text = "Meal Name :";
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(322, 26);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 6;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(91, 228);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 9;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // EditMeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 435);
            this.ControlBox = false;
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.pnlItems);
            this.Controls.Add(this.lbResults);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditMeal";
            this.Text = "EditMeal";
            this.Load += new System.EventHandler(this.EditMeal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMealItemBindingSource)).EndInit();
            this.pnlItems.ResumeLayout(false);
            this.pnlItems.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lbResults;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn measureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proteinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carbsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caloriesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calCaloriesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource iMealItemBindingSource;
        private System.Windows.Forms.Panel pnlItems;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblMealName;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Button btDelete;
    }
}