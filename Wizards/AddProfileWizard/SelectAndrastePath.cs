using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Andraste.UILauncher.Util;

namespace Andraste.UILauncher.Wizards.AddProfileWizard
{
    public partial class SelectAndrastePath : AWizardPage
    {
        private static readonly string BundledFramework = Path.Combine(
            Directory.GetParent(Assembly.GetEntryAssembly()!.Location).FullName,
            "GenericFramework", "Andraste.Payload.Generic.dll");
        public override bool CanContinue => !rbExternal.Checked || File.Exists(textBox1.Text);
        public string FrameworkLocation => rbExternal.Checked ? textBox1.Text : BundledFramework;

        public SelectAndrastePath()
        {
            InitializeComponent();
        }

        private void rbExternal_CheckedChanged(object sender, EventArgs e)
        {
            lblFrameworkPath.Enabled = rbExternal.Checked;
            textBox1.Enabled = rbExternal.Checked;
            btnBrowse.Enabled = rbExternal.Checked;
            OnReevaluate?.Invoke();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (dlgOpenAndraste.ShowDialog(new WindowWrapper(Handle)) == DialogResult.OK)
            {
                textBox1.Text = dlgOpenAndraste.FileName;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            OnReevaluate?.Invoke();
        }
    }
}