namespace Andraste.UILauncher.Wizards.AddProfileWizard
{
    public partial class SelectProfileName : AWizardPage
    {
        public SelectProfileName()
        {
            InitializeComponent();
        }

        public string ProfileName => textBox1.Text;
        public override bool CanContinue => true;
    }
}