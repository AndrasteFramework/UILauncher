using System;
using System.IO;
using System.Windows.Forms;
using Andraste.UILauncher.Profiles;
using Andraste.UILauncher.Util;
using Semver;

namespace Andraste.UILauncher.Forms
{
    public partial class EditProfileForm : Form
    {
        public EditProfileForm()
        {
            InitializeComponent();
        }

        public void EditMode(Profile profile)
        {
            txtProfile.Text = profile.Name;
            txtProfileLocation.Text = profile.ProfileFolder;
            txtGameLocation.Text = profile.GameExecutable;
            txtFrameworkLocation.Text = profile.FrameworkLocation;
            txtCommandLine.Text = profile.CommandLine;
            UpdateOkButton();
        }

        public Profile GetInputAsProfile()
        {
            return new Profile
            {
                Enabled = false,
                Name = txtProfile.Text,
                ProfileFolder = txtProfileLocation.Text,
                GameExecutable = txtGameLocation.Text,
                FrameworkLocation = txtFrameworkLocation.Text,
                CommandLine = txtCommandLine.Text,
                AndrasteVersion = new SemVersion(0, 2, 0) // TODO: Implement Combobox.
            };
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        private static string BuildAndrastePath()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Andraste");
        }

        private void btnBrowseProfileLocation_Click(object sender, EventArgs e)
        {
            var picker = new FolderPicker
            {
                InputPath = Path.Combine(BuildAndrastePath(), "profiles", txtProfile.Text),
                FileNameLabel = Path.Combine(BuildAndrastePath(), "profiles", txtProfile.Text)
            };
            
            if (picker.ShowDialog(Handle) == true)
            {
                txtProfileLocation.Text = picker.ResultPath;
            }
            UpdateOkButton();
        }

        private void btnBrowseGame_Click(object sender, EventArgs e)
        {
            if (openGameExeDialog.ShowDialog(new WindowWrapper(Handle)) == DialogResult.OK)
            {
                txtGameLocation.Text = openGameExeDialog.FileName;
            }
            UpdateOkButton();
        }

        private void btnFrameworkLocation_Click(object sender, EventArgs e)
        {
            dlgOpenAndrasteDll.InitialDirectory = Path.Combine(BuildAndrastePath(), "Frameworks", "0.2.2");
            if (dlgOpenAndrasteDll.ShowDialog(new WindowWrapper(Handle)) == DialogResult.OK)
            {
                txtFrameworkLocation.Text = dlgOpenAndrasteDll.FileName;
            }
            UpdateOkButton();
        }

        private bool ValidateForm()
        {
            return Directory.Exists(txtProfileLocation.Text) && File.Exists(txtFrameworkLocation.Text) &&
                   File.Exists(txtGameLocation.Text);
        }

        private void UpdateOkButton()
        {
            btnOk.Enabled = ValidateForm();
        }
    }
}