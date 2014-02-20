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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetWeightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFoodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editFoodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.tlpResults = new System.Windows.Forms.TableLayoutPanel();
            this.tlpFinal = new System.Windows.Forms.TableLayoutPanel();
            this.mealsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMealToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.foodToolStripMenuItem,
            this.mealsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(876, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetWeightToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // resetWeightToolStripMenuItem
            // 
            this.resetWeightToolStripMenuItem.Name = "resetWeightToolStripMenuItem";
            this.resetWeightToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.resetWeightToolStripMenuItem.Text = "Reset weight";
            this.resetWeightToolStripMenuItem.Click += new System.EventHandler(this.resetWeightToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(160, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // foodToolStripMenuItem
            // 
            this.foodToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFoodToolStripMenuItem,
            this.editFoodToolStripMenuItem});
            this.foodToolStripMenuItem.Name = "foodToolStripMenuItem";
            this.foodToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.foodToolStripMenuItem.Text = "Food";
            // 
            // addFoodToolStripMenuItem
            // 
            this.addFoodToolStripMenuItem.Name = "addFoodToolStripMenuItem";
            this.addFoodToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.addFoodToolStripMenuItem.Text = "Add Food";
            this.addFoodToolStripMenuItem.Click += new System.EventHandler(this.addFoodToolStripMenuItem_Click);
            // 
            // editFoodToolStripMenuItem
            // 
            this.editFoodToolStripMenuItem.Name = "editFoodToolStripMenuItem";
            this.editFoodToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.editFoodToolStripMenuItem.Text = "Edit Food";
            this.editFoodToolStripMenuItem.Click += new System.EventHandler(this.editFoodToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(12, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tlpResults
            // 
            this.tlpResults.AutoSize = true;
            this.tlpResults.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpResults.ColumnCount = 6;
            this.tlpResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpResults.Location = new System.Drawing.Point(148, 106);
            this.tlpResults.Name = "tlpResults";
            this.tlpResults.RowCount = 2;
            this.tlpResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpResults.Size = new System.Drawing.Size(0, 20);
            this.tlpResults.TabIndex = 16;
            // 
            // tlpFinal
            // 
            this.tlpFinal.AutoSize = true;
            this.tlpFinal.ColumnCount = 1;
            this.tlpFinal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFinal.Location = new System.Drawing.Point(44, 47);
            this.tlpFinal.Name = "tlpFinal";
            this.tlpFinal.RowCount = 2;
            this.tlpFinal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFinal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFinal.Size = new System.Drawing.Size(200, 100);
            this.tlpFinal.TabIndex = 17;
            // 
            // mealsToolStripMenuItem
            // 
            this.mealsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMealToolStripMenuItem});
            this.mealsToolStripMenuItem.Name = "mealsToolStripMenuItem";
            this.mealsToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.mealsToolStripMenuItem.Text = "Meals";
            // 
            // addMealToolStripMenuItem
            // 
            this.addMealToolStripMenuItem.Name = "addMealToolStripMenuItem";
            this.addMealToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.addMealToolStripMenuItem.Text = "Add Meal";
            this.addMealToolStripMenuItem.Click += new System.EventHandler(this.addMealToolStripMenuItem_Click);
            // 
            // FrmResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(876, 601);
            this.ControlBox = false;
            this.Controls.Add(this.tlpFinal);
            this.Controls.Add(this.tlpResults);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmResults";
            this.ShowIcon = false;
            this.Text = "Nutrition Cal";
            this.Load += new System.EventHandler(this.Results_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem foodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFoodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetWeightToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem editFoodToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tlpResults;
        private System.Windows.Forms.TableLayoutPanel tlpFinal;
        private System.Windows.Forms.ToolStripMenuItem mealsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMealToolStripMenuItem;
    }
}