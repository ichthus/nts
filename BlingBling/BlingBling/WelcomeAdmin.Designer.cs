﻿namespace BlingBling
{
    partial class WelcomeAdmin
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
      this.Title = new System.Windows.Forms.Label();
      this.BudgetWizardButton = new System.Windows.Forms.Button();
      this.ReportButton = new System.Windows.Forms.Button();
      this.LogoutButton = new System.Windows.Forms.Button();
      this.ManageUserButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // Title
      // 
      this.Title.AutoSize = true;
      this.Title.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Title.Location = new System.Drawing.Point(55, 61);
      this.Title.Name = "Title";
      this.Title.Size = new System.Drawing.Size(556, 40);
      this.Title.TabIndex = 1;
      this.Title.Text = "Welcome! What would you like to do?";
      // 
      // BudgetWizardButton
      // 
      this.BudgetWizardButton.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BudgetWizardButton.Location = new System.Drawing.Point(215, 155);
      this.BudgetWizardButton.Name = "BudgetWizardButton";
      this.BudgetWizardButton.Size = new System.Drawing.Size(231, 43);
      this.BudgetWizardButton.TabIndex = 2;
      this.BudgetWizardButton.Text = "Budget Wizard";
      this.BudgetWizardButton.UseVisualStyleBackColor = true;
      this.BudgetWizardButton.Click += new System.EventHandler(this.BudgetWizardButton_Click);
      // 
      // ReportButton
      // 
      this.ReportButton.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ReportButton.Location = new System.Drawing.Point(212, 221);
      this.ReportButton.Name = "ReportButton";
      this.ReportButton.Size = new System.Drawing.Size(231, 43);
      this.ReportButton.TabIndex = 5;
      this.ReportButton.Text = "Report";
      this.ReportButton.UseVisualStyleBackColor = true;
      this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
      // 
      // LogoutButton
      // 
      this.LogoutButton.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LogoutButton.Location = new System.Drawing.Point(215, 353);
      this.LogoutButton.Name = "LogoutButton";
      this.LogoutButton.Size = new System.Drawing.Size(231, 43);
      this.LogoutButton.TabIndex = 6;
      this.LogoutButton.Text = "Log Out";
      this.LogoutButton.UseVisualStyleBackColor = true;
      this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
      // 
      // ManageUserButton
      // 
      this.ManageUserButton.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ManageUserButton.Location = new System.Drawing.Point(215, 287);
      this.ManageUserButton.Name = "ManageUserButton";
      this.ManageUserButton.Size = new System.Drawing.Size(231, 43);
      this.ManageUserButton.TabIndex = 7;
      this.ManageUserButton.Text = "Manage Users";
      this.ManageUserButton.UseVisualStyleBackColor = true;
      this.ManageUserButton.Click += new System.EventHandler(this.ManageUserButton_Click);
      // 
      // WelcomeAdmin
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Azure;
      this.ClientSize = new System.Drawing.Size(659, 476);
      this.Controls.Add(this.ManageUserButton);
      this.Controls.Add(this.LogoutButton);
      this.Controls.Add(this.ReportButton);
      this.Controls.Add(this.BudgetWizardButton);
      this.Controls.Add(this.Title);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "WelcomeAdmin";
      this.Text = "Welcome Page (Admin)";
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button BudgetWizardButton;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button ManageUserButton;
    }
}