using AuroraLoader.Mods;
using Semver;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AuroraLoader.Registry
{
    public class AuroraResources
    {

        [JsonPropertyName("resources")]
        public List<uxResource> UxResources { get; set; } = new List<uxResource>();

        [JsonPropertyName("aurora_versions")]
        public  List<AuroraBinaryResources> AuroraGameVersions { get; set; } = new List<AuroraBinaryResources>();

        public static AuroraResources DeserializeAuroraResources(string rawJson)
        {
            var deserialized = JsonSerializer.Deserialize<AuroraResources>(rawJson, new JsonSerializerOptions()
            {
                ReadCommentHandling = JsonCommentHandling.Skip,
                PropertyNameCaseInsensitive = true,
            });
            return deserialized;
        }
        public class uxResource
        {
            [JsonPropertyName("name")]
            public string Name { get; set; }

            [JsonPropertyName("download_url")]
            public string DownloadUrl { get; set; }

        }
        public class AuroraBinaryResources
        {
            [JsonPropertyName("major_version")]
            [JsonConverter(typeof(SemVersionJsonConverter))]
            public SemVersion MajorVersion { get; set; }

            [JsonPropertyName("checksum")]
            public string checksum { get; set; }

            [JsonPropertyName("download_url")]
            public string DownloadUrl { get; set; }

            [JsonPropertyName("patches")]
            public List<BinaryPatches> Patches { get; set; } = new List<BinaryPatches>();

            [JsonPropertyName("updates")]
            public List<BinaryMinorUpdateInfo> MinorVersionInfo { get; set; } = new List<BinaryMinorUpdateInfo>();

            

            public class BinaryMinorUpdateInfo
            {

                [JsonPropertyName("minor_version")]
                [JsonConverter(typeof(SemVersionJsonConverter))]

                public SemVersion MinorVersion { get; set; }

                [JsonPropertyName("checksum")]
                public string checksum { get; set; }

                [JsonPropertyName("download_url")]
                public string DownloadUrl { get; set; }

                [JsonPropertyName("patches")]
                public List<BinaryPatches> Patches { get; set; } = new List<BinaryPatches>();
            }

            public class BinaryPatches
            {
                [JsonPropertyName ("patch_version")]
                [JsonConverter(typeof(SemVersionJsonConverter))]
                public SemVersion PatchVersion { get; set; }

                [JsonPropertyName("checksum")]
                public string checksum { get; set; }

                [JsonPropertyName("download_url")]
                public string DownloadUrl { get; set; }

                
            }

        }

        
    }
}
