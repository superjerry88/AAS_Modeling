using System;
using System.IO;
using System.Text;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using Newtonsoft.Json;

namespace AAS_Modeling
{
    
    [BsonIgnoreExtraElements]
    public class BaseAsset
    {
        public IRAI IRAI { get; set; }
        public string FullName { get; set; }
        public string Description { get; set; }
        public AssetCategory AssetCategory { get; set; }
        public BrokerMeta BrokerMeta { get; set; }
        public DateTime LastUpdated { get; set; }
        public DateTime Created { get; set; }
    }

    
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


    public enum AssetCategory
    {
        TableValue,
        SingleValue,
        Files,
        Linkage,
        Composite
    }

    public enum AssetKind
    {
        Instance,
        Type,
        NonSpecified
    }

    public class DataModel
    {
        public string Language { get; set; }
        public string Model { get; set; }
    }

    public class BrokerMeta
    {

    }
}
