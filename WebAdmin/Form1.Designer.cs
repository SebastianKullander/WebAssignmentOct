﻿namespace WebAdmin
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
            this.txbEducation = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txbPeriod = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbEducation
            // 
            this.txbEducation.Location = new System.Drawing.Point(77, 42);
            this.txbEducation.Name = "txbEducation";
            this.txbEducation.Size = new System.Drawing.Size(100, 20);
            this.txbEducation.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(90, 175);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "button1";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txbPeriod
            // 
            this.txbPeriod.Location = new System.Drawing.Point(77, 68);
            this.txbPeriod.Name = "txbPeriod";
            this.txbPeriod.Size = new System.Drawing.Size(100, 20);
            this.txbPeriod.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txbPeriod);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txbEducation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbEducation;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txbPeriod;
    }
}

