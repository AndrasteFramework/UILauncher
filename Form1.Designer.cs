namespace Andraste.UILauncher
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnRefreshMods = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.enabled = new System.Windows.Forms.ColumnHeader();
            this.shortName = new System.Windows.Forms.ColumnHeader();
            this.description = new System.Windows.Forms.ColumnHeader();
            this.author = new System.Windows.Forms.ColumnHeader();
            this.displayVersion = new System.Windows.Forms.ColumnHeader();
            this.priority = new System.Windows.Forms.ColumnHeader();
            this.dropProfile = new System.Windows.Forms.ComboBox();
            this.btnManageProfiles = new System.Windows.Forms.Button();
            this.btnOpenModFolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar1.Location = new System.Drawing.Point(13, 281);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(774, 19);
            this.progressBar1.TabIndex = 1;
            // 
            // btnStartGame
            // 
            this.btnStartGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartGame.Location = new System.Drawing.Point(676, 345);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(112, 29);
            this.btnStartGame.TabIndex = 2;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnRefreshMods
            // 
            this.btnRefreshMods.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefreshMods.Image = global::Andraste.UILauncher.Properties.Resources.folder_explore;
            this.btnRefreshMods.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshMods.Location = new System.Drawing.Point(13, 338);
            this.btnRefreshMods.Name = "btnRefreshMods";
            this.btnRefreshMods.Size = new System.Drawing.Size(112, 33);
            this.btnRefreshMods.TabIndex = 3;
            this.btnRefreshMods.Text = "Refresh Mods";
            this.btnRefreshMods.UseVisualStyleBackColor = true;
            this.btnRefreshMods.Click += new System.EventHandler(this.btnRefreshMods_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.enabled, this.shortName, this.description, this.author, this.displayVersion, this.priority });
            this.listView1.Enabled = false;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 13);
            this.listView1.Name = "listView1";
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(771, 251);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseUp);
            // 
            // enabled
            // 
            this.enabled.Text = "Enabled";
            this.enabled.Width = 55;
            // 
            // shortName
            // 
            this.shortName.Text = "Name";
            this.shortName.Width = 200;
            // 
            // description
            // 
            this.description.Text = "Description";
            this.description.Width = 270;
            // 
            // author
            // 
            this.author.Text = "Authors";
            this.author.Width = 125;
            // 
            // displayVersion
            // 
            this.displayVersion.Text = "Version";
            this.displayVersion.Width = 65;
            // 
            // priority
            // 
            this.priority.Text = "Priority";
            this.priority.Width = 50;
            // 
            // dropProfile
            // 
            this.dropProfile.AccessibleName = "profile list";
            this.dropProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dropProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropProfile.Items.AddRange(new object[] { "Loading profiles..." });
            this.dropProfile.Location = new System.Drawing.Point(132, 350);
            this.dropProfile.Name = "dropProfile";
            this.dropProfile.Size = new System.Drawing.Size(335, 21);
            this.dropProfile.TabIndex = 5;
            this.dropProfile.SelectedIndexChanged += new System.EventHandler(this.dropProfile_SelectedIndexChanged);
            // 
            // btnManageProfiles
            // 
            this.btnManageProfiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnManageProfiles.Location = new System.Drawing.Point(473, 348);
            this.btnManageProfiles.Name = "btnManageProfiles";
            this.btnManageProfiles.Size = new System.Drawing.Size(95, 23);
            this.btnManageProfiles.TabIndex = 6;
            this.btnManageProfiles.Text = "Manage Profiles";
            this.btnManageProfiles.UseVisualStyleBackColor = true;
            this.btnManageProfiles.Click += new System.EventHandler(this.btnManageProfiles_Click);
            // 
            // btnOpenModFolder
            // 
            this.btnOpenModFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOpenModFolder.Image = global::Andraste.UILauncher.Properties.Resources.folder_go;
            this.btnOpenModFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenModFolder.Location = new System.Drawing.Point(13, 306);
            this.btnOpenModFolder.Name = "btnOpenModFolder";
            this.btnOpenModFolder.Size = new System.Drawing.Size(112, 31);
            this.btnOpenModFolder.TabIndex = 7;
            this.btnOpenModFolder.Text = "Mod Folder";
            this.btnOpenModFolder.UseVisualStyleBackColor = true;
            this.btnOpenModFolder.Click += new System.EventHandler(this.btnOpenModFolder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(796, 383);
            this.Controls.Add(this.btnOpenModFolder);
            this.Controls.Add(this.btnManageProfiles);
            this.Controls.Add(this.dropProfile);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnRefreshMods);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.progressBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Andraste UI Launcher";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnOpenModFolder;

        private System.Windows.Forms.ColumnHeader description;

        private System.Windows.Forms.ColumnHeader author;

        private System.Windows.Forms.Button btnManageProfiles;

        private System.Windows.Forms.ColumnHeader priority;

        private System.Windows.Forms.ComboBox dropProfile;

        private System.Windows.Forms.ColumnHeader displayVersion;

        private System.Windows.Forms.ColumnHeader enabled;
        private System.Windows.Forms.ColumnHeader shortName;

        private System.Windows.Forms.Button btnRefreshMods;

        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.ProgressBar progressBar1;

        #endregion

        private System.Windows.Forms.ListView listView1;
    }
}