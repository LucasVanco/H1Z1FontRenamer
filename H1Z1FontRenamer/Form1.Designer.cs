namespace H1Z1FontRenamer
{
    partial class H1Z1FontRenamer
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(H1Z1FontRenamer));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.renameButton = new System.Windows.Forms.Button();
            this.destinationFolderButton = new System.Windows.Forms.Button();
            this.destinationText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fontFileButton = new System.Windows.Forms.Button();
            this.fontFileText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.advancedPanel = new System.Windows.Forms.Panel();
            this.advFolderDestButton = new System.Windows.Forms.Button();
            this.advFolderDestText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.boldFontButton = new System.Windows.Forms.Button();
            this.boldFontText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mediumFontButton = new System.Windows.Forms.Button();
            this.mediumFontText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.advRenameButton = new System.Windows.Forms.Button();
            this.lightFontButton = new System.Windows.Forms.Button();
            this.lightFontText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.basicPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.advancedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(269, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsMenuItem
            // 
            this.optionsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.advancedMenuItem});
            this.optionsMenuItem.Name = "optionsMenuItem";
            this.optionsMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsMenuItem.Text = "Options";
            // 
            // advancedMenuItem
            // 
            this.advancedMenuItem.Name = "advancedMenuItem";
            this.advancedMenuItem.Size = new System.Drawing.Size(127, 22);
            this.advancedMenuItem.Text = "Advanced";
            this.advancedMenuItem.Click += new System.EventHandler(this.advancedMenuItem_Click);
            // 
            // basicPanel
            // 
            this.basicPanel.Controls.Add(this.pictureBox1);
            this.basicPanel.Controls.Add(this.renameButton);
            this.basicPanel.Controls.Add(this.destinationFolderButton);
            this.basicPanel.Controls.Add(this.destinationText);
            this.basicPanel.Controls.Add(this.label2);
            this.basicPanel.Controls.Add(this.fontFileButton);
            this.basicPanel.Controls.Add(this.fontFileText);
            this.basicPanel.Controls.Add(this.label1);
            this.basicPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basicPanel.Location = new System.Drawing.Point(0, 24);
            this.basicPanel.Name = "basicPanel";
            this.basicPanel.Size = new System.Drawing.Size(269, 295);
            this.basicPanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(191, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.showCredit);
            // 
            // renameButton
            // 
            this.renameButton.Location = new System.Drawing.Point(16, 124);
            this.renameButton.Name = "renameButton";
            this.renameButton.Size = new System.Drawing.Size(83, 20);
            this.renameButton.TabIndex = 23;
            this.renameButton.Text = "Rename !";
            this.renameButton.UseVisualStyleBackColor = true;
            this.renameButton.Click += new System.EventHandler(this.renameButton_Click);
            // 
            // destinationFolderButton
            // 
            this.destinationFolderButton.Location = new System.Drawing.Point(173, 77);
            this.destinationFolderButton.Name = "destinationFolderButton";
            this.destinationFolderButton.Size = new System.Drawing.Size(83, 20);
            this.destinationFolderButton.TabIndex = 22;
            this.destinationFolderButton.Text = "Browse";
            this.destinationFolderButton.UseVisualStyleBackColor = true;
            this.destinationFolderButton.Click += new System.EventHandler(this.destinationFolderButton_Click);
            // 
            // destinationText
            // 
            this.destinationText.Location = new System.Drawing.Point(16, 77);
            this.destinationText.Name = "destinationText";
            this.destinationText.Size = new System.Drawing.Size(151, 20);
            this.destinationText.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Destination folder";
            // 
            // fontFileButton
            // 
            this.fontFileButton.Location = new System.Drawing.Point(173, 25);
            this.fontFileButton.Name = "fontFileButton";
            this.fontFileButton.Size = new System.Drawing.Size(83, 20);
            this.fontFileButton.TabIndex = 19;
            this.fontFileButton.Text = "Browse";
            this.fontFileButton.UseVisualStyleBackColor = true;
            this.fontFileButton.Click += new System.EventHandler(this.fontFileButton_Click);
            // 
            // fontFileText
            // 
            this.fontFileText.Location = new System.Drawing.Point(16, 25);
            this.fontFileText.Name = "fontFileText";
            this.fontFileText.Size = new System.Drawing.Size(151, 20);
            this.fontFileText.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Font file path";
            // 
            // advancedPanel
            // 
            this.advancedPanel.Controls.Add(this.advFolderDestButton);
            this.advancedPanel.Controls.Add(this.advFolderDestText);
            this.advancedPanel.Controls.Add(this.label6);
            this.advancedPanel.Controls.Add(this.boldFontButton);
            this.advancedPanel.Controls.Add(this.boldFontText);
            this.advancedPanel.Controls.Add(this.label5);
            this.advancedPanel.Controls.Add(this.mediumFontButton);
            this.advancedPanel.Controls.Add(this.mediumFontText);
            this.advancedPanel.Controls.Add(this.label3);
            this.advancedPanel.Controls.Add(this.pictureBox2);
            this.advancedPanel.Controls.Add(this.advRenameButton);
            this.advancedPanel.Controls.Add(this.lightFontButton);
            this.advancedPanel.Controls.Add(this.lightFontText);
            this.advancedPanel.Controls.Add(this.label4);
            this.advancedPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedPanel.Location = new System.Drawing.Point(0, 24);
            this.advancedPanel.Name = "advancedPanel";
            this.advancedPanel.Size = new System.Drawing.Size(269, 295);
            this.advancedPanel.TabIndex = 2;
            this.advancedPanel.Visible = false;
            // 
            // advFolderDestButton
            // 
            this.advFolderDestButton.Location = new System.Drawing.Point(173, 169);
            this.advFolderDestButton.Name = "advFolderDestButton";
            this.advFolderDestButton.Size = new System.Drawing.Size(83, 20);
            this.advFolderDestButton.TabIndex = 41;
            this.advFolderDestButton.Text = "Browse";
            this.advFolderDestButton.UseVisualStyleBackColor = true;
            this.advFolderDestButton.Click += new System.EventHandler(this.advFolderDestButton_Click);
            // 
            // advFolderDestText
            // 
            this.advFolderDestText.Location = new System.Drawing.Point(16, 169);
            this.advFolderDestText.Name = "advFolderDestText";
            this.advFolderDestText.Size = new System.Drawing.Size(151, 20);
            this.advFolderDestText.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Destination folder";
            // 
            // boldFontButton
            // 
            this.boldFontButton.Location = new System.Drawing.Point(173, 105);
            this.boldFontButton.Name = "boldFontButton";
            this.boldFontButton.Size = new System.Drawing.Size(83, 20);
            this.boldFontButton.TabIndex = 38;
            this.boldFontButton.Text = "Browse";
            this.boldFontButton.UseVisualStyleBackColor = true;
            this.boldFontButton.Click += new System.EventHandler(this.boldFontButton_Click);
            // 
            // boldFontText
            // 
            this.boldFontText.Location = new System.Drawing.Point(16, 105);
            this.boldFontText.Name = "boldFontText";
            this.boldFontText.Size = new System.Drawing.Size(151, 20);
            this.boldFontText.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Bold font file path";
            // 
            // mediumFontButton
            // 
            this.mediumFontButton.Location = new System.Drawing.Point(173, 65);
            this.mediumFontButton.Name = "mediumFontButton";
            this.mediumFontButton.Size = new System.Drawing.Size(83, 20);
            this.mediumFontButton.TabIndex = 35;
            this.mediumFontButton.Text = "Browse";
            this.mediumFontButton.UseVisualStyleBackColor = true;
            this.mediumFontButton.Click += new System.EventHandler(this.mediumFontButton_Click);
            // 
            // mediumFontText
            // 
            this.mediumFontText.Location = new System.Drawing.Point(16, 65);
            this.mediumFontText.Name = "mediumFontText";
            this.mediumFontText.Size = new System.Drawing.Size(151, 20);
            this.mediumFontText.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Medium/Regular font file path";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(204, 202);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.showCredit);
            // 
            // advRenameButton
            // 
            this.advRenameButton.Location = new System.Drawing.Point(16, 216);
            this.advRenameButton.Name = "advRenameButton";
            this.advRenameButton.Size = new System.Drawing.Size(83, 20);
            this.advRenameButton.TabIndex = 31;
            this.advRenameButton.Text = "Rename !";
            this.advRenameButton.UseVisualStyleBackColor = true;
            this.advRenameButton.Click += new System.EventHandler(this.advRenameButton_Click);
            // 
            // lightFontButton
            // 
            this.lightFontButton.Location = new System.Drawing.Point(173, 25);
            this.lightFontButton.Name = "lightFontButton";
            this.lightFontButton.Size = new System.Drawing.Size(83, 20);
            this.lightFontButton.TabIndex = 27;
            this.lightFontButton.Text = "Browse";
            this.lightFontButton.UseVisualStyleBackColor = true;
            this.lightFontButton.Click += new System.EventHandler(this.lightFontButton_Click);
            // 
            // lightFontText
            // 
            this.lightFontText.Location = new System.Drawing.Point(16, 25);
            this.lightFontText.Name = "lightFontText";
            this.lightFontText.Size = new System.Drawing.Size(151, 20);
            this.lightFontText.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Light font file path";
            // 
            // H1Z1FontRenamer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(269, 319);
            this.Controls.Add(this.advancedPanel);
            this.Controls.Add(this.basicPanel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "H1Z1FontRenamer";
            this.Text = "H1Z1FontRenamer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.basicPanel.ResumeLayout(false);
            this.basicPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.advancedPanel.ResumeLayout(false);
            this.advancedPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advancedMenuItem;
        private System.Windows.Forms.Panel basicPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button renameButton;
        private System.Windows.Forms.Button destinationFolderButton;
        private System.Windows.Forms.TextBox destinationText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button fontFileButton;
        private System.Windows.Forms.TextBox fontFileText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel advancedPanel;
        private System.Windows.Forms.Button advFolderDestButton;
        private System.Windows.Forms.TextBox advFolderDestText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button boldFontButton;
        private System.Windows.Forms.TextBox boldFontText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button mediumFontButton;
        private System.Windows.Forms.TextBox mediumFontText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button advRenameButton;
        private System.Windows.Forms.Button lightFontButton;
        private System.Windows.Forms.TextBox lightFontText;
        private System.Windows.Forms.Label label4;
    }
}

