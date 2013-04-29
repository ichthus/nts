namespace BlingBling
{
    partial class ManageUsers
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
      this.LogoutButton = new System.Windows.Forms.Button();
      this.EditUserButton = new System.Windows.Forms.Button();
      this.DeleteUserButton = new System.Windows.Forms.Button();
      this.CreateUserButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // Title
      // 
      this.Title.AutoSize = true;
      this.Title.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Title.Location = new System.Drawing.Point(218, 61);
      this.Title.Name = "Title";
      this.Title.Size = new System.Drawing.Size(222, 40);
      this.Title.TabIndex = 1;
      this.Title.Text = "Manage Users:";
      // 
      // LogoutButton
      // 
      this.LogoutButton.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LogoutButton.Location = new System.Drawing.Point(215, 352);
      this.LogoutButton.Name = "LogoutButton";
      this.LogoutButton.Size = new System.Drawing.Size(231, 43);
      this.LogoutButton.TabIndex = 6;
      this.LogoutButton.Text = "Go Back";
      this.LogoutButton.UseVisualStyleBackColor = true;
      this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
      // 
      // EditUserButton
      // 
      this.EditUserButton.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.EditUserButton.Location = new System.Drawing.Point(215, 214);
      this.EditUserButton.Name = "EditUserButton";
      this.EditUserButton.Size = new System.Drawing.Size(231, 43);
      this.EditUserButton.TabIndex = 7;
      this.EditUserButton.Text = "Edit User";
      this.EditUserButton.UseVisualStyleBackColor = true;
      this.EditUserButton.Click += new System.EventHandler(this.EditUserButton_Click);
      // 
      // DeleteUserButton
      // 
      this.DeleteUserButton.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.DeleteUserButton.Location = new System.Drawing.Point(214, 283);
      this.DeleteUserButton.Name = "DeleteUserButton";
      this.DeleteUserButton.Size = new System.Drawing.Size(231, 43);
      this.DeleteUserButton.TabIndex = 8;
      this.DeleteUserButton.Text = "Delete User";
      this.DeleteUserButton.UseVisualStyleBackColor = true;
      this.DeleteUserButton.Click += new System.EventHandler(this.DeleteUserButton_Click);
      // 
      // CreateUserButton
      // 
      this.CreateUserButton.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CreateUserButton.Location = new System.Drawing.Point(215, 145);
      this.CreateUserButton.Name = "CreateUserButton";
      this.CreateUserButton.Size = new System.Drawing.Size(231, 43);
      this.CreateUserButton.TabIndex = 9;
      this.CreateUserButton.Text = "Create User";
      this.CreateUserButton.UseVisualStyleBackColor = true;
      this.CreateUserButton.Click += new System.EventHandler(this.CreateUserButton_Click);
      // 
      // ManageUsers
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Azure;
      this.ClientSize = new System.Drawing.Size(659, 476);
      this.Controls.Add(this.CreateUserButton);
      this.Controls.Add(this.DeleteUserButton);
      this.Controls.Add(this.EditUserButton);
      this.Controls.Add(this.LogoutButton);
      this.Controls.Add(this.Title);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "ManageUsers";
      this.Text = "Manage Users Page (Admin)";
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button EditUserButton;
        private System.Windows.Forms.Button DeleteUserButton;
        private System.Windows.Forms.Button CreateUserButton;
    }
}