using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Andraste.Shared.ModManagement;
using Andraste.Shared.ModManagement.Json;
using Andraste.UILauncher.Forms;
using Andraste.UILauncher.Profiles;
using Andraste.UILauncher.Util;
using NLog;

namespace Andraste.UILauncher
{
    public partial class Form1 : Form
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        private List<Profile> _profiles = new List<Profile>();

        public Form1()
        {
            InitializeComponent();
        }

#nullable enable
        private static async Task<List<ModEntry>> FindMods(Profile profile)
        {
            var list = new List<ModEntry>();
            foreach (var mod in PotentialModEnumerator.FindAllPotentialMods(Path.Combine(
                         profile.ProfileFolder, "mods")))
            {
                var str = await AsyncUtils.ReadAllTextAsync(Path.Combine(mod, "mod.json"));
                var modInfo = ModInformationParser.ParseString(str);
                if (modInfo != null)
                {
                    list.Add(new ModEntry
                    {
                        Information = modInfo,
                        FullPath = mod
                    });
                }
                else
                {
                    Logger.Warn($"Could not parse {Path.Combine(mod, "mod.json")}");
                }
            }

            return list;
        }
        
        private static async Task<bool> WriteModsJson(Profile profile, List<ModEntry> enabledModInformation)
        {
            var enabledMods = new List<ModSetting>();

            foreach (var mod in enabledModInformation)
            {
                if (!mod.Enabled)
                {
                    continue;
                }
                
                if (mod.Information.Slug != null)
                {
                    string active;
                    if (mod.Information.Configurations.Count == 1)
                    {
                        active = mod.Information.Configurations.First().Key;
                    }
                    else
                    {
                        if (mod.Information.Configurations.ContainsKey("default"))
                        {
                            active = "default";
                        }
                        else
                        {
                            MessageBox.Show($"{mod.Information.Slug} has {mod.Information.Configurations.Count} configurations, " +
                                                    "but none of it is called `default`. Manually picking one is TODO");
                            return false;
                        }
                    }

                    enabledMods.Add(new ModSetting
                    {
                        ModPath = mod.FullPath,
                        ActiveConfiguration = active
                    });
                }
            }

            // TODO: Do shit with the features to resolve conflicts
            var settings = new ModSettings
            {
                EnabledMods = enabledMods.ToArray()
            };
            
            await AsyncUtils.WriteAllBytesAsync(Path.Combine(profile.ProfileFolder, "mods.json"),
                JsonSerializer.SerializeToUtf8Bytes(settings, new JsonSerializerOptions { WriteIndented = true }));
            return true;
        }

        private async Task RefreshMods(Profile? profile)
        {
            btnRefreshMods.Enabled = false;
            progressBar1.Style = ProgressBarStyle.Marquee;
            listView1.CheckBoxes = true;
            listView1.Items.Clear();

            if (profile != null)
            {
                var modsJson = Path.Combine(profile.ProfileFolder, "mods.json");
                ModSettings? settings = null;
                if (File.Exists(modsJson))
                {
                    settings = JsonSerializer.Deserialize<ModSettings>(await AsyncUtils.ReadAllTextAsync(modsJson));
                }
                
                listView1.Enabled = true;
                var mods = await FindMods(profile);

                int loadOrder = 1;
                foreach (var modEntry in mods)
                {
                    var mod = modEntry.Information;
                    var item = new ListViewItem();
                    item.SubItems.Add($"{mod.Name}");
                    item.SubItems.Add(mod.Description);
                    item.SubItems.Add(string.Join(", ", mod.Authors));
                    item.SubItems.Add(mod.DisplayVersion);
                    item.SubItems.Add($"{loadOrder++}");
                    item.Tag = modEntry;
                    item.Checked = settings == null || settings.EnabledMods.Any(setting => setting.ModPath == modEntry.FullPath);

                    listView1.Items.Add(item);
                }
            }
            else
            {
                listView1.Enabled = false;
            }

            progressBar1.Style = ProgressBarStyle.Blocks;
            btnRefreshMods.Enabled = true;
        }

        private async void btnRefreshMods_Click(object sender, EventArgs e)
        {
            if (dropProfile.SelectedIndex != -1)
            {
                await RefreshMods((Profile)dropProfile.SelectedItem);
            }
        }
        
