namespace BlingBling
{
    partial class EditItem
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
      this.BeginDateLabel = new System.Windows.Forms.Label();
      this.BeginDateTimePicker = new System.Windows.Forms.DateTimePicker();
      this.EndDateLabel = new System.Windows.Forms.Label();
      this.EndDateTimePicker = new System.Windows.Forms.DateTimePicker();
      this.SearchButton = new System.Windows.Forms.Button();
      this.CancelButton = new System.Windows.Forms.Button();
      this.ResultBox = new System.Windows.Forms.RichTextBox();
      this.SuspendLayout();
      // 
      // Title
      // 
      this.Title.AutoSize = true;
      this.Title.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Title.Location = new System.Drawing.Point(199, 47);
      this.Title.Name = "Title";
      this.Title.Size = new System.Drawing.Size(260, 40);
      this.Title.TabIndex = 0;
      this.Title.Text = "Edit/Delete Item";
      // 
      // BeginDateLabel
      // 
      this.BeginDateLabel.AutoSize = true;
      this.BeginDateLabel.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BeginDateLabel.Location = new System.Drawing.Point(131, 150);
      this.BeginDateLabel.Name = "BeginDateLabel";
      this.BeginDateLabel.Size = new System.Drawing.Size(120, 27);
      this.BeginDateLabel.TabIndex = 1;
      this.BeginDateLabel.Text = "Begin Date:";
      // 
      // BeginDateTimePicker
      // 
      this.BeginDateTimePicker.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BeginDateTimePicker.Location = new System.Drawing.Point(257, 151);
      this.BeginDateTimePicker.Name = "BeginDateTimePicker";
      this.BeginDateTimePicker.Size = new System.Drawing.Size(270, 26);
      this.BeginDateTimePicker.TabIndex = 3;
      // 
      // EndDateLabel
      // 
      this.EndDateLabel.AutoSize = true;
      this.EndDateLabel.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.EndDateLabel.Location = new System.Drawing.Point(148, 204);
      this.EndDateLabel.Name = "EndDateLabel";
      this.EndDateLabel.Size = new System.Drawing.Size(103, 27);
      this.EndDateLabel.TabIndex = 4;
      this.EndDateLabel.Text = "End Date:";
      // 
      // EndDateTimePicker
      // 
      this.EndDateTimePicker.CalendarFont = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.EndDateTimePicker.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.EndDateTimePicker.Location = new System.Drawing.Point(259, 205);
      this.EndDateTimePicker.Name = "EndDateTimePicker";
      this.EndDateTimePicker.Size = new System.Drawing.Size(268, 26);
      this.EndDateTimePicker.TabIndex = 5;
      // 
      // SearchButton
      // 
      this.SearchButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.SearchButton.Location = new System.Drawing.Point(168, 355);
      this.SearchButton.Name = "SearchButton";
      this.SearchButton.Size = new System.Drawing.Size(132, 33);
      this.SearchButton.TabIndex = 6;
      this.SearchButton.Text = "Search";
      this.SearchButton.UseVisualStyleBackColor = true;
      this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
      // 
      // CancelButton
      // 
      this.CancelButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CancelButton.Location = new System.Drawing.Point(358, 357);
      this.CancelButton.Name = "CancelButton";
      this.CancelButton.Size = new System.Drawing.Size(132, 33);
      this.CancelButton.TabIndex = 7;
      this.CancelButton.Text = "Cancel";
      this.CancelButton.UseVisualStyleBackColor = true;
      this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
      // 
      // ResultBox
      // 
      this.ResultBox.BackColor = System.Drawing.Color.Azure;
      this.ResultBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.ResultBox.Location = new System.Drawing.Point(150, 253);
      this.ResultBox.Name = "ResultBox";
      this.ResultBox.Size = new System.Drawing.Size(359, 80);
      this.ResultBox.TabIndex = 8;
      this.ResultBox.Text = "";
      // 
      // EditItem
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Azure;
      this.ClientSize = new System.Drawing.Size(659, 476);
      this.Controls.Add(this.ResultBox);
      this.Controls.Add(this.CancelButton);
      this.Controls.Add(this.SearchButton);
      this.Controls.Add(this.EndDateTimePicker);
      this.Controls.Add(this.EndDateLabel);
      this.Controls.Add(this.BeginDateTimePicker);
      this.Controls.Add(this.BeginDateLabel);
      this.Controls.Add(this.Title);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "EditItem";
      this.Text = "Edit Item";
      this.Load += new System.EventHandler(this.EditItem_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label BeginDateLabel;
        private System.Windows.Forms.DateTimePicker BeginDateTimePicker;
        private System.Windows.Forms.Label EndDateLabel;
        private System.Windows.Forms.DateTimePicker EndDateTimePicker;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.RichTextBox ResultBox;

    }
}