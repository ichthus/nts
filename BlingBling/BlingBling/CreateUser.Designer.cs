namespace BlingBling
{
    partial class CreateUser
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
      this.Title = new System.Windows.Forms.Label();
      this.UsernameLabel = new System.Windows.Forms.Label();
      this.UsernameTextBox = new System.Windows.Forms.TextBox();
      this.PasswordLabel = new System.Windows.Forms.Label();
      this.PasswordTextBox = new System.Windows.Forms.TextBox();
      this.PasswordLabel2 = new System.Windows.Forms.Label();
      this.PasswordTextBox2 = new System.Windows.Forms.TextBox();
      this.Admin = new System.Windows.Forms.CheckBox();
      this.CreateButton = new System.Windows.Forms.Button();
      this.CancelButton = new System.Windows.Forms.Button();
      this.sqlConn = new System.Data.SQLite.SQLiteConnection();
      this.sqlDoCreate = new System.Data.SQLite.SQLiteCommand();
      this.nameTextBox = new System.Windows.Forms.TextBox();
      this.nameLabel = new System.Windows.Forms.Label();
      this.errorValidation = new System.Windows.Forms.ErrorProvider(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.errorValidation)).BeginInit();
      this.SuspendLayout();
      // 
      // Title
      // 
      this.Title.AutoSize = true;
      this.Title.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Title.Location = new System.Drawing.Point(237, 42);
      this.Title.Name = "Title";
      this.Title.Size = new System.Drawing.Size(185, 40);
      this.Title.TabIndex = 0;
      this.Title.Text = "Create User";
      // 
      // UsernameLabel
      // 
      this.UsernameLabel.AutoSize = true;
      this.UsernameLabel.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.UsernameLabel.Location = new System.Drawing.Point(154, 161);
      this.UsernameLabel.Name = "UsernameLabel";
      this.UsernameLabel.Size = new System.Drawing.Size(112, 27);
      this.UsernameLabel.TabIndex = 1;
      this.UsernameLabel.Text = "Username:";
      // 
      // UsernameTextBox
      // 
      this.UsernameTextBox.BackColor = System.Drawing.Color.White;
      this.UsernameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
      this.UsernameTextBox.Location = new System.Drawing.Point(318, 168);
      this.UsernameTextBox.Name = "UsernameTextBox";
      this.UsernameTextBox.ShortcutsEnabled = false;
      this.UsernameTextBox.Size = new System.Drawing.Size(138, 20);
      this.UsernameTextBox.TabIndex = 2;
      this.UsernameTextBox.TextChanged += new System.EventHandler(this.UsernameTextBox_TextChanged);
      this.UsernameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UsernameTextBox_KeyPress);
      // 
      // PasswordLabel
      // 
      this.PasswordLabel.AutoSize = true;
      this.PasswordLabel.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.PasswordLabel.Location = new System.Drawing.Point(157, 212);
      this.PasswordLabel.Name = "PasswordLabel";
      this.PasswordLabel.Size = new System.Drawing.Size(109, 27);
      this.PasswordLabel.TabIndex = 3;
      this.PasswordLabel.Text = "Password:";
      // 
      // PasswordTextBox
      // 
      this.PasswordTextBox.BackColor = System.Drawing.Color.White;
      this.PasswordTextBox.Location = new System.Drawing.Point(318, 219);
      this.PasswordTextBox.Name = "PasswordTextBox";
      this.PasswordTextBox.PasswordChar = '$';
      this.PasswordTextBox.Size = new System.Drawing.Size(138, 20);
      this.PasswordTextBox.TabIndex = 4;
      // 
      // PasswordLabel2
      // 
      this.PasswordLabel2.AutoSize = true;
      this.PasswordLabel2.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.PasswordLabel2.Location = new System.Drawing.Point(70, 263);
      this.PasswordLabel2.Name = "PasswordLabel2";
      this.PasswordLabel2.Size = new System.Drawing.Size(196, 27);
      this.PasswordLabel2.TabIndex = 5;
      this.PasswordLabel2.Text = "Re-enter password:";
      // 
      // PasswordTextBox2
      // 
      this.PasswordTextBox2.BackColor = System.Drawing.Color.White;
      this.PasswordTextBox2.Location = new System.Drawing.Point(318, 270);
      this.PasswordTextBox2.Name = "PasswordTextBox2";
      this.PasswordTextBox2.PasswordChar = '$';
      this.PasswordTextBox2.Size = new System.Drawing.Size(138, 20);
      this.PasswordTextBox2.TabIndex = 6;
      // 
      // Admin
      // 
      this.Admin.AutoSize = true;
      this.Admin.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Admin.Location = new System.Drawing.Point(318, 318);
      this.Admin.Name = "Admin";
      this.Admin.Size = new System.Drawing.Size(89, 28);
      this.Admin.TabIndex = 8;
      this.Admin.Text = "Admin?";
      this.Admin.UseVisualStyleBackColor = true;
      // 
      // CreateButton
      // 
      this.CreateButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CreateButton.Location = new System.Drawing.Point(151, 381);
      this.CreateButton.Name = "CreateButton";
      this.CreateButton.Size = new System.Drawing.Size(138, 37);
      this.CreateButton.TabIndex = 9;
      this.CreateButton.Text = "Create User";
      this.CreateButton.UseVisualStyleBackColor = true;
      this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
      // 
      // CancelButton
      // 
      this.CancelButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CancelButton.Location = new System.Drawing.Point(370, 381);
      this.CancelButton.Name = "CancelButton";
      this.CancelButton.Size = new System.Drawing.Size(138, 37);
      this.CancelButton.TabIndex = 10;
      this.CancelButton.Text = "Cancel";
      this.CancelButton.UseVisualStyleBackColor = true;
      this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
      // 
      // sqlConn
      // 
      this.sqlConn.ConnectionString = "Data Source=d:\\Users\\gregg\\Documents\\GitHub\\nts\\BlingBling\\BlingBling\\bling.db";
      this.sqlConn.DefaultTimeout = 30;
      this.sqlConn.Flags = System.Data.SQLite.SQLiteConnectionFlags.LogCallbackException;
      this.sqlConn.ParseViaFramework = false;
      // 
      // sqlDoCreate
      // 
      this.sqlDoCreate.CommandText = null;
      this.sqlDoCreate.Connection = this.sqlConn;
      // 
      // nameTextBox
      // 
      this.nameTextBox.BackColor = System.Drawing.Color.White;
      this.nameTextBox.Location = new System.Drawing.Point(318, 117);
      this.nameTextBox.Name = "nameTextBox";
      this.nameTextBox.Size = new System.Drawing.Size(138, 20);
      this.nameTextBox.TabIndex = 12;
      // 
      // nameLabel
      // 
      this.nameLabel.AutoSize = true;
      this.nameLabel.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.nameLabel.Location = new System.Drawing.Point(149, 110);
      this.nameLabel.Name = "nameLabel";
      this.nameLabel.Size = new System.Drawing.Size(117, 27);
      this.nameLabel.TabIndex = 11;
      this.nameLabel.Text = "Real Name:";
      // 
      // errorValidation
      // 
      this.errorValidation.ContainerControl = this;
      // 
      // CreateUser
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Azure;
      this.ClientSize = new System.Drawing.Size(659, 476);
      this.Controls.Add(this.nameTextBox);
      this.Controls.Add(this.nameLabel);
      this.Controls.Add(this.CancelButton);
      this.Controls.Add(this.CreateButton);
      this.Controls.Add(this.Admin);
      this.Controls.Add(this.PasswordTextBox2);
      this.Controls.Add(this.PasswordLabel2);
      this.Controls.Add(this.PasswordTextBox);
      this.Controls.Add(this.PasswordLabel);
      this.Controls.Add(this.UsernameTextBox);
      this.Controls.Add(this.UsernameLabel);
      this.Controls.Add(this.Title);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "CreateUser";
      this.Text = "Create User";
      ((System.ComponentModel.ISupportInitialize)(this.errorValidation)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordLabel2;
        private System.Windows.Forms.TextBox PasswordTextBox2;
        private System.Windows.Forms.CheckBox Admin;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Data.SQLite.SQLiteConnection sqlConn;
        private System.Data.SQLite.SQLiteCommand sqlDoCreate;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ErrorProvider errorValidation;
    }
}