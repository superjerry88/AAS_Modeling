using System;
using AAS_Modeling.Model.Enum;
using AAS_Modeling.Model.Identifier;

namespace AAS_Modeling.Model.Assets
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
}
