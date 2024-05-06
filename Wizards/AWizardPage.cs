using System.Windows.Forms;
using Andraste.UILauncher.Wizards.AddProfileWizard;

namespace Andraste.UILauncher.Wizards
{
    public abstract class AWizardPage: UserControl, IWizardPage
    {
        public AddProfileWizardForm.ReevaluateButtonsDelegate? OnReevaluate { get; set; }
        public virtual void OnPageVisit()
        {
        }

        public abstract bool CanContinue { get; }
    }
}