namespace a_movie_manager
{
    partial class Form3
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
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            yearLabel = new Label();
            driveLabel = new Label();
            durationLabel = new Label();
            directorsLabel = new Label();
            titleLabel = new Label();
            okButton = new Button();
            label5 = new Label();
            descriptionRichTextBox = new RichTextBox();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 125);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 19;
            label6.Text = "Year";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 96);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 18;
            label4.Text = "Drive";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 67);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 17;
            label3.Text = "Duration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 16;
            label2.Text = "Director(s)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 15;
            label1.Text = "Title";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new Point(89, 125);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(12, 15);
            yearLabel.TabIndex = 24;
            yearLabel.Text = "-";
            // 
            // driveLabel
            // 
            driveLabel.AutoSize = true;
            driveLabel.Location = new Point(89, 96);
            driveLabel.Name = "driveLabel";
            driveLabel.Size = new Size(12, 15);
            driveLabel.TabIndex = 23;
            driveLabel.Text = "-";
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Location = new Point(89, 67);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(12, 15);
            durationLabel.TabIndex = 22;
            durationLabel.Text = "-";
            // 
            // directorsLabel
            // 
            directorsLabel.AutoSize = true;
            directorsLabel.Location = new Point(89, 38);
            directorsLabel.Name = "directorsLabel";
            directorsLabel.Size = new Size(12, 15);
            directorsLabel.TabIndex = 21;
            directorsLabel.Text = "-";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(89, 9);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(12, 15);
            titleLabel.TabIndex = 20;
            titleLabel.Text = "-";
            // 
            // okButton
            // 
            okButton.DialogResult = DialogResult.OK;
            okButton.Location = new Point(12, 267);
            okButton.Name = "okButton";
            okButton.Size = new Size(174, 23);
            okButton.TabIndex = 25;
            okButton.Text = "Close";
            okButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 154);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 26;
            label5.Text = "Description";
            // 
            // descriptionRichTextBox
            // 
            descriptionRichTextBox.Location = new Point(12, 172);
            descriptionRichTextBox.Name = "descriptionRichTextBox";
            descriptionRichTextBox.Size = new Size(174, 89);
            descriptionRichTextBox.TabIndex = 27;
            descriptionRichTextBox.Text = "";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(198, 302);
            Controls.Add(descriptionRichTextBox);
            Controls.Add(label5);
            Controls.Add(okButton);
            Controls.Add(yearLabel);
            Controls.Add(driveLabel);
            Controls.Add(durationLabel);
            Controls.Add(directorsLabel);
            Controls.Add(titleLabel);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "View form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label yearLabel;
        private Label driveLabel;
        private Label durationLabel;
        private Label directorsLabel;
        private Label titleLabel;
        private Button okButton;
        private Label label5;
        private RichTextBox descriptionRichTextBox;
    }
}