        private async void dropProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropProfile.SelectedIndex != -1)
            {
                await RefreshMods((Profile)dropProfile.SelectedItem);
            }
        }

        private async void Form1_Shown(object sender, EventArgs e)
        {
            dropProfile.SelectedIndex = -1;
            dropProfile.Enabled = false;
            _profiles = await LoadProfiles();
            UpdateProfileDropdown();
        }

        private static async Task<List<Profile>> LoadProfiles()
        {
            if (!File.Exists("profiles.json"))
            {
                return new List<Profile>();
            }

            using (var stream = File.Open("profiles.json", FileMode.Open, FileAccess.Read, FileShare.None))
            {
                return await JsonSerializer.DeserializeAsync<List<Profile>>(stream) ?? new List<Profile>();
            }
        }

        private static async Task SaveProfiles(List<Profile> profiles)
        {
            using (var stream = File.Open("profiles.json", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                await JsonSerializer.SerializeAsync(stream, profiles);
            }
        }

        private void listView1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var item = listView1.HitTest(e.X,e.Y).Item;
                
                var m = new ContextMenu();
                if (item != null)
                {
                    m.MenuItems.Add(new MenuItem(item.Checked ? "Disable" : "Enable", (o, args) => item.Checked = !item.Checked));
                    // m.MenuItems.Add(new MenuItem($"Do something to {item.SubItems[1].Text}"));
                    // m.MenuItems.Add(new MenuItem("About"));
                }

                m.Show(listView1, new Point(e.X, e.Y));
            }
        }

        private void btnManageProfiles_Click(object sender, EventArgs e)
        {
            // Once loading and saving is implemented, we don't need it that way, because closing the editor form will save
            // and re-opening it will load again.
            var profileEditor = new ProfileEditorForm();
            if (_profiles != null)
            {
                profileEditor.FakeLoad(_profiles);
            }

            profileEditor.FormClosing += async (o, args) =>
            {
                _profiles = profileEditor.GetAllProfiles();
                await SaveProfiles(_profiles);
                UpdateProfileDropdown();
            };
            profileEditor.ShowDialog(this);
        }

        /// <summary>
        /// Updates the UI based on the new set of <code>_profiles</code>
        /// This will also trigger a refreshing of available mods, when the profile has changed.
        /// TODO: This currently always selects the first profile no matter what had been enabled first.
        /// </summary>
        private void UpdateProfileDropdown()
        {
            // TODO: This could cache the old selected profile somehow and try to re-select it, where possible.
            // maybe we could simply do it by name?
            dropProfile.Items.Clear();
            var activeProfiles = _profiles.Where(x => x.Enabled).ToList();
            activeProfiles.ForEach(profile => dropProfile.Items.Add(profile));
            dropProfile.SelectedIndex = activeProfiles.Count > 0 ? 0 : -1;
            dropProfile.Enabled = activeProfiles.Count > 0;
            btnStartGame.Enabled = activeProfiles.Count > 0;
        }

        private async void btnStartGame_Click(object sender, EventArgs e)
        {
            if (dropProfile.SelectedIndex == -1)
            {
                MessageBox.Show(new WindowWrapper(Handle), "Please select a profile to use");
                return;
            }

            btnStartGame.Enabled = false;
            var activeProfile = (Profile)dropProfile.SelectedItem;
            var enabledMods = new List<ModEntry>();
            
            foreach (var itemObject in listView1.Items)
            {
                var item = (ListViewItem)itemObject;
                var modEntry = (ModEntry)item.Tag;
                modEntry.Enabled = item.Checked;
                
                enabledMods.Add(modEntry);
            }

            try
            {
                if (!await WriteModsJson(activeProfile, enabledMods))
                {
                    MessageBox.Show("Error when writing mods.json. Launching not successful");
                    btnStartGame.Enabled = true;
                    return;
                }
                
                // TODO: Rather envisioning something like that. Do NOT over-fill the CLI, some windows have a limit of 256 and long paths already.
                // Also, a json is more typesafe and a better way of documenting things, we could even upgrade that way.
                // FrameworkLocation\Andraste.Launcher.exe --ui-proc <PID> --run-profile /tmp/profile.json
                // actually, W7 seems to limit at 32768, XP at 2048, but the other comments still hold. upgradable json 
                // api that is mapped to a struct, maybe.
                
                var frameworkFolder = Directory.GetParent(activeProfile.FrameworkLocation)!.FullName;
                var builder = new StringBuilder();
                builder.Append("--non-interactive ");
                builder.Append("launch ");
                builder.Append($"--file=\"{activeProfile.GameExecutable}\" ");
                builder.Append($"--modsJsonPath=\"{Path.Combine(activeProfile.ProfileFolder, "mods.json")}\" ");
                builder.Append($"--frameworkDll=\"{activeProfile.FrameworkLocation}\" ");
                builder.Append($"--commandLine=\"{activeProfile.CommandLine}\"");
                
                var launcherStartInfo = new ProcessStartInfo(Path.Combine(frameworkFolder, "Andraste.Launcher.exe"), builder.ToString())
                {
                    UseShellExecute = false,
                    WorkingDirectory = frameworkFolder
                };
                // Console.WriteLine(launcherStartInfo.FileName);
                // Console.WriteLine(launcherStartInfo.Arguments);
                
                var launcher = Process.Start(launcherStartInfo);
                if (launcher != null)
                {
                    await launcher.WaitForExitAsync();
                    var pid = launcher.ExitCode;
                }
            }
            finally
            {
                btnStartGame.Enabled = true;
            }
        }

        private void btnOpenModFolder_Click(object sender, EventArgs e)
        {
            var activeProfile = (Profile)dropProfile.SelectedItem;
            if (activeProfile == null)
            {
                return;
            }
            
            // Note: This may not be perfect as you can have shared/linked mods across multiple profiles, in the future.
            // maybe we can still offer something like that for convenience, though.
            
            using (Process.Start(Path.Combine(activeProfile.ProfileFolder, "mods") + Path.DirectorySeparatorChar)) {}
        }

    }
#nullable restore
}