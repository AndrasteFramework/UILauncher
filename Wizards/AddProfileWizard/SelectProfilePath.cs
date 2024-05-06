using System;
using System.IO;
using Andraste.UILauncher.Util;

namespace Andraste.UILauncher.Wizards.AddProfileWizard
{
    public partial class SelectProfilePath : AWizardPage
    {
        private readonly SelectProfileName _profileName;
        public override bool CanContinue => textBox1.Text.Length > 0 && IsPathValid(textBox1.Text);
        public string ProfileFolder => textBox1.Text;

        public SelectProfilePath(SelectProfileName selectProfileName)
        {
            InitializeComponent();
            _profileName = selectProfileName;
        }
        
        public override void OnPageVisit()
        {
            if (textBox1.Text.Length != 0)
            {
                return;
            }
        
            var documentFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            textBox1.Text = Path.Combine(documentFolder, "Andraste", "Profiles", _profileName.ProfileName);
        }

        private bool IsPathValid(string path)
        {
            try
            {
                var unused = Path.GetDirectoryName(path);
                return true;
            }
            catch (ArgumentException exception)
            {
                // TODO: Print that as error.
                return false;
            }
            catch (PathTooLongException exception)
            {
                // TODO: Print that as error.
                return false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            OnReevaluate?.Invoke();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var picker = new FolderPicker
            {
                InputPath = textBox1.Text,
                FileNameLabel = textBox1.Text,
            };
            
            if (picker.ShowDialog(Handle) == true)
            {
                textBox1.Text = picker.ResultPath;
            }
        }
    }
}