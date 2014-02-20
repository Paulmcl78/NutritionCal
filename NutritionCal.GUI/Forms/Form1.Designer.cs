namespace NutritionCal.GUI.Forms
{
    partial class Form1
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
            this.cmdSubmit = new System.Windows.Forms.Button();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.rbGain = new System.Windows.Forms.RadioButton();
            this.rbLose = new System.Windows.Forms.RadioButton();
            this.rbLose25 = new System.Windows.Forms.RadioButton();
            this.rbMaintain = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // cmdSubmit
            // 
            this.cmdSubmit.Location = new System.Drawing.Point(123, 195);
            this.cmdSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdSubmit.Name = "cmdSubmit";
            this.cmdSubmit.Size = new System.Drawing.Size(100, 28);
            this.cmdSubmit.TabIndex = 0;
            this.cmdSubmit.Text = "submit";
            this.cmdSubmit.UseVisualStyleBackColor = true;
            this.cmdSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(151, 151);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(132, 22);
            this.txtWeight.TabIndex = 1;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(16, 155);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(126, 17);
            this.lblWeight.TabIndex = 2;
            this.lblWeight.Text = "Enter weight in lb\'s";
            // 
            // rbGain
            // 
            this.rbGain.AutoSize = true;
            this.rbGain.Location = new System.Drawing.Point(109, 15);
            this.rbGain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbGain.Name = "rbGain";
            this.rbGain.Size = new System.Drawing.Size(103, 21);
            this.rbGain.TabIndex = 3;
            this.rbGain.Text = "Gain weight";
            this.rbGain.UseVisualStyleBackColor = true;
            // 
            // rbLose
            // 
            this.rbLose.AutoSize = true;
            this.rbLose.Location = new System.Drawing.Point(109, 43);
            this.rbLose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbLose.Name = "rbLose";
            this.rbLose.Size = new System.Drawing.Size(104, 21);
            this.rbLose.TabIndex = 4;
            this.rbLose.Text = "Lose weight";
            this.rbLose.UseVisualStyleBackColor = true;
            // 
            // rbLose25
            // 
            this.rbLose25.AutoSize = true;
            this.rbLose25.Location = new System.Drawing.Point(109, 73);
            this.rbLose25.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbLose25.Name = "rbLose25";
            this.rbLose25.Size = new System.Drawing.Size(169, 21);
            this.rbLose25.TabIndex = 5;
            this.rbLose25.Text = "Lose weight + 25% BF";
            this.rbLose25.UseVisualStyleBackColor = true;
            // 
            // rbMaintain
            // 
            this.rbMaintain.AutoSize = true;
            this.rbMaintain.Checked = true;
            this.rbMaintain.Location = new System.Drawing.Point(109, 102);
            this.rbMaintain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbMaintain.Name = "rbMaintain";
            this.rbMaintain.Size = new System.Drawing.Size(126, 21);
            this.rbMaintain.TabIndex = 6;
            this.rbMaintain.TabStop = true;
            this.rbMaintain.Text = "Maintain weight";
            this.rbMaintain.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 287);
            this.ControlBox = false;
            this.Controls.Add(this.rbMaintain);
            this.Controls.Add(this.rbLose25);
            this.Controls.Add(this.rbLose);
            this.Controls.Add(this.rbGain);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.cmdSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nutrition Cal - Set Weight";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdSubmit;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.RadioButton rbGain;
        private System.Windows.Forms.RadioButton rbLose;
        private System.Windows.Forms.RadioButton rbLose25;
        private System.Windows.Forms.RadioButton rbMaintain;
    }
}

