namespace BlingBling
{
    partial class EditUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.UsernameEntryBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.sqlConn = new System.Data.SQLite.SQLiteConnection();
            this.sqlDoCmd = new System.Data.SQLite.SQLiteCommand();
            this.errSearch = new System.Windows.Forms.ErrorProvider(this.components);
            this.Admin = new System.Windows.Forms.CheckBox();
            this.PasswordTextBox2 = new System.Windows.Forms.TextBox();
            this.PasswordLabel2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.errPwd = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPwd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 24F);
            this.label1.Location = new System.Drawing.Point(239, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit User:";
            // 
            // UsernameEntryBox
            // 
            this.UsernameEntryBox.Location = new System.Drawing.Point(296, 123);
            this.UsernameEntryBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UsernameEntryBox.Name = "UsernameEntryBox";
            this.UsernameEntryBox.Size = new System.Drawing.Size(209, 20);
            this.UsernameEntryBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.label2.Location = new System.Drawing.Point(116, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Username:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.button1.Location = new System.Drawing.Point(246, 175);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.searchButton);
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = "Data Source=C:\\Users\\Jeremy\\Documents\\GitHub\\nts\\BlingBling\\BlingBling\\bling.db";
            this.sqlConn.DefaultTimeout = 30;
            this.sqlConn.Flags = System.Data.SQLite.SQLiteConnectionFlags.LogCallbackException;
            this.sqlConn.ParseViaFramework = false;
            // 
            // sqlDoCmd
            // 
            this.sqlDoCmd.CommandText = null;
            this.sqlDoCmd.Connection = this.sqlConn;
            // 
            // errSearch
            // 
            this.errSearch.ContainerControl = this;
            // 
            // Admin
            // 
            this.Admin.AutoSize = true;
            this.Admin.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.Location = new System.Drawing.Point(288, 447);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(89, 28);
            this.Admin.TabIndex = 11;
            this.Admin.Text = "Admin?";
            this.Admin.UseVisualStyleBackColor = true;
            this.Admin.Visible = false;
            // 
            // PasswordTextBox2
            // 
            this.PasswordTextBox2.BackColor = System.Drawing.Color.White;
            this.PasswordTextBox2.Location = new System.Drawing.Point(336, 397);
            this.PasswordTextBox2.Name = "PasswordTextBox2";
            this.PasswordTextBox2.PasswordChar = '$';
            this.PasswordTextBox2.Size = new System.Drawing.Size(138, 20);
            this.PasswordTextBox2.TabIndex = 10;
            this.PasswordTextBox2.Visible = false;
            // 
            // PasswordLabel2
            // 
            this.PasswordLabel2.AutoSize = true;
            this.PasswordLabel2.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel2.Location = new System.Drawing.Point(88, 390);
            this.PasswordLabel2.Name = "PasswordLabel2";
            this.PasswordLabel2.Size = new System.Drawing.Size(196, 27);
            this.PasswordLabel2.TabIndex = 9;
            this.PasswordLabel2.Text = "Re-enter password:";
            this.PasswordLabel2.Visible = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.White;
            this.nameTextBox.Location = new System.Drawing.Point(336, 248);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(138, 20);
            this.nameTextBox.TabIndex = 18;
            this.nameTextBox.Visible = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(167, 241);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(117, 27);
            this.nameLabel.TabIndex = 17;
            this.nameLabel.Text = "Real Name:";
            this.nameLabel.Visible = false;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.White;
            this.PasswordTextBox.Location = new System.Drawing.Point(336, 350);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '$';
            this.PasswordTextBox.Size = new System.Drawing.Size(138, 20);
            this.PasswordTextBox.TabIndex = 16;
            this.PasswordTextBox.Visible = false;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(129, 344);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(155, 27);
            this.PasswordLabel.TabIndex = 15;
            this.PasswordLabel.Text = "New Password:";
            this.PasswordLabel.Visible = false;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.BackColor = System.Drawing.Color.White;
            this.UsernameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.UsernameTextBox.Location = new System.Drawing.Point(336, 299);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.ShortcutsEnabled = false;
            this.UsernameTextBox.Size = new System.Drawing.Size(138, 20);
            this.UsernameTextBox.TabIndex = 14;
            this.UsernameTextBox.Visible = false;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(172, 292);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(112, 27);
            this.UsernameLabel.TabIndex = 13;
            this.UsernameLabel.Text = "Username:";
            this.UsernameLabel.Visible = false;
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(365, 481);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(138, 37);
            this.CancelButton.TabIndex = 20;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.cancelButton);
            // 
            // EditButton
            // 
            this.EditButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.Location = new System.Drawing.Point(146, 481);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(138, 37);
            this.EditButton.TabIndex = 19;
            this.EditButton.Text = "Edit User";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Visible = false;
            this.EditButton.Click += new System.EventHandler(this.editButton);
            // 
            // errPwd
            // 
            this.errPwd.ContainerControl = this;
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(649, 574);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.PasswordTextBox2);
            this.Controls.Add(this.PasswordLabel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UsernameEntryBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EditUser";
            this.Text = "Edit User";
            ((System.ComponentModel.ISupportInitialize)(this.errSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPwd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UsernameEntryBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Data.SQLite.SQLiteConnection sqlConn;
        private System.Data.SQLite.SQLiteCommand sqlDoCmd;
        private System.Windows.Forms.ErrorProvider errSearch;
        private System.Windows.Forms.CheckBox Admin;
        private System.Windows.Forms.TextBox PasswordTextBox2;
        private System.Windows.Forms.Label PasswordLabel2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.ErrorProvider errPwd;

    }
}