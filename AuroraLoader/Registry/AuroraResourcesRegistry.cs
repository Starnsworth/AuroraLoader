using AuroraLoader.Mods;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace AuroraLoader.Registry
{
    public class AuroraResourcesRegistry
    {
        /*
         * Instead of checking Aurora_files.ini and Aurora_versions.ini, AuroraResources.json unifies all resources for management on a per-save basis.
         * This mitigates lengthy start-up time and will be utilised to allow per-save 'a la carte' versioning as well as resource caching.
         * This could also be utilised for on-demand version upgrading and downgrading if save compatability information was added to AuroraResources.json.
         */
        private readonly IConfiguration _configuration;
        private readonly string _resourceJsonPath = Path.Combine(Program.AuroraLoaderExecutableDirectory, "AuroraResources.json");
        public List<AuroraVersion> AuroraVersions { get; private set; } = new List<AuroraVersion>();

        public AuroraResourcesRegistry(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void Update(IList<string> mirrors = null)
        {
            if (!File.Exists(_resourceJsonPath) && mirrors == null)
            {
                throw new Exception($"Aurora version cache not found at {_resourceJsonPath} and no mirrors provided");
            }
            if (File.Exists(_resourceJsonPath))
            {
                UpdateKnownVersionsFromJsonCache();
            }
            if (mirrors != null)
            {
                UpdateKnownVersionsFromMirrors(mirrors);
            }

        }

        internal void UpdateKnownVersionsFromJsonCache()
        {
            var foundversions = new List<AuroraVersion>();
            //Open and read json cache
            var deserialized = AuroraResources.DeserializeAuroraResources(File.ReadAllText(Path.Combine(Program.AuroraLoaderExecutableDirectory, "AuroraResources.json")));
            //find all occurances of the versions.
            try
            {
                foreach (var major in deserialized.AuroraGameVersions)
                {
                    foundversions.Add(new AuroraVersion(major.MajorVersion, major.checksum));
                    foreach (var patch in major.Patches)
                    {
                        foundversions.Add(new AuroraVersion(patch.PatchVersion, patch.checksum));
                    }
                    foreach (var minor in major.MinorVersionInfo)
                    {
                        foundversions.Add(new AuroraVersion(minor.MinorVersion, minor.checksum));
                        foreach (var patch in minor.Patches)
                        {
                            foundversions.Add(new AuroraVersion(patch.PatchVersion, patch.checksum));
                        }
                    }
                }
                AuroraVersions.AddRange(foundversions);
            }
            catch (Exception ex)
            {
                Log.Error($"Failed to parse version data from {_configuration["aurora_known_versions_relative_filepath"]}", ex);
            }
        }

        internal void UpdateKnownVersionsFromMirrors(IList<string> mirrors)
        {
            var allKnownVersions = new List<AuroraVersion>(AuroraVersions);
            foreach (var mirror in mirrors)
            {
                Log.Debug($"Retrieving version information from {mirror} if available");
                var mirrorKnownVersions = new List<AuroraVersion>();
                var resourcesUrl = Path.Combine(mirror, "AuroraResources.json");
                using (var client = new WebClient())
                {
                    try
                    {
                        var response = client.DownloadString(resourcesUrl);
                        var deserialized = AuroraResources.DeserializeAuroraResources(response);
                        foreach (var major in deserialized.AuroraGameVersions)
                        {
                            mirrorKnownVersions.Add(new AuroraVersion(major.MajorVersion, major.checksum));
                            foreach (var patch in major.Patches)
                            {
                                mirrorKnownVersions.Add(new AuroraVersion(patch.PatchVersion, patch.checksum));
                            }
                            foreach (var minor in major.MinorVersionInfo)
                            {
                                mirrorKnownVersions.Add(new AuroraVersion(minor.MinorVersion, minor.checksum));
                                foreach (var patch in minor.Patches)
                                {
                                    mirrorKnownVersions.Add(new AuroraVersion(patch.PatchVersion, patch.checksum));
                                }
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Log.Error($"Didn't find an Aurora version listing at {resourcesUrl}", e);
                    }
                }
                foreach (var version in mirrorKnownVersions)
                {
                    if (!allKnownVersions.Any(existing => version.Checksum == existing.Checksum))
                    {
                        allKnownVersions.Add(version);
                    }
                }
            }
            AuroraVersions.AddRange(allKnownVersions);

        }
    }
}
