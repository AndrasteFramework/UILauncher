using System.ComponentModel;

namespace Andraste.UILauncher.Wizards.AddProfileWizard
{
    partial class SelectProfileName
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
            this.lblProfileName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblProfileName
            // 
            this.lblProfileName.Location = new System.Drawing.Point(3, 52);
            this.lblProfileName.Name = "lblProfileName";
            this.lblProfileName.Size = new System.Drawing.Size(101, 23);
            this.lblProfileName.TabIndex = 6;
            this.lblProfileName.Text = "Profile Name:";
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(3, 9);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(457, 32);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Please choose a descriptive name for this profile so you can recognize your mod c" + "ollection.\r\nNote: This should not contain special characters, so we can create a" + " folder with that name.";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(350, 20);
            this.textBox1.TabIndex = 4;
            // 
            // SelectProfileName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblProfileName);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.textBox1);
            this.Name = "SelectProfileName";
            this.Size = new System.Drawing.Size(523, 206);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblProfileName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox textBox1;

        #endregion
    }
}