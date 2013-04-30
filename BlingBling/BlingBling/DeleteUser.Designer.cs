namespace BlingBling
{
    partial class DeleteUser
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.UsernameEntryBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.errSearch = new System.Windows.Forms.ErrorProvider(this.components);
            this.sqlConn = new System.Data.SQLite.SQLiteConnection();
            this.sqlDoCmd = new System.Data.SQLite.SQLiteCommand();
            ((System.ComponentModel.ISupportInitialize)(this.errSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.button1.Location = new System.Drawing.Point(201, 93);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SearchButton);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 15.75F);
            this.label2.Location = new System.Drawing.Point(83, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter Username:";
            // 
            // UsernameEntryBox
            // 
            this.UsernameEntryBox.Location = new System.Drawing.Point(263, 65);
            this.UsernameEntryBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UsernameEntryBox.Name = "UsernameEntryBox";
            this.UsernameEntryBox.Size = new System.Drawing.Size(209, 20);
            this.UsernameEntryBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 24F);
            this.label1.Location = new System.Drawing.Point(182, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "Delete User:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.White;
            this.nameTextBox.Location = new System.Drawing.Point(303, 149);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(138, 20);
            this.nameTextBox.TabIndex = 29;
            this.nameTextBox.Visible = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(134, 142);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(117, 27);
            this.nameLabel.TabIndex = 28;
            this.nameLabel.Text = "Real Name:";
            this.nameLabel.Visible = false;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.BackColor = System.Drawing.Color.White;
            this.UsernameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.UsernameTextBox.Location = new System.Drawing.Point(303, 200);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.ShortcutsEnabled = false;
            this.UsernameTextBox.Size = new System.Drawing.Size(138, 20);
            this.UsernameTextBox.TabIndex = 25;
            this.UsernameTextBox.Visible = false;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(139, 193);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(112, 27);
            this.UsernameLabel.TabIndex = 24;
            this.UsernameLabel.Text = "Username:";
            this.UsernameLabel.Visible = false;
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(316, 270);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(138, 37);
            this.CancelButton.TabIndex = 31;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.cancelButton);
            // 
            // delButton
            // 
            this.delButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delButton.Location = new System.Drawing.Point(97, 270);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(138, 37);
            this.delButton.TabIndex = 30;
            this.delButton.Text = "Delete User";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Visible = false;
            this.delButton.Click += new System.EventHandler(this.DeleteButton);
            // 
            // errSearch
            // 
            this.errSearch.ContainerControl = this;
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
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(559, 365);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UsernameEntryBox);
            this.Controls.Add(this.label1);
            this.Name = "DeleteUser";
            this.Text = "Delete User";
            ((System.ComponentModel.ISupportInitialize)(this.errSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsernameEntryBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.ErrorProvider errSearch;
        private System.Data.SQLite.SQLiteConnection sqlConn;
        private System.Data.SQLite.SQLiteCommand sqlDoCmd;
    }
}