using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Andraste.UILauncher.Profiles;
using Andraste.UILauncher.Util;
using Andraste.UILauncher.Wizards.AddProfileWizard;

namespace Andraste.UILauncher.Forms
{
    public partial class ProfileEditorForm : Form
    {
        public ProfileEditorForm()
        {
            InitializeComponent();
            listView1.FullRowSelect = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var wizard = new AddProfileWizardForm();
            wizard.FormClosing += (o, args) =>
            {
                var profile = wizard.BuildProfile();
                if (profile != null)
                {
                    if (CreateFolders(profile))
                    {
                        listView1.Items.Add(FromProfile(profile));
                    }
                } // else: Dialog has been cancelled
            };
            wizard.ShowDialog(this);
        }
        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }
            
            var editForm = new EditProfileForm();
            editForm.EditMode(FromListViewItem(listView1.SelectedItems[0]));
            editForm.FormClosing += (o, args) =>
            {
                var profile = editForm.GetInputAsProfile();
                if (CreateFolders(profile))
                {
                    profile.Enabled =
                        listView1.SelectedItems[0]
                            .Checked; // Store the enabled state, that is not part of the EditProfileForm
                    listView1.Items[listView1.SelectedIndices[0]] = FromProfile(profile);
                }
            };
            editForm.Show(this);
        }

        private static ListViewItem FromProfile(Profile profile)
        {                
            var item = new ListViewItem();
            item.SubItems.Add(profile.Name);
            item.SubItems.Add(profile.GameExecutable);
            item.SubItems.Add(profile.ProfileFolder);
            item.Checked = profile.Enabled;
            item.Tag = profile;
            return item;
        }

        private static Profile FromListViewItem(ListViewItem item)
        {
            var profile = (Profile)item.Tag;
            profile.Enabled = item.Checked;
            return profile;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        public List<Profile> GetAllProfiles()
        {
            var list = new List<Profile>();
            foreach (ListViewItem item in listView1.Items)
            {
                list.Add(FromListViewItem(item));
            }

            return list;
        }

        public void FakeLoad(List<Profile> profiles)
        {
            foreach (var profile in profiles)
            {
                listView1.Items.Add(FromProfile(profile));
            }
        }

        /// <summary>
        /// Creates all the required folders/files for that profile to work.
        /// This is invoked after creating a new profile or updating an existing one.
        /// </summary>
        /// <param name="profile">The profile in question</param>
        /// <returns>true, if the folders could be created.</returns>
        public bool CreateFolders(Profile profile)
        {
            try
            {
                Directory.CreateDirectory(profile.ProfileFolder);
                Directory.CreateDirectory(Path.Combine(profile.ProfileFolder, "mods"));
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(new WindowWrapper(Handle),
                    $"Could not create the folder {profile.ProfileFolder}: {ex.Message}",
                    $"Error when creating {profile.ProfileFolder}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        private void btnDeleteProfile_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }

            var profile = FromListViewItem(listView1.SelectedItems[0]);
            var text = $"Do you really want to delete the profile \"{profile.Name}\" in {profile.ProfileFolder}?\n";
            text += "Note: Andraste UI will *NOT* delete the folder, you have to do that manually";
            var res = MessageBox.Show(new WindowWrapper(Handle), text, "Delete Profile?", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (res == DialogResult.Yes)
            {
                listView1.SelectedItems[0].Remove();
            }
        }
    }
}