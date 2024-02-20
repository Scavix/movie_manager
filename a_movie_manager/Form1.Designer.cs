namespace a_movie_manager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addButton = new Button();
            EditButton = new Button();
            deleteButton = new Button();
            viewButton = new Button();
            listView = new ListView();
            titleColumnHeader = new ColumnHeader();
            yearColumnHeader = new ColumnHeader();
            durationColumnHeader = new ColumnHeader();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Location = new Point(12, 219);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 1;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(93, 219);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(75, 23);
            EditButton.TabIndex = 2;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(174, 219);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // viewButton
            // 
            viewButton.Location = new Point(255, 219);
            viewButton.Name = "viewButton";
            viewButton.Size = new Size(75, 23);
            viewButton.TabIndex = 4;
            viewButton.Text = "View";
            viewButton.UseVisualStyleBackColor = true;
            viewButton.Click += viewButton_Click;
            // 
            // listView
            // 
            listView.Columns.AddRange(new ColumnHeader[] { titleColumnHeader, yearColumnHeader, durationColumnHeader });
            listView.Location = new Point(12, 12);
            listView.Name = "listView";
            listView.Size = new Size(319, 201);
            listView.TabIndex = 5;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            // 
            // titleColumnHeader
            // 
            titleColumnHeader.Text = "Title";
            titleColumnHeader.Width = 150;
            // 
            // yearColumnHeader
            // 
            yearColumnHeader.Text = "Year";
            yearColumnHeader.Width = 80;
            // 
            // durationColumnHeader
            // 
            durationColumnHeader.Text = "Duration";
            durationColumnHeader.Width = 80;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 254);
            Controls.Add(listView);
            Controls.Add(viewButton);
            Controls.Add(deleteButton);
            Controls.Add(EditButton);
            Controls.Add(addButton);
            Name = "Form1";
            Text = "Movie Manager";
            ResumeLayout(false);
        }

        #endregion
        private Button addButton;
        private Button EditButton;
        private Button deleteButton;
        private Button viewButton;
        private ListView listView;
        private ColumnHeader titleColumnHeader;
        private ColumnHeader yearColumnHeader;
        private ColumnHeader durationColumnHeader;
    }
}
