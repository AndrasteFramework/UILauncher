using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Andraste.UILauncher.Profiles;
using Semver;

namespace Andraste.UILauncher.Wizards.AddProfileWizard
{
    public partial class AddProfileWizardForm : Form
    {
        // TODO: sadly, the file dialogs don't take the input we give them as default, they stay where they last were.
        //  maybe we have to fix that by removing the "remember last path".
        
        protected int CurrentPage = 0;
        // TODO: In theory we don't care about the abstract class, but the union of IWizardPage and Control
        protected readonly List<AWizardPage> Pages = new List<AWizardPage>();
        
        public delegate void ReevaluateButtonsDelegate();

        private Profile? _profile;
        private readonly SelectGamePath _gamePath;
        private readonly SelectProfileName _profileName;
        private readonly SelectProfilePath _profilePath;
        private readonly SelectAndrastePath _andrastePath;
        
        public AddProfileWizardForm()
        {
            InitializeComponent();
            _gamePath = new SelectGamePath();
            _profileName = new SelectProfileName();
            _profilePath = new SelectProfilePath(_profileName);
            _andrastePath = new SelectAndrastePath();
            Pages.Add(_gamePath);
            Pages.Add(_profileName);
            Pages.Add(_profilePath);
            Pages.Add(_andrastePath);

            SetPage(0);
        }

        protected virtual void SetPage(int pageIndex)
        {
            // TODO: Maybe we shouldn't set "currentPage" here but let it be set outside and just call this refresh?
            CurrentPage = pageIndex;
            DisengagePages();

            var page = Pages[CurrentPage];
            pnlContent.Controls.Add(page);
            EngagePage(page);
        }

        private void DisengagePages()
        {
            foreach (var pnl in pnlContent.Controls)
            {
                if (pnl is AWizardPage wizard)
                {
                    DisengagePage(wizard);
                }
            }
            pnlContent.Controls.Clear();
        }

        protected virtual void EngagePage(AWizardPage page)
        {
            page.OnPageVisit();
            page.OnReevaluate = OnReevaluateHandler;
            OnReevaluateHandler(); // Updates buttons
        }

        protected virtual void DisengagePage(AWizardPage page)
        {
            page.OnReevaluate = null;
        }

        protected virtual void OnReevaluateHandler()
        {
            UpdateButtons(CurrentPage, Pages.Count, Pages[CurrentPage].CanContinue);
        }

        protected virtual void UpdateButtons(int currentIndex, int nbOfPages, bool canContinue)
        {
            // TODO: Params can be omitted, once we have a List<Page> and an index on this level.
            if (currentIndex == 0)
            {
                // prevent previous.
                btnNext.Enabled = canContinue;
                btnPrev.Enabled = false;
                btnNext.Text = "Next";
            } else if (currentIndex == nbOfPages - 1)
            {
                // prevent next
                btnNext.Enabled = canContinue;
                btnPrev.Enabled = true;
                btnNext.Text = "Finish";
            }
            else
            {
                // prevent nothing.
                btnNext.Enabled = canContinue;
                btnPrev.Enabled = true;
                btnNext.Text = "Next";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // TODO: Call abort listeners.
            DisengagePages();
            Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CurrentPage < Pages.Count - 1)
            {
                SetPage(CurrentPage + 1);
            }
            else
            {
                Finish();
                DisengagePages();
                Close();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (CurrentPage > 0)
            {
                SetPage(CurrentPage - 1);
            }
        }

        private void Finish()
        {
            _profile = new Profile
            {
                Enabled = true,
                AndrasteVersion = new SemVersion(0, 2, 2), // TODO: Implement
                Name = _profileName.ProfileName,
                FrameworkLocation = _andrastePath.FrameworkLocation,
                GameExecutable = _gamePath.GameExecutable,
                ProfileFolder = _profilePath.ProfileFolder,
                CommandLine = _gamePath.CommandLine,
            };
        }

        public Profile? BuildProfile()
        {
            return _profile;
        }
    }
}