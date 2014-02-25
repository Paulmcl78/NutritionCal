﻿namespace NutritionCal.GUI.Forms
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
            this.components = new System.ComponentModel.Container();
            this.cmdSubmit = new System.Windows.Forms.Button();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.rbGain = new System.Windows.Forms.RadioButton();
            this.rbLose = new System.Windows.Forms.RadioButton();
            this.rbLose25 = new System.Windows.Forms.RadioButton();
            this.rbMaintain = new System.Windows.Forms.RadioButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.cbWeight = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // cmdSubmit
            // 
            this.cmdSubmit.Location = new System.Drawing.Point(92, 158);
            this.cmdSubmit.Name = "cmdSubmit";
            this.cmdSubmit.Size = new System.Drawing.Size(75, 23);
            this.cmdSubmit.TabIndex = 0;
            this.cmdSubmit.Text = "submit";
            this.cmdSubmit.UseVisualStyleBackColor = true;
            this.cmdSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(82, 123);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 20);
            this.txtWeight.TabIndex = 1;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(12, 126);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(72, 13);
            this.lblWeight.TabIndex = 2;
            this.lblWeight.Text = "Enter weight :";
            // 
            // rbGain
            // 
            this.rbGain.AutoSize = true;
            this.rbGain.Location = new System.Drawing.Point(82, 12);
            this.rbGain.Name = "rbGain";
            this.rbGain.Size = new System.Drawing.Size(81, 17);
            this.rbGain.TabIndex = 3;
            this.rbGain.Text = "Gain weight";
            this.rbGain.UseVisualStyleBackColor = true;
            // 
            // rbLose
            // 
            this.rbLose.AutoSize = true;
            this.rbLose.Location = new System.Drawing.Point(82, 35);
            this.rbLose.Name = "rbLose";
            this.rbLose.Size = new System.Drawing.Size(82, 17);
            this.rbLose.TabIndex = 4;
            this.rbLose.Text = "Lose weight";
            this.rbLose.UseVisualStyleBackColor = true;
            // 
            // rbLose25
            // 
            this.rbLose25.AutoSize = true;
            this.rbLose25.Location = new System.Drawing.Point(82, 59);
            this.rbLose25.Name = "rbLose25";
            this.rbLose25.Size = new System.Drawing.Size(130, 17);
            this.rbLose25.TabIndex = 5;
            this.rbLose25.Text = "Lose weight + 25% BF";
            this.rbLose25.UseVisualStyleBackColor = true;
            // 
            // rbMaintain
            // 
            this.rbMaintain.AutoSize = true;
            this.rbMaintain.Checked = true;
            this.rbMaintain.Location = new System.Drawing.Point(82, 83);
            this.rbMaintain.Name = "rbMaintain";
            this.rbMaintain.Size = new System.Drawing.Size(99, 17);
            this.rbMaintain.TabIndex = 6;
            this.rbMaintain.TabStop = true;
            this.rbMaintain.Text = "Maintain weight";
            this.rbMaintain.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // cbWeight
            // 
            this.cbWeight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWeight.FormattingEnabled = true;
            this.cbWeight.Location = new System.Drawing.Point(188, 122);
            this.cbWeight.Name = "cbWeight";
            this.cbWeight.Size = new System.Drawing.Size(43, 21);
            this.cbWeight.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(24, 226);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 407);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.cbWeight);
            this.Controls.Add(this.rbMaintain);
            this.Controls.Add(this.rbLose25);
            this.Controls.Add(this.rbLose);
            this.Controls.Add(this.rbGain);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.cmdSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
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
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ComboBox cbWeight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

