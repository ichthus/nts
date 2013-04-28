namespace BlingBling
{
    partial class AddItem
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
      this.CategoryMenu = new System.Windows.Forms.ListBox();
      this.AddButton = new System.Windows.Forms.Button();
      this.CancelButton = new System.Windows.Forms.Button();
      this.DateLabel = new System.Windows.Forms.Label();
      this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
      this.SuspendLayout();
      // 
      // Title
      // 
      this.Title.AutoSize = true;
      this.Title.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Title.Location = new System.Drawing.Point(255, 46);
      this.Title.Name = "Title";
      this.Title.Size = new System.Drawing.Size(148, 40);
      this.Title.TabIndex = 0;
      this.Title.Text = "Add Item";
      // 
      // AmountLabel
      // 
      this.AmountLabel.AutoSize = true;
      this.AmountLabel.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.AmountLabel.Location = new System.Drawing.Point(150, 135);
      this.AmountLabel.Name = "AmountLabel";
      this.AmountLabel.Size = new System.Drawing.Size(106, 27);
      this.AmountLabel.TabIndex = 1;
      this.AmountLabel.Text = "Amount: $";
      // 
      // AmountTextBox
      // 
      this.AmountTextBox.Location = new System.Drawing.Point(253, 142);
      this.AmountTextBox.Name = "AmountTextBox";
      this.AmountTextBox.Size = new System.Drawing.Size(259, 20);
      this.AmountTextBox.TabIndex = 2;
      // 
      // CategoryLabel
      // 
      this.CategoryLabel.AutoSize = true;
      this.CategoryLabel.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CategoryLabel.Location = new System.Drawing.Point(137, 181);
      this.CategoryLabel.Name = "CategoryLabel";
      this.CategoryLabel.Size = new System.Drawing.Size(110, 27);
      this.CategoryLabel.TabIndex = 3;
      this.CategoryLabel.Text = "Category: ";
      // 
      // CategoryMenu
      // 
      this.CategoryMenu.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CategoryMenu.FormattingEnabled = true;
      this.CategoryMenu.ItemHeight = 22;
      this.CategoryMenu.Items.AddRange(new object[] {
            "Income",
            "Bill",
            "Groceries",
            "Household Item",
            "Clothing",
            "Entertainment",
            "Miscellaneous"});
      this.CategoryMenu.Location = new System.Drawing.Point(253, 181);
      this.CategoryMenu.Name = "CategoryMenu";
      this.CategoryMenu.Size = new System.Drawing.Size(259, 92);
      this.CategoryMenu.TabIndex = 4;
      // 
      // AddButton
      // 
      this.AddButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.AddButton.Location = new System.Drawing.Point(172, 339);
      this.AddButton.Name = "AddButton";
      this.AddButton.Size = new System.Drawing.Size(148, 36);
      this.AddButton.TabIndex = 5;
      this.AddButton.Text = "Add";
      this.AddButton.UseVisualStyleBackColor = true;
      this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
      // 
      // CancelButton
      // 
      this.CancelButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CancelButton.Location = new System.Drawing.Point(363, 339);
      this.CancelButton.Name = "CancelButton";
      this.CancelButton.Size = new System.Drawing.Size(148, 36);
      this.CancelButton.TabIndex = 6;
      this.CancelButton.Text = "Cancel";
      this.CancelButton.UseVisualStyleBackColor = true;
      this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
      // 
      // DateLabel
      // 
      this.DateLabel.AutoSize = true;
      this.DateLabel.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.DateLabel.Location = new System.Drawing.Point(178, 291);
      this.DateLabel.Name = "DateLabel";
      this.DateLabel.Size = new System.Drawing.Size(69, 27);
      this.DateLabel.TabIndex = 7;
      this.DateLabel.Text = "Date: ";
      // 
      // dateTimePicker1
      // 
      this.dateTimePicker1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dateTimePicker1.Location = new System.Drawing.Point(253, 292);
      this.dateTimePicker1.Name = "dateTimePicker1";
      this.dateTimePicker1.Size = new System.Drawing.Size(259, 26);
      this.dateTimePicker1.TabIndex = 8;
      // 
      // AddItem
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Azure;
      this.ClientSize = new System.Drawing.Size(659, 476);
      this.Controls.Add(this.dateTimePicker1);
      this.Controls.Add(this.DateLabel);
      this.Controls.Add(this.CancelButton);
      this.Controls.Add(this.AddButton);
      this.Controls.Add(this.CategoryMenu);
      this.Controls.Add(this.CategoryLabel);
      this.Controls.Add(this.AmountTextBox);
      this.Controls.Add(this.AmountLabel);
      this.Controls.Add(this.Title);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "AddItem";
      this.Text = "Add Expenditure";
      this.Load += new System.EventHandler(this.AddItem_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.ListBox CategoryMenu;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}