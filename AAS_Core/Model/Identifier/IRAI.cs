using System.Collections.Generic;

namespace AAS_Core.Model.Identifier
{
    public class Irai
    {
        public string FullCode =>
            $"0990-{AssetGeoLocation.IraiCode}{Subdivision.IraiCode}{AssetOrganization.IraiCode}-#{Dimension.IraiCode}-{AssetCode.IraiCode}#{LastestVersion.IraiCode}";
        public AssetGeoLocation AssetGeoLocation { get; set; } = new AssetGeoLocation();
        public AssetSubdivision Subdivision { get; set; } = new AssetSubdivision();
        public AssetOrganization AssetOrganization { get; set; } = new AssetOrganization();
        public AssetOwner Owner { get; set; } = new AssetOwner();
        public AssetDimension Dimension { get; set; } = new AssetDimension();
        public AssetCode AssetCode { get; set; } = new AssetCode();
        public AssetVersion LastestVersion { get; set; } = new AssetVersion();
        public List<AssetVersion> Versions { get; set; } = new List<AssetVersion>();
    }
}
