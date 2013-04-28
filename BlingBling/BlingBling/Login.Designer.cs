namespace BlingBling
{
    partial class LoginPage
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
      this.LoginButton = new System.Windows.Forms.Button();
      this.QuitButton = new System.Windows.Forms.Button();
      this.sqlConn = new System.Data.SQLite.SQLiteConnection();
      this.errLogin = new System.Windows.Forms.ErrorProvider(this.components);
      this.sqlDoLogin = new System.Data.SQLite.SQLiteCommand();
      ((System.ComponentModel.ISupportInitialize)(this.errLogin)).BeginInit();
      this.SuspendLayout();
      // 
      // Title
      // 
      this.Title.AutoSize = true;
      this.Title.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Title.Location = new System.Drawing.Point(163, 125);
      this.Title.Name = "Title";
      this.Title.Size = new System.Drawing.Size(205, 40);
      this.Title.TabIndex = 0;
      this.Title.Text = "Please Login:";
      // 
      // UsernameLabel
      // 
      this.UsernameLabel.AutoSize = true;
      this.UsernameLabel.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.UsernameLabel.Location = new System.Drawing.Point(165, 225);
      this.UsernameLabel.Name = "UsernameLabel";
      this.UsernameLabel.Size = new System.Drawing.Size(112, 27);
      this.UsernameLabel.TabIndex = 1;
      this.UsernameLabel.Text = "Username:";
      // 
      // UsernameTextBox
      // 
      this.UsernameTextBox.BackColor = System.Drawing.Color.White;
      this.UsernameTextBox.Location = new System.Drawing.Point(296, 232);
      this.UsernameTextBox.Name = "UsernameTextBox";
      this.UsernameTextBox.Size = new System.Drawing.Size(198, 20);
      this.UsernameTextBox.TabIndex = 2;
      // 
      // PasswordLabel
      // 
      this.PasswordLabel.AutoSize = true;
      this.PasswordLabel.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.PasswordLabel.Location = new System.Drawing.Point(168, 291);
      this.PasswordLabel.Name = "PasswordLabel";
      this.PasswordLabel.Size = new System.Drawing.Size(109, 27);
      this.PasswordLabel.TabIndex = 3;
      this.PasswordLabel.Text = "Password:";
      // 
      // PasswordTextBox
      // 
      this.PasswordTextBox.BackColor = System.Drawing.Color.White;
      this.PasswordTextBox.Location = new System.Drawing.Point(296, 298);
      this.PasswordTextBox.Name = "PasswordTextBox";
      this.PasswordTextBox.PasswordChar = '$';
      this.PasswordTextBox.Size = new System.Drawing.Size(198, 20);
      this.PasswordTextBox.TabIndex = 4;
      // 
      // LoginButton
      // 
      this.LoginButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LoginButton.Location = new System.Drawing.Point(148, 371);
      this.LoginButton.Name = "LoginButton";
      this.LoginButton.Size = new System.Drawing.Size(148, 34);
      this.LoginButton.TabIndex = 5;
      this.LoginButton.Text = "Login";
      this.LoginButton.UseVisualStyleBackColor = true;
      this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
      // 
      // QuitButton
      // 
      this.QuitButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.QuitButton.Location = new System.Drawing.Point(362, 371);
      this.QuitButton.Name = "QuitButton";
      this.QuitButton.Size = new System.Drawing.Size(148, 34);
      this.QuitButton.TabIndex = 6;
      this.QuitButton.Text = "Quit";
      this.QuitButton.UseVisualStyleBackColor = true;
      this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
      // 
      // sqlConn
      // 
      this.sqlConn.ConnectionString = "Data Source=d:\\Users\\gregg\\Documents\\GitHub\\nts\\BlingBling\\BlingBling\\bling.db";
      this.sqlConn.DefaultTimeout = 30;
      this.sqlConn.Flags = System.Data.SQLite.SQLiteConnectionFlags.LogCallbackException;
      this.sqlConn.ParseViaFramework = false;
      // 
      // errLogin
      // 
      this.errLogin.ContainerControl = this;
      // 
      // sqlDoLogin
      // 
      this.sqlDoLogin.Connection = this.sqlConn;
      // 
      // LoginPage
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Azure;
      this.ClientSize = new System.Drawing.Size(659, 476);
      this.Controls.Add(this.QuitButton);
      this.Controls.Add(this.LoginButton);
      this.Controls.Add(this.PasswordTextBox);
      this.Controls.Add(this.PasswordLabel);
      this.Controls.Add(this.UsernameTextBox);
      this.Controls.Add(this.UsernameLabel);
      this.Controls.Add(this.Title);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "LoginPage";
      this.Text = "Login";
      ((System.ComponentModel.ISupportInitialize)(this.errLogin)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button QuitButton;
        private System.Data.SQLite.SQLiteConnection sqlConn;
        private System.Windows.Forms.ErrorProvider errLogin;
        private System.Data.SQLite.SQLiteCommand sqlDoLogin;
    }
}

