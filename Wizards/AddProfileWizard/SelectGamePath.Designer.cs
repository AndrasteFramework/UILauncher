using System.ComponentModel;

namespace Andraste.UILauncher.Wizards.AddProfileWizard
{
    partial class SelectGamePath
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtGameLocation = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.dlgBrowseGame = new System.Windows.Forms.OpenFileDialog();
            this.lblCommandLine = new System.Windows.Forms.Label();
            this.txtCommandLine = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtGameLocation
            // 
            this.txtGameLocation.Location = new System.Drawing.Point(110, 29);
            this.txtGameLocation.Name = "txtGameLocation";
            this.txtGameLocation.Size = new System.Drawing.Size(332, 20);
            this.txtGameLocation.TabIndex = 0;
            this.txtGameLocation.TextChanged += new System.EventHandler(this.txtGameLocation_TextChanged);
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(3, 9);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(346, 23);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Please choose the game application (.exe) to which this profile belongs.";
            // 
            // lblPath
            // 
            this.lblPath.Location = new System.Drawing.Point(3, 32);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(101, 23);
            this.lblPath.TabIndex = 2;
            this.lblPath.Text = "Game Path:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(448, 27);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // dlgBrowseGame
            // 
            this.dlgBrowseGame.DefaultExt = "exe";
            this.dlgBrowseGame.FileName = "Game.exe";
            this.dlgBrowseGame.Filter = "Applications|*.exe";
            // 
            // lblCommandLine
            // 
            this.lblCommandLine.Location = new System.Drawing.Point(3, 58);
            this.lblCommandLine.Name = "lblCommandLine";
            this.lblCommandLine.Size = new System.Drawing.Size(101, 23);
            this.lblCommandLine.TabIndex = 5;
            this.lblCommandLine.Text = "Command Line:";
            // 
            // txtCommandLine
            // 
            this.txtCommandLine.Location = new System.Drawing.Point(110, 55);
            this.txtCommandLine.Name = "txtCommandLine";
            this.txtCommandLine.Size = new System.Drawing.Size(332, 20);
            this.txtCommandLine.TabIndex = 4;
            // 
            // SelectGamePath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCommandLine);
            this.Controls.Add(this.txtCommandLine);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtGameLocation);
            this.Name = "SelectGamePath";
            this.Size = new System.Drawing.Size(523, 206);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblCommandLine;
        private System.Windows.Forms.TextBox txtCommandLine;

        private System.Windows.Forms.OpenFileDialog dlgBrowseGame;

        private System.Windows.Forms.Button btnBrowse;

        private System.Windows.Forms.Label lblPath;

        private System.Windows.Forms.Label lblDescription;

        private System.Windows.Forms.TextBox txtGameLocation;

        #endregion
    }
}