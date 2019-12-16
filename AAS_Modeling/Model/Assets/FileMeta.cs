using System;
using System.IO;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace AAS_Modeling.Model.Assets
{
    [BsonIgnoreExtraElements]
    public class FileMeta
    {
        public string FileName { get; set; }
        public string FileDescription { get; set; }
        public string FilePath { get; set; }
        [JsonIgnore]
        public FileInfo FileInfo { get; set; }

        public string FileExtention => FileInfo.Extension;
        public string FileFullName => FileInfo.FullName;
        public long FileLength => FileInfo.Length;
        public DateTime FileCreationTimeUtc => FileInfo.CreationTimeUtc;
        public DateTime FileLastAccessTimeUtc => FileInfo.LastAccessTimeUtc;
        public DateTime FileLastWriteTimeUtc => FileInfo.LastWriteTimeUtc;
    }
}