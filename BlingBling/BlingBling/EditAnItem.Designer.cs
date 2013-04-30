namespace BlingBling
{
    partial class EditAnItem
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
      this.AmountLabel = new System.Windows.Forms.Label();
      this.AmountTextBox = new System.Windows.Forms.TextBox();
      this.CategoryLabel = new System.Windows.Forms.Label();
      this.CategoryList = new System.Windows.Forms.ListBox();
      this.DescriptionLabel = new System.Windows.Forms.Label();
      this.DescriptionTextBox = new System.Windows.Forms.TextBox();
      this.DateLabel = new System.Windows.Forms.Label();
      this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
      this.EditButton = new System.Windows.Forms.Button();
      this.CancelButton = new System.Windows.Forms.Button();
      this.SuccessTextBox = new System.Windows.Forms.RichTextBox();
      this.sqlConn = new System.Data.SQLite.SQLiteConnection();
      this.sqlDoEdit = new System.Data.SQLite.SQLiteCommand();
      this.SuspendLayout();
      // 
      // Title
      // 
      this.Title.AutoSize = true;
      this.Title.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Title.Location = new System.Drawing.Point(247, 51);
      this.Title.Name = "Title";
      this.Title.Size = new System.Drawing.Size(150, 40);
      this.Title.TabIndex = 0;
      this.Title.Text = "Edit Item";
      // 
      // AmountLabel
      // 
      this.AmountLabel.AutoSize = true;
      this.AmountLabel.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.AmountLabel.Location = new System.Drawing.Point(164, 165);
      this.AmountLabel.Name = "AmountLabel";
      this.AmountLabel.Size = new System.Drawing.Size(106, 27);
      this.AmountLabel.TabIndex = 1;
      this.AmountLabel.Text = "Amount: $";
      // 
      // AmountTextBox
      // 
      this.AmountTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.AmountTextBox.Location = new System.Drawing.Point(264, 165);
      this.AmountTextBox.Name = "AmountTextBox";
      this.AmountTextBox.Size = new System.Drawing.Size(257, 26);
      this.AmountTextBox.TabIndex = 2;
      // 
      // CategoryLabel
      // 
      this.CategoryLabel.AutoSize = true;
      this.CategoryLabel.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CategoryLabel.Location = new System.Drawing.Point(160, 204);
      this.CategoryLabel.Name = "CategoryLabel";
      this.CategoryLabel.Size = new System.Drawing.Size(110, 27);
      this.CategoryLabel.TabIndex = 3;
      this.CategoryLabel.Text = "Category: ";
      // 
      // CategoryList
      // 
      this.CategoryList.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CategoryList.FormattingEnabled = true;
      this.CategoryList.ItemHeight = 22;
      this.CategoryList.Items.AddRange(new object[] {
            "Income",
            "Bill",
            "Groceries",
            "Household Item",
            "Clothing",
            "Entertainment",
            "Miscellaneous"});
      this.CategoryList.Location = new System.Drawing.Point(264, 204);
      this.CategoryList.Name = "CategoryList";
      this.CategoryList.Size = new System.Drawing.Size(257, 26);
      this.CategoryList.TabIndex = 4;
      // 
      // DescriptionLabel
      // 
      this.DescriptionLabel.AutoSize = true;
      this.DescriptionLabel.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.DescriptionLabel.Location = new System.Drawing.Point(138, 243);
      this.DescriptionLabel.Name = "DescriptionLabel";
      this.DescriptionLabel.Size = new System.Drawing.Size(132, 27);
      this.DescriptionLabel.TabIndex = 5;
      this.DescriptionLabel.Text = "Description: ";
      // 
      // DescriptionTextBox
      // 
      this.DescriptionTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.DescriptionTextBox.HideSelection = false;
      this.DescriptionTextBox.Location = new System.Drawing.Point(264, 243);
      this.DescriptionTextBox.Name = "DescriptionTextBox";
      this.DescriptionTextBox.Size = new System.Drawing.Size(257, 26);
      this.DescriptionTextBox.TabIndex = 6;
      // 
      // DateLabel
      // 
      this.DateLabel.AutoSize = true;
      this.DateLabel.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.DateLabel.Location = new System.Drawing.Point(201, 282);
      this.DateLabel.Name = "DateLabel";
      this.DateLabel.Size = new System.Drawing.Size(69, 27);
      this.DateLabel.TabIndex = 7;
      this.DateLabel.Text = "Date: ";
      // 
      // dateTimePicker1
      // 
      this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dateTimePicker1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dateTimePicker1.Location = new System.Drawing.Point(264, 282);
      this.dateTimePicker1.Name = "dateTimePicker1";
      this.dateTimePicker1.Size = new System.Drawing.Size(257, 26);
      this.dateTimePicker1.TabIndex = 8;
      // 
      // EditButton
      // 
      this.EditButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.EditButton.Location = new System.Drawing.Point(188, 380);
      this.EditButton.Name = "EditButton";
      this.EditButton.Size = new System.Drawing.Size(119, 41);
      this.EditButton.TabIndex = 9;
      this.EditButton.Text = "Edit";
      this.EditButton.UseVisualStyleBackColor = true;
      this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
      // 
      // CancelButton
      // 
      this.CancelButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CancelButton.Location = new System.Drawing.Point(349, 380);
      this.CancelButton.Name = "CancelButton";
      this.CancelButton.Size = new System.Drawing.Size(122, 41);
      this.CancelButton.TabIndex = 10;
      this.CancelButton.Text = "Cancel";
      this.CancelButton.UseVisualStyleBackColor = true;
      // 
      // SuccessTextBox
      // 
      this.SuccessTextBox.BackColor = System.Drawing.Color.Azure;
      this.SuccessTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.SuccessTextBox.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.SuccessTextBox.Location = new System.Drawing.Point(143, 109);
      this.SuccessTextBox.Name = "SuccessTextBox";
      this.SuccessTextBox.Size = new System.Drawing.Size(378, 36);
      this.SuccessTextBox.TabIndex = 11;
      this.SuccessTextBox.Text = "";
      // 
      // sqlConn
      // 
      this.sqlConn.DefaultTimeout = 30;
      this.sqlConn.Flags = System.Data.SQLite.SQLiteConnectionFlags.LogCallbackException;
      this.sqlConn.ParseViaFramework = false;
      // 
      // sqlDoEdit
      // 
      this.sqlDoEdit.CommandText = null;
      // 
      // EditAnItem
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Azure;
      this.ClientSize = new System.Drawing.Size(659, 476);
      this.Controls.Add(this.SuccessTextBox);
      this.Controls.Add(this.CancelButton);
      this.Controls.Add(this.EditButton);
      this.Controls.Add(this.dateTimePicker1);
      this.Controls.Add(this.DateLabel);
      this.Controls.Add(this.DescriptionTextBox);
      this.Controls.Add(this.DescriptionLabel);
      this.Controls.Add(this.CategoryList);
      this.Controls.Add(this.CategoryLabel);
      this.Controls.Add(this.AmountTextBox);
      this.Controls.Add(this.AmountLabel);
      this.Controls.Add(this.Title);
      this.Name = "EditAnItem";
      this.Text = "Edit Item";
      this.Load += new System.EventHandler(this.EditAnItem_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.ListBox CategoryList;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.RichTextBox SuccessTextBox;
        private System.Data.SQLite.SQLiteConnection sqlConn;
        private System.Data.SQLite.SQLiteCommand sqlDoEdit;
    }
}