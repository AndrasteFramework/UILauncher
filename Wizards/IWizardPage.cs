using Andraste.UILauncher.Wizards.AddProfileWizard;

namespace Andraste.UILauncher.Wizards
{
    public interface IWizardPage
    {
        public AddProfileWizardForm.ReevaluateButtonsDelegate? OnReevaluate { get; set; }
        public bool CanContinue { get; }

        public void OnPageVisit();
    }
}