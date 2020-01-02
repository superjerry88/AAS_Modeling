using System;
using AAS_Core.Model.Enum;
using AAS_Core.Model.Identifier;
using MongoDB.Bson.Serialization.Attributes;

namespace AAS_Core.Model.Assets
{
    [BsonIgnoreExtraElements]
    public class BaseAsset
    {
        public Irai Irai { get; set; }
        public string FullName { get; set; }
        public string Description { get; set; }
        public AssetCategory AssetCategory { get; set; }
        public BrokerMeta BrokerMeta { get; set; }
        public DateTime LastUpdated { get; set; }
        public DateTime Created { get; set; }
    }
}
