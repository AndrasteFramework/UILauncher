using System;
using System.IO;
using System.Windows.Forms;
using Andraste.UILauncher.Util;

namespace Andraste.UILauncher.Wizards.AddProfileWizard
{
    public partial class SelectGamePath : AWizardPage
    {
        public SelectGamePath()
        {
            InitializeComponent();
        }

        public override bool CanContinue => File.Exists(txtGameLocation.Text);
        public string GameExecutable => txtGameLocation.Text;
        public string CommandLine => txtCommandLine.Text;

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (dlgBrowseGame.ShowDialog(new WindowWrapper(Handle)) == DialogResult.OK)
            {
                txtGameLocation.Text = dlgBrowseGame.FileName;
            }
        }

        private void txtGameLocation_TextChanged(object sender, EventArgs e)
        {
            OnReevaluate?.Invoke();
        }
    }
}