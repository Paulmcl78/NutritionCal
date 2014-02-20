namespace NutritionCal.GUI.Forms
{
    partial class FrmResults
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCalories = new System.Windows.Forms.TextBox();
            this.txtProtein = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCarbs = new System.Windows.Forms.TextBox();
            this.txtFat = new System.Windows.Forms.TextBox();
            this.txtProteinPercent = new System.Windows.Forms.TextBox();
            this.txtCarbPercent = new System.Windows.Forms.TextBox();
            this.txtFatPercent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calories";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Protein";
            // 
            // txtCalories
            // 
            this.txtCalories.Location = new System.Drawing.Point(200, 104);
            this.txtCalories.Name = "txtCalories";
            this.txtCalories.Size = new System.Drawing.Size(100, 20);
            this.txtCalories.TabIndex = 2;
            // 
            // txtProtein
            // 
            this.txtProtein.Location = new System.Drawing.Point(200, 131);
            this.txtProtein.Name = "txtProtein";
            this.txtProtein.Size = new System.Drawing.Size(100, 20);
            this.txtProtein.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Carb";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Protein %";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Carb %";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Fat %";
            // 
            // txtCarbs
            // 
            this.txtCarbs.Location = new System.Drawing.Point(200, 157);
            this.txtCarbs.Name = "txtCarbs";
            this.txtCarbs.Size = new System.Drawing.Size(100, 20);
            this.txtCarbs.TabIndex = 9;
            // 
            // txtFat
            // 
            this.txtFat.Location = new System.Drawing.Point(200, 194);
            this.txtFat.Name = "txtFat";
            this.txtFat.Size = new System.Drawing.Size(100, 20);
            this.txtFat.TabIndex = 10;
            // 
            // txtProteinPercent
            // 
            this.txtProteinPercent.Location = new System.Drawing.Point(200, 223);
            this.txtProteinPercent.Name = "txtProteinPercent";
            this.txtProteinPercent.Size = new System.Drawing.Size(100, 20);
            this.txtProteinPercent.TabIndex = 11;
            // 
            // txtCarbPercent
            // 
            this.txtCarbPercent.Location = new System.Drawing.Point(200, 248);
            this.txtCarbPercent.Name = "txtCarbPercent";
            this.txtCarbPercent.Size = new System.Drawing.Size(100, 20);
            this.txtCarbPercent.TabIndex = 12;
            // 
            // txtFatPercent
            // 
            this.txtFatPercent.Location = new System.Drawing.Point(200, 280);
            this.txtFatPercent.Name = "txtFatPercent";
            this.txtFatPercent.Size = new System.Drawing.Size(100, 20);
            this.txtFatPercent.TabIndex = 13;
            // 
            // frmResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 488);
            this.Controls.Add(this.txtFatPercent);
            this.Controls.Add(this.txtCarbPercent);
            this.Controls.Add(this.txtProteinPercent);
            this.Controls.Add(this.txtFat);
            this.Controls.Add(this.txtCarbs);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProtein);
            this.Controls.Add(this.txtCalories);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmResults";
            this.Text = "Results";
            this.Load += new System.EventHandler(this.Results_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCalories;
        private System.Windows.Forms.TextBox txtProtein;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCarbs;
        private System.Windows.Forms.TextBox txtFat;
        private System.Windows.Forms.TextBox txtProteinPercent;
        private System.Windows.Forms.TextBox txtCarbPercent;
        private System.Windows.Forms.TextBox txtFatPercent;
    }
}