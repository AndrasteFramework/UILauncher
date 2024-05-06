using System.ComponentModel;

namespace Andraste.UILauncher.Wizards.AddProfileWizard
{
    partial class SelectAndrastePath
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
            this.lblDescription = new System.Windows.Forms.Label();
            this.rbBuiltin = new System.Windows.Forms.RadioButton();
            this.rbExternal = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblFrameworkPath = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.dlgOpenAndraste = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.Location = new System.Drawing.Point(12, 9);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(438, 34);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Please choose which Andraste Framework Distribution to pick.\r\nIn most cases using" + " the bundled Andraste Framework is recommended.";
            // 
            // rbBuiltin
            // 
            this.rbBuiltin.Checked = true;
            this.rbBuiltin.Location = new System.Drawing.Point(12, 55);
            this.rbBuiltin.Name = "rbBuiltin";
            this.rbBuiltin.Size = new System.Drawing.Size(175, 24);
            this.rbBuiltin.TabIndex = 3;
            this.rbBuiltin.TabStop = true;
            this.rbBuiltin.Text = "Bundled Andraste Framework";
            this.rbBuiltin.UseVisualStyleBackColor = true;
            // 
            // rbExternal
            // 
            this.rbExternal.Location = new System.Drawing.Point(12, 76);
            this.rbExternal.Name = "rbExternal";
            this.rbExternal.Size = new System.Drawing.Size(168, 24);
            this.rbExternal.TabIndex = 4;
            this.rbExternal.Text = "External Andraste Framework";
            this.rbExternal.UseVisualStyleBackColor = true;
            this.rbExternal.CheckedChanged += new System.EventHandler(this.rbExternal_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(128, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(311, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblFrameworkPath
            // 
            this.lblFrameworkPath.Enabled = false;
            this.lblFrameworkPath.Location = new System.Drawing.Point(30, 103);
            this.lblFrameworkPath.Name = "lblFrameworkPath";
            this.lblFrameworkPath.Size = new System.Drawing.Size(92, 23);
            this.lblFrameworkPath.TabIndex = 6;
            this.lblFrameworkPath.Text = "Framework Path:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Enabled = false;
            this.btnBrowse.Location = new System.Drawing.Point(445, 97);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 7;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // dlgOpenAndraste
            // 
            this.dlgOpenAndraste.DefaultExt = "dll";
            this.dlgOpenAndraste.FileName = "Andraste.Payload.Generic.dll";
            this.dlgOpenAndraste.Filter = "Andraste Payload|*.dll";
            // 
            // SelectAndrastePath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.lblFrameworkPath);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rbExternal);
            this.Controls.Add(this.rbBuiltin);
            this.Controls.Add(this.lblDescription);
            this.Name = "SelectAndrastePath";
            this.Size = new System.Drawing.Size(523, 161);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.OpenFileDialog dlgOpenAndraste;

        private System.Windows.Forms.Button btnBrowse;

        private System.Windows.Forms.Label lblFrameworkPath;

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.RadioButton rbExternal;

        private System.Windows.Forms.RadioButton rbBuiltin;

        private System.Windows.Forms.GroupBox grpExternal;

        private System.Windows.Forms.Label lblDescription;

        #endregion
    }
}