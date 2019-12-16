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
        public string FileExtention { get; set; }
        public string FileFullName { get; set; }
        public long FileLength { get; set; }

        public DateTime FileCreationTimeUtc { get; set; }
        public DateTime FileLastAccessTimeUtc { get; set; }
        public DateTime FileLastWriteTimeUtc { get; set; }

        public FileMeta(FileInfo fileInfo)
        {
            FileExtention = fileInfo.Extension;
            FileFullName = fileInfo.FullName;
            FileLength = fileInfo.Length;
            FileCreationTimeUtc = FileCreationTimeUtc;
            FileLastAccessTimeUtc = FileLastAccessTimeUtc;
            FileLastWriteTimeUtc = FileLastWriteTimeUtc;
        }

        public FileMeta()
        {
        }
    }
}