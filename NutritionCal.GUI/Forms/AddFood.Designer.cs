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
            this.btnCancel.Location = new System.Drawing.Point(3, 191);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblSave
            // 
            this.lblSave.Location = new System.Drawing.Point(116, 191);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(75, 23);
            this.lblSave.TabIndex = 1;
            this.lblSave.Text = "Save";
            this.lblSave.UseVisualStyleBackColor = true;
            this.lblSave.Click += new System.EventHandler(this.lblSave_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 17);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name :";
            // 
            // lblMessure
            // 
            this.lblMessure.AutoSize = true;
            this.lblMessure.Location = new System.Drawing.Point(3, 28);
            this.lblMessure.Name = "lblMessure";
            this.lblMessure.Size = new System.Drawing.Size(101, 17);
            this.lblMessure.TabIndex = 3;
            this.lblMessure.Text = "Messurement :";
            // 
            // lblProtein
            // 
            this.lblProtein.AutoSize = true;
            this.lblProtein.Location = new System.Drawing.Point(3, 56);
            this.lblProtein.Name = "lblProtein";
            this.lblProtein.Size = new System.Drawing.Size(61, 17);
            this.lblProtein.TabIndex = 4;
            this.lblProtein.Text = "Protien :";
            // 
            // lblCarbs
            // 
            this.lblCarbs.AutoSize = true;
            this.lblCarbs.Location = new System.Drawing.Point(3, 84);
            this.lblCarbs.Name = "lblCarbs";
            this.lblCarbs.Size = new System.Drawing.Size(53, 17);
            this.lblCarbs.TabIndex = 5;
            this.lblCarbs.Text = "Carbs :";
            // 
            // lblFats
            // 
            this.lblFats.AutoSize = true;
            this.lblFats.Location = new System.Drawing.Point(3, 112);
            this.lblFats.Name = "lblFats";
            this.lblFats.Size = new System.Drawing.Size(43, 17);
            this.lblFats.TabIndex = 6;
            this.lblFats.Text = "Fats :";
            // 
            // lblCalories
            // 
            this.lblCalories.AutoSize = true;
            this.lblCalories.Location = new System.Drawing.Point(3, 140);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(67, 17);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(323, 230);
            this.tableLayoutPanel1.TabIndex = 8;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(116, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(204, 22);
            this.txtName.TabIndex = 8;
            // 
            // txtMeasure
            // 
            this.txtMeasure.Location = new System.Drawing.Point(116, 31);
            this.txtMeasure.Name = "txtMeasure";
            this.txtMeasure.Size = new System.Drawing.Size(100, 22);
            this.txtMeasure.TabIndex = 9;
            // 
            // txtProtein
            // 
            this.txtProtein.Location = new System.Drawing.Point(116, 59);
            this.txtProtein.Name = "txtProtein";
            this.txtProtein.Size = new System.Drawing.Size(100, 22);
            this.txtProtein.TabIndex = 10;
            // 
            // txtFats
            // 
            this.txtFats.Location = new System.Drawing.Point(116, 115);
            this.txtFats.Name = "txtFats";
            this.txtFats.Size = new System.Drawing.Size(100, 22);
            this.txtFats.TabIndex = 12;
            // 
            // txtCarbs
            // 
            this.txtCarbs.Location = new System.Drawing.Point(116, 87);
            this.txtCarbs.Name = "txtCarbs";
            this.txtCarbs.Size = new System.Drawing.Size(100, 22);
            this.txtCarbs.TabIndex = 11;
            // 
            // txtCalories
            // 
            this.txtCalories.Location = new System.Drawing.Point(116, 143);
            this.txtCalories.Name = "txtCalories";
            this.txtCalories.Size = new System.Drawing.Size(100, 22);
            this.txtCalories.TabIndex = 13;
            // 
            // AddFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(350, 248);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
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