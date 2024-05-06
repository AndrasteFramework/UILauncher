using System.ComponentModel;

namespace Andraste.UILauncher.Forms
{
    partial class EditProfileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProfileForm));
            this.txtProfile = new System.Windows.Forms.TextBox();
            this.lblProfile = new System.Windows.Forms.Label();
            this.lblProfileLocation = new System.Windows.Forms.Label();
            this.txtProfileLocation = new System.Windows.Forms.TextBox();
            this.btnBrowseProfileLocation = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnBrowseGame = new System.Windows.Forms.Button();
            this.lblGameLocation = new System.Windows.Forms.Label();
            this.txtGameLocation = new System.Windows.Forms.TextBox();
            this.btnFrameworkLocation = new System.Windows.Forms.Button();
            this.lblFrameworkLocation = new System.Windows.Forms.Label();
            this.txtFrameworkLocation = new System.Windows.Forms.TextBox();
            this.openGameExeDialog = new System.Windows.Forms.OpenFileDialog();
            this.dlgOpenAndrasteDll = new System.Windows.Forms.OpenFileDialog();
            this.lblCommandLine = new System.Windows.Forms.Label();
            this.txtCommandLine = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtProfile
            // 
            this.txtProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProfile.Location = new System.Drawing.Point(118, 11);
            this.txtProfile.Name = "txtProfile";
            this.txtProfile.Size = new System.Drawing.Size(361, 20);
            this.txtProfile.TabIndex = 0;
            this.txtProfile.Text = "New Profile";
            this.txtProfile.WordWrap = false;
            // 
            // lblProfile
            // 
            this.lblProfile.Location = new System.Drawing.Point(12, 9);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(81, 23);
            this.lblProfile.TabIndex = 1;
            this.lblProfile.Text = "Profile Name:";
            this.lblProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProfileLocation
            // 
            this.lblProfileLocation.Location = new System.Drawing.Point(12, 55);
            this.lblProfileLocation.Name = "lblProfileLocation";
            this.lblProfileLocation.Size = new System.Drawing.Size(100, 23);
            this.lblProfileLocation.TabIndex = 3;
            this.lblProfileLocation.Text = "Profile Location:";
            this.lblProfileLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtProfileLocation
            // 
            this.txtProfileLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProfileLocation.Location = new System.Drawing.Point(118, 57);
            this.txtProfileLocation.Name = "txtProfileLocation";
            this.txtProfileLocation.Size = new System.Drawing.Size(296, 20);
            this.txtProfileLocation.TabIndex = 2;
            this.txtProfileLocation.Text = "Loading...";
            this.txtProfileLocation.WordWrap = false;
            // 
            // btnBrowseProfileLocation
            // 
            this.btnBrowseProfileLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseProfileLocation.Location = new System.Drawing.Point(420, 55);
            this.btnBrowseProfileLocation.Name = "btnBrowseProfileLocation";
            this.btnBrowseProfileLocation.Size = new System.Drawing.Size(59, 23);
            this.btnBrowseProfileLocation.TabIndex = 4;
            this.btnBrowseProfileLocation.Text = "Browse";
            this.btnBrowseProfileLocation.UseVisualStyleBackColor = true;
            this.btnBrowseProfileLocation.Click += new System.EventHandler(this.btnBrowseProfileLocation_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(404, 134);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnBrowseGame
            // 
            this.btnBrowseGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseGame.Location = new System.Drawing.Point(420, 32);
            this.btnBrowseGame.Name = "btnBrowseGame";
            this.btnBrowseGame.Size = new System.Drawing.Size(59, 23);
            this.btnBrowseGame.TabIndex = 11;
            this.btnBrowseGame.Text = "Browse";
            this.btnBrowseGame.UseVisualStyleBackColor = true;
            this.btnBrowseGame.Click += new System.EventHandler(this.btnBrowseGame_Click);
            // 
            // lblGameLocation
            // 
            this.lblGameLocation.Location = new System.Drawing.Point(12, 32);
            this.lblGameLocation.Name = "lblGameLocation";
            this.lblGameLocation.Size = new System.Drawing.Size(100, 23);
            this.lblGameLocation.TabIndex = 10;
            this.lblGameLocation.Text = "Game Location:";
            this.lblGameLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGameLocation
            // 
            this.txtGameLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGameLocation.Location = new System.Drawing.Point(118, 34);
            this.txtGameLocation.Name = "txtGameLocation";
            this.txtGameLocation.Size = new System.Drawing.Size(296, 20);
            this.txtGameLocation.TabIndex = 9;
            this.txtGameLocation.Text = "Loading...";
            this.txtGameLocation.WordWrap = false;
            // 
            // btnFrameworkLocation
            // 
            this.btnFrameworkLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFrameworkLocation.Location = new System.Drawing.Point(420, 78);
            this.btnFrameworkLocation.Name = "btnFrameworkLocation";
            this.btnFrameworkLocation.Size = new System.Drawing.Size(59, 23);
            this.btnFrameworkLocation.TabIndex = 14;
            this.btnFrameworkLocation.Text = "Browse";
            this.btnFrameworkLocation.UseVisualStyleBackColor = true;
            this.btnFrameworkLocation.Click += new System.EventHandler(this.btnFrameworkLocation_Click);
            // 
            // lblFrameworkLocation
            // 
            this.lblFrameworkLocation.Location = new System.Drawing.Point(12, 78);
            this.lblFrameworkLocation.Name = "lblFrameworkLocation";
            this.lblFrameworkLocation.Size = new System.Drawing.Size(100, 23);
            this.lblFrameworkLocation.TabIndex = 13;
            this.lblFrameworkLocation.Text = "Andraste Location:";
            this.lblFrameworkLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFrameworkLocation
            // 
            this.txtFrameworkLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFrameworkLocation.Location = new System.Drawing.Point(118, 80);
            this.txtFrameworkLocation.Name = "txtFrameworkLocation";
            this.txtFrameworkLocation.Size = new System.Drawing.Size(296, 20);
            this.txtFrameworkLocation.TabIndex = 12;
            this.txtFrameworkLocation.Text = "Loading...";
            this.txtFrameworkLocation.WordWrap = false;
            // 
            // openGameExeDialog
            // 
            this.openGameExeDialog.DefaultExt = "exe";
            this.openGameExeDialog.FileName = "game.exe";
            this.openGameExeDialog.Filter = "Applications|*.exe";
            this.openGameExeDialog.InitialDirectory = "C:\\Windows\\system32";
            // 
            // dlgOpenAndrasteDll
            // 
            this.dlgOpenAndrasteDll.DefaultExt = "dll";
            this.dlgOpenAndrasteDll.FileName = "Andraste.Payload.Generic.dll";
            this.dlgOpenAndrasteDll.Filter = "Andraste Payload|*.dll";
            this.dlgOpenAndrasteDll.InitialDirectory = "C:\\Windows\\system32";
            // 
            // lblCommandLine
            // 
            this.lblCommandLine.Location = new System.Drawing.Point(12, 101);
            this.lblCommandLine.Name = "lblCommandLine";
            this.lblCommandLine.Size = new System.Drawing.Size(100, 23);
            this.lblCommandLine.TabIndex = 16;
            this.lblCommandLine.Text = "Command Line:";
            this.lblCommandLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCommandLine
            // 
            this.txtCommandLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommandLine.Location = new System.Drawing.Point(118, 103);
            this.txtCommandLine.Name = "txtCommandLine";
            this.txtCommandLine.Size = new System.Drawing.Size(296, 20);
            this.txtCommandLine.TabIndex = 15;
            this.txtCommandLine.Text = "Loading...";
            this.txtCommandLine.WordWrap = false;
            // 
            // EditProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 169);
            this.Controls.Add(this.lblCommandLine);
            this.Controls.Add(this.txtCommandLine);
            this.Controls.Add(this.btnFrameworkLocation);
            this.Controls.Add(this.lblFrameworkLocation);
            this.Controls.Add(this.txtFrameworkLocation);
            this.Controls.Add(this.btnBrowseGame);
            this.Controls.Add(this.lblGameLocation);
            this.Controls.Add(this.txtGameLocation);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnBrowseProfileLocation);
            this.Controls.Add(this.lblProfileLocation);
            this.Controls.Add(this.txtProfileLocation);
            this.Controls.Add(this.lblProfile);
            this.Controls.Add(this.txtProfile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditProfileForm";
            this.Text = "Add or Edit Profile";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblCommandLine;
        private System.Windows.Forms.TextBox txtCommandLine;

        private System.Windows.Forms.OpenFileDialog dlgOpenAndrasteDll;

        private System.Windows.Forms.OpenFileDialog openGameExeDialog;

        private System.Windows.Forms.Button btnBrowseGame;
        private System.Windows.Forms.Label lblGameLocation;
        private System.Windows.Forms.TextBox txtGameLocation;
        private System.Windows.Forms.Button btnFrameworkLocation;
        private System.Windows.Forms.Label lblFrameworkLocation;
        private System.Windows.Forms.TextBox txtFrameworkLocation;

        private System.Windows.Forms.Button btnOk;

        private System.Windows.Forms.Button btnBrowseProfileLocation;

        private System.Windows.Forms.Label lblProfileLocation;
        private System.Windows.Forms.TextBox txtProfileLocation;

        private System.Windows.Forms.TextBox txtProfile;
        private System.Windows.Forms.Label lblProfile;

        #endregion
    }
}