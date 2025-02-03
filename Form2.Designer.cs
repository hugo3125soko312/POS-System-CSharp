namespace WinFormsApp1
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
            label1 = new Label();
            userLabel = new Label();
            button2 = new Button();
            menuStrip1 = new MenuStrip();
            souborToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            loadFromToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            websiteToolStripMenuItem = new ToolStripMenuItem();
            contactsToolStripMenuItem = new ToolStripMenuItem();
            helpdeskIDToolStripMenuItem = new ToolStripMenuItem();
            teamspeakToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(567, 58);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 0;
            label1.Text = "logged in as: ";
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Location = new Point(654, 87);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(57, 15);
            userLabel.TabIndex = 2;
            userLabel.Text = "userLabel";
            // 
            // button2
            // 
            button2.Location = new Point(727, 58);
            button2.Name = "button2";
            button2.Size = new Size(64, 23);
            button2.TabIndex = 3;
            button2.Text = "THEME";
            button2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { souborToolStripMenuItem, viewToolStripMenuItem, toolStripMenuItem1, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1207, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // souborToolStripMenuItem
            // 
            souborToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadFromToolStripMenuItem });
            souborToolStripMenuItem.Name = "souborToolStripMenuItem";
            souborToolStripMenuItem.Size = new Size(37, 20);
            souborToolStripMenuItem.Text = "File";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(61, 20);
            viewToolStripMenuItem.Text = "Options";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(44, 20);
            toolStripMenuItem1.Text = "View";
            // 
            // loadFromToolStripMenuItem
            // 
            loadFromToolStripMenuItem.Name = "loadFromToolStripMenuItem";
            loadFromToolStripMenuItem.Size = new Size(180, 22);
            loadFromToolStripMenuItem.Text = "Load from";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { websiteToolStripMenuItem, contactsToolStripMenuItem, helpdeskIDToolStripMenuItem, teamspeakToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // websiteToolStripMenuItem
            // 
            websiteToolStripMenuItem.Name = "websiteToolStripMenuItem";
            websiteToolStripMenuItem.Size = new Size(180, 22);
            websiteToolStripMenuItem.Text = "Website";
            // 
            // contactsToolStripMenuItem
            // 
            contactsToolStripMenuItem.Name = "contactsToolStripMenuItem";
            contactsToolStripMenuItem.Size = new Size(180, 22);
            contactsToolStripMenuItem.Text = "Contacts";
            // 
            // helpdeskIDToolStripMenuItem
            // 
            helpdeskIDToolStripMenuItem.Name = "helpdeskIDToolStripMenuItem";
            helpdeskIDToolStripMenuItem.Size = new Size(180, 22);
            helpdeskIDToolStripMenuItem.Text = "Helpdesk ID";
            // 
            // teamspeakToolStripMenuItem
            // 
            teamspeakToolStripMenuItem.Name = "teamspeakToolStripMenuItem";
            teamspeakToolStripMenuItem.Size = new Size(180, 22);
            teamspeakToolStripMenuItem.Text = "Teamspeak";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1207, 626);
            Controls.Add(button2);
            Controls.Add(userLabel);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            Text = "Form2";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label userLabel;
        private Button button2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem souborToolStripMenuItem;
        private ToolStripMenuItem loadFromToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem websiteToolStripMenuItem;
        private ToolStripMenuItem contactsToolStripMenuItem;
        private ToolStripMenuItem helpdeskIDToolStripMenuItem;
        private ToolStripMenuItem teamspeakToolStripMenuItem;
    }
}