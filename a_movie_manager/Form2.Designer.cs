namespace a_movie_manager
{
    partial class Form2
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
            titleTextBox = new TextBox();
            label1 = new Label();
            directorsTextBox = new TextBox();
            label2 = new Label();
            durationTextBox = new TextBox();
            label3 = new Label();
            driveTextBox = new TextBox();
            label4 = new Label();
            descriptionRichTextBox = new RichTextBox();
            label5 = new Label();
            okButton = new Button();
            cancelButton = new Button();
            yearTextBox = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(154, 12);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(100, 23);
            titleTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 1;
            label1.Text = "Enter movie name";
            // 
            // directorsTextBox
            // 
            directorsTextBox.Location = new Point(154, 41);
            directorsTextBox.Name = "directorsTextBox";
            directorsTextBox.Size = new Size(100, 23);
            directorsTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(137, 15);
            label2.TabIndex = 3;
            label2.Text = "Enter director(s) name(s)";
            // 
            // durationTextBox
            // 
            durationTextBox.Location = new Point(154, 70);
            durationTextBox.Name = "durationTextBox";
            durationTextBox.Size = new Size(100, 23);
            durationTextBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 73);
            label3.Name = "label3";
            label3.Size = new Size(118, 15);
            label3.TabIndex = 5;
            label3.Text = "Enter movie duration";
            // 
            // driveTextBox
            // 
            driveTextBox.Location = new Point(154, 99);
            driveTextBox.Name = "driveTextBox";
            driveTextBox.Size = new Size(100, 23);
            driveTextBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 102);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 7;
            label4.Text = "Enter movie drive";
            // 
            // descriptionRichTextBox
            // 
            descriptionRichTextBox.Location = new Point(12, 178);
            descriptionRichTextBox.Name = "descriptionRichTextBox";
            descriptionRichTextBox.Size = new Size(239, 96);
            descriptionRichTextBox.TabIndex = 8;
            descriptionRichTextBox.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 160);
            label5.Name = "label5";
            label5.Size = new Size(132, 15);
            label5.TabIndex = 10;
            label5.Text = "Enter movie description";
            // 
            // okButton
            // 
            okButton.DialogResult = DialogResult.OK;
            okButton.Location = new Point(12, 280);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 11;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(176, 280);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 12;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // yearTextBox
            // 
            yearTextBox.Location = new Point(154, 128);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new Size(100, 23);
            yearTextBox.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 131);
            label6.Name = "label6";
            label6.Size = new Size(95, 15);
            label6.TabIndex = 14;
            label6.Text = "Enter movie year";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(263, 310);
            Controls.Add(label6);
            Controls.Add(yearTextBox);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(label5);
            Controls.Add(descriptionRichTextBox);
            Controls.Add(label4);
            Controls.Add(driveTextBox);
            Controls.Add(label3);
            Controls.Add(durationTextBox);
            Controls.Add(label2);
            Controls.Add(directorsTextBox);
            Controls.Add(label1);
            Controls.Add(titleTextBox);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox titleTextBox;
        private Label label1;
        private TextBox directorsTextBox;
        private Label label2;
        private TextBox durationTextBox;
        private Label label3;
        private TextBox driveTextBox;
        private Label label4;
        private RichTextBox descriptionRichTextBox;
        private Label label5;
        private Button okButton;
        private Button cancelButton;
        private TextBox yearTextBox;
        private Label label6;
    }
}