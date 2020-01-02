namespace AAS_Core.Model.Identifier
{
    public class AssetCode //Company Specific
    {
        public string IraiCode => $"{SiteCode}{AreaCode}{ProcessCode}{UniqueCode}";
        public string AssetDescription { get; set; }

        public string SiteCode { get; set; }
        public string SiteName { get; set; }

        public string AreaCode { get; set; }
        public string AreaName { get; set; }

        public string ProcessCode { get; set; }
        public string ProcessName { get; set; }

        public string UniqueCode { get; set; }
   
    }
}