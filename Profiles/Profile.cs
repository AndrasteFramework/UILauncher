using System;
using Semver;

namespace Andraste.UILauncher.Profiles
{
    public class Profile
    {
        /// <summary>
        /// This is not serialized and only used to reference to a profile folder
        /// </summary>
        public string ProfileFolder { get; set; }
        
        public bool Enabled { get; set; }
        public string Name { get; set; }
        
        // TODO: bring semver back, but not in that way, it's not serializable like this.
        [NonSerialized] public SemVersion AndrasteVersion;
        public string GameExecutable { get; set; }
        public string CommandLine { get; set; }
        
        /// <summary>
        /// Until we can rely on AndrasteVersion to just download and cache the DLLs in some app data location,
        /// the user needs to specify a custom andraste framework to use.
        /// This may also be used for framework developers, so they can point the andraste location to their IDE
        /// Note that this denotes the actual path *TO THE DLL* already.
        /// </summary>
        public string FrameworkLocation { get; set; }

        public override string ToString()
        {
            return $"{Name}"; // TODO: (Andraste {AndrasteVersion})";
        }
    }
}