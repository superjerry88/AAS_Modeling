using System;
using System.IO;
using System.Text;

namespace AAS_Modeling
{
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
        public string FilePath { get; set; }
        public FileInfo FileInfo { get; set; }
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
