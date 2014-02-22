namespace NutritionCal.GUI.Forms
{
    partial class AddFood
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblSave = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMessure = new System.Windows.Forms.Label();
            this.lblProtein = new System.Windows.Forms.Label();
            this.lblCarbs = new System.Windows.Forms.Label();
            this.lblFats = new System.Windows.Forms.Label();
            this.lblCalories = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMeasure = new System.Windows.Forms.TextBox();
            this.txtProtein = new System.Windows.Forms.TextBox();
            this.txtFats = new System.Windows.Forms.TextBox();
            this.txtCarbs = new System.Windows.Forms.TextBox();
            this.txtCalories = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(2, 162);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(56, 19);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblSave
            // 
            this.lblSave.Location = new System.Drawing.Point(87, 162);
            this.lblSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(56, 19);
            this.lblSave.TabIndex = 1;
            this.lblSave.Text = "Save";
            this.lblSave.UseVisualStyleBackColor = true;
            this.lblSave.Click += new System.EventHandler(this.lblSave_Click);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.29412F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.70588F));
            this.tableLayoutPanel1.Controls.Add(this.lblName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSave, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblCalories, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblMessure, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFats, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblProtein, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCarbs, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtMeasure, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtProtein, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtFats, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtCarbs, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtCalories, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 10);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(242, 187);
            this.tableLayoutPanel1.TabIndex = 8;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(87, 2);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(153, 20);
            this.txtName.TabIndex = 8;
            // 
            // txtMeasure
            // 
            this.txtMeasure.Location = new System.Drawing.Point(87, 26);
            this.txtMeasure.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMeasure.Name = "txtMeasure";
            this.txtMeasure.Size = new System.Drawing.Size(76, 20);
            this.txtMeasure.TabIndex = 9;
            // 
            // txtProtein
            // 
            this.txtProtein.Location = new System.Drawing.Point(87, 50);
            this.txtProtein.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProtein.Name = "txtProtein";
            this.txtProtein.Size = new System.Drawing.Size(76, 20);
            this.txtProtein.TabIndex = 10;
            // 
            // txtFats
            // 
            this.txtFats.Location = new System.Drawing.Point(87, 98);
            this.txtFats.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFats.Name = "txtFats";
            this.txtFats.Size = new System.Drawing.Size(76, 20);
            this.txtFats.TabIndex = 12;
            // 
            // txtCarbs
            // 
            this.txtCarbs.Location = new System.Drawing.Point(87, 74);
            this.txtCarbs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCarbs.Name = "txtCarbs";
            this.txtCarbs.Size = new System.Drawing.Size(76, 20);
            this.txtCarbs.TabIndex = 11;
            // 
            // txtCalories
            // 
            this.txtCalories.Location = new System.Drawing.Point(87, 122);
            this.txtCalories.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCalories.Name = "txtCalories";
            this.txtCalories.Size = new System.Drawing.Size(76, 20);
            this.txtCalories.TabIndex = 13;
            // 
            // AddFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(262, 211);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nutrition Cal - Add new food";
            this.Load += new System.EventHandler(this.AddFood_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button lblSave;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMessure;
        private System.Windows.Forms.Label lblProtein;
        private System.Windows.Forms.Label lblCarbs;
        private System.Windows.Forms.Label lblFats;
        private System.Windows.Forms.Label lblCalories;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMeasure;
        private System.Windows.Forms.TextBox txtProtein;
        private System.Windows.Forms.TextBox txtFats;
        private System.Windows.Forms.TextBox txtCarbs;
        private System.Windows.Forms.TextBox txtCalories;
    }
}