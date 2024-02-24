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
            driveColumnHeader = new ColumnHeader();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem1 = new ToolStripMenuItem();
            txtToolStripMenuItem = new ToolStripMenuItem();
            jsonToolStripMenuItem = new ToolStripMenuItem();
            xmlToolStripMenuItem = new ToolStripMenuItem();
            csvToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            scanAndAppendToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Location = new Point(12, 234);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 1;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(93, 234);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(75, 23);
            EditButton.TabIndex = 2;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(174, 234);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // viewButton
            // 
            viewButton.Location = new Point(255, 234);
            viewButton.Name = "viewButton";
            viewButton.Size = new Size(75, 23);
            viewButton.TabIndex = 4;
            viewButton.Text = "View";
            viewButton.UseVisualStyleBackColor = true;
            viewButton.Click += viewButton_Click;
            // 
            // listView
            // 
            listView.Columns.AddRange(new ColumnHeader[] { titleColumnHeader, yearColumnHeader, durationColumnHeader, driveColumnHeader });
            listView.Location = new Point(11, 27);
            listView.Name = "listView";
            listView.Size = new Size(319, 201);
            listView.TabIndex = 5;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            // 
            // titleColumnHeader
            // 
            titleColumnHeader.Text = "Title";
            titleColumnHeader.Width = 170;
            // 
            // yearColumnHeader
            // 
            yearColumnHeader.Text = "Year";
            yearColumnHeader.Width = 40;
            // 
            // durationColumnHeader
            // 
            durationColumnHeader.Text = "Duration";
            // 
            // driveColumnHeader
            // 
            driveColumnHeader.Text = "Drive";
            driveColumnHeader.Width = 40;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveBorder;
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, toolsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(343, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveAsToolStripMenuItem1 });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(59, 20);
            fileToolStripMenuItem.Text = "Archive";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(180, 22);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(180, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem1
            // 
            saveAsToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { txtToolStripMenuItem, jsonToolStripMenuItem, xmlToolStripMenuItem, csvToolStripMenuItem });
            saveAsToolStripMenuItem1.Name = "saveAsToolStripMenuItem1";
            saveAsToolStripMenuItem1.Size = new Size(180, 22);
            saveAsToolStripMenuItem1.Text = "Save as";
            // 
            // txtToolStripMenuItem
            // 
            txtToolStripMenuItem.Name = "txtToolStripMenuItem";
            txtToolStripMenuItem.Size = new Size(180, 22);
            txtToolStripMenuItem.Text = ".txt";
            txtToolStripMenuItem.Click += txtToolStripMenuItem_Click;
            // 
            // jsonToolStripMenuItem
            // 
            jsonToolStripMenuItem.Name = "jsonToolStripMenuItem";
            jsonToolStripMenuItem.Size = new Size(180, 22);
            jsonToolStripMenuItem.Text = ".json";
            jsonToolStripMenuItem.Click += jsonToolStripMenuItem_Click;
            // 
            // xmlToolStripMenuItem
            // 
            xmlToolStripMenuItem.Name = "xmlToolStripMenuItem";
            xmlToolStripMenuItem.Size = new Size(180, 22);
            xmlToolStripMenuItem.Text = ".xml";
            xmlToolStripMenuItem.Click += xmlToolStripMenuItem_Click;
            // 
            // csvToolStripMenuItem
            // 
            csvToolStripMenuItem.Name = "csvToolStripMenuItem";
            csvToolStripMenuItem.Size = new Size(180, 22);
            csvToolStripMenuItem.Text = ".csv";
            csvToolStripMenuItem.Click += csvToolStripMenuItem_Click;
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { scanAndAppendToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(46, 20);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // scanAndAppendToolStripMenuItem
            // 
            scanAndAppendToolStripMenuItem.Name = "scanAndAppendToolStripMenuItem";
            scanAndAppendToolStripMenuItem.Size = new Size(167, 22);
            scanAndAppendToolStripMenuItem.Text = "Scan and Append";
            scanAndAppendToolStripMenuItem.Click += scanAndAppendToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(107, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 261);
            Controls.Add(listView);
            Controls.Add(viewButton);
            Controls.Add(deleteButton);
            Controls.Add(EditButton);
            Controls.Add(addButton);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Movie Manager";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem scanAndAppendToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem1;
        private ToolStripMenuItem txtToolStripMenuItem;
        private ToolStripMenuItem jsonToolStripMenuItem;
        private ToolStripMenuItem xmlToolStripMenuItem;
        private ToolStripMenuItem csvToolStripMenuItem;
        private ColumnHeader driveColumnHeader;
    }
}